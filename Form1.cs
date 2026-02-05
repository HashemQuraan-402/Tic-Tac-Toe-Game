using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{

    struct GameInfo {
        public PlayerType winner;
        public byte GameCount;
        public bool gameOver;
    }

    enum PlayerType {
        Player1,
        Player2,
        Draw,
        InProgress
    }

    

    public partial class Form1 : Form
    {
       // bool flag1;
      //  bool flag2;
        PlayerType playerType = PlayerType.Player1;
        GameInfo gameInfo;
        public Form1()
        {
            InitializeComponent();
            gameInfo = new GameInfo();
            
            gameInfo.gameOver = false;
            gameInfo.GameCount = 0;
        }

        private void ChangeImage(object s) { 
            PictureBox currentpb = (PictureBox)s;

            if (currentpb.Tag.ToString() == "false")
            {
                switch (playerType)
                {
                    case PlayerType.Player1:
                        currentpb.Image = Resources.X;
                        lbPlayer.Text = "Player2";
                        playerType = PlayerType.Player2;
                        gameInfo.GameCount++;
                        currentpb.Tag = "x";
                        break;
                    case PlayerType.Player2:
                        currentpb.Image = Resources.O;
                        lbPlayer.Text = "Player1";
                        playerType = PlayerType.Player1;
                        gameInfo.GameCount++;
                        currentpb.Tag = "o";
                        break;
                }
                CheckWin(currentpb);
                if (gameInfo.GameCount == 9 && !gameInfo.gameOver)
                {
                    gameInfo.gameOver = true;
                    gameInfo.winner = PlayerType.Draw;
                    EndGame();
                }
            }
        }

        void EndGame() {
            lbPlayer.Text = "Game Over";
            pb1.Enabled = pb2.Enabled = pb3.Enabled = pb4.Enabled = pb5.Enabled = pb6.Enabled = pb7.Enabled = pb8.Enabled = pb9.Enabled = false;
            if (gameInfo.winner == PlayerType.Player1) {
                
                lbWinner.Text = "Player1";
                MessageBox.Show("Player1 win , Game Over", "Game Over");
            }else if(gameInfo.winner == PlayerType.Player2)
            {
                lbWinner.Text = "Player2";
                MessageBox.Show("Player2 win , Game Over", "Game Over");
            }else if(gameInfo.winner == PlayerType.Draw) {
                lbWinner.Text = "Draw";
                MessageBox.Show("Draw , Game Over", "Game Over");
            }
        }

        private bool CheckMatch(PictureBox p1, PictureBox p2,PictureBox p3) {
            if (p1.Tag.ToString() != "false" &&
                p1.Tag.ToString() == p2.Tag.ToString() &&
                p1.Tag.ToString() == p3.Tag.ToString() &&
                p3.Tag.ToString() == p2.Tag.ToString()) { 
                
                
                p1.BackColor = p2.BackColor = p3.BackColor = Color.Yellow;
                if (p1.Tag.ToString() == "x")
                {
                    gameInfo.winner = PlayerType.Player1;
                    gameInfo.gameOver = true;
                    EndGame();
                    return true;
                }
                else if (p1.Tag.ToString() == "o") {
                    gameInfo.winner = PlayerType.Player2;
                    gameInfo.gameOver = true;
                    EndGame();
                    return true;
                }
                
            }
            gameInfo.gameOver = false;
            return false;
        }

        private void CheckWin(PictureBox pb)
        {
            if(CheckMatch(pb1,pb2,pb3)) { return; }
            else if (CheckMatch(pb4, pb5, pb6)) { return; }
            else if (CheckMatch(pb7, pb8, pb9)) { return; }
            else if (CheckMatch(pb1, pb4, pb7)) { return; }
            else if (CheckMatch(pb2, pb5, pb8)) { return; }
            else if (CheckMatch(pb3, pb6, pb9)) { return; }
            else if (CheckMatch(pb1, pb5, pb9)) { return; }
            else if (CheckMatch(pb3, pb5, pb7)) { return; }
            
        }

        /*
        private void MadeThePrize() {
            lbPlayer.Text = "Game Over";
            if (flag1)
            {
                
                lbWinner.Text = "Player1";
                MessageBox.Show("Player1 win", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flag2)
            {
                lbWinner.Text = "Player2";
                MessageBox.Show("Player2 win", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                lbWinner.Text = "Draw";
                MessageBox.Show("Draw", "victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pb1.Enabled = pb2.Enabled = pb3.Enabled = pb4.Enabled = pb5.Enabled = pb6.Enabled = pb7.Enabled = pb8.Enabled = pb9.Enabled = false;
        }
        */
        /*
        private void ChangeState(Object s) {
            bool flag3 = false;
            flag1 = false;
            flag2 = false;
            PictureBox p = (PictureBox)s;
            if (p.Tag.ToString() != "false") {
                return;
            }
            if (playerType.ToString() == "Player1")
            {
                
                if ((pb1.Image.ToString() == Resources.question_mark_96.ToString()) && s == pb1)
                {
                    
                    flag3 = true;
                    pb1.Image = Resources.X;
                    pb1.Tag = "truex";
                    if ((pb1.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex") )
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "truex") &&
                        (pb4.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb2.Image.ToString() == Resources.question_mark_96.ToString() && s == pb2)
                {
                    flag3 = true;
                    pb2.Image = Resources.X;
                    pb2.Tag = "truex";
                    if ((pb1.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb8.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb2.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb3.Image.ToString() == Resources.question_mark_96.ToString() && s == pb3)
                {
                    flag3 = true;
                    pb3.Image = Resources.X;
                    pb3.Tag = "truex";
                    if ((pb1.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb3.Tag.ToString() == "truex") &&
                        (pb6.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb3.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb3.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb4.Image.ToString() == Resources.question_mark_96.ToString() && s == pb4)
                {
                    flag3 = true;
                    pb4.Image = Resources.X;
                    pb4.Tag = "truex";
                    if ((pb4.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex") &&
                        (pb6.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb4.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "truex") &&
                        (pb4.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb5.Image.ToString() == Resources.question_mark_96.ToString() && s == pb5)
                {
                    flag3 = true;
                    pb5.Image = Resources.X;
                    pb5.Tag = "truex";
                    if ((pb5.Tag.ToString() == "truex") &&
                        (pb4.Tag.ToString() == "truex") &&
                        (pb6.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb5.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb8.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb5.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb5.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb6.Image.ToString() == Resources.question_mark_96.ToString() && s == pb6)
                {
                    flag3 = true;
                    pb6.Image = Resources.X;
                    pb6.Tag = "truex";
                    if ((pb6.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb6.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb6.Tag.ToString() == "truex") &&
                        (pb4.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb6.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb7.Image.ToString() == Resources.question_mark_96.ToString() && s == pb7)
                {
                    flag3 = true;
                    pb7.Image = Resources.X;
                    pb7.Tag = "truex";
                    if ((pb1.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex") &&
                        (pb4.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb5.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb7.Tag.ToString() == "truex") &&
                        (pb8.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb7.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb8.Image.ToString() == Resources.question_mark_96.ToString() && s == pb8)
                {
                    flag3 = true;
                    pb8.Image = Resources.X;
                    pb8.Tag = "truex";
                    if ((pb8.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb8.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb8.Tag.ToString() == "truex") &&
                        (pb2.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb8.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
                else if (pb9.Image.ToString() == Resources.question_mark_96.ToString() && s == pb9)
                {
                    flag3 = true;
                    pb9.Image = Resources.X;
                    pb9.Tag = "truex";
                    if ((pb9.Tag.ToString() == "truex") &&
                        (pb8.Tag.ToString() == "truex") &&
                        (pb7.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb9.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "truex") &&
                        (pb6.Tag.ToString() == "truex") &&
                        (pb3.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb9.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "truex") &&
                        (pb5.Tag.ToString() == "truex") &&
                        (pb9.Tag.ToString() == "truex"))
                    {
                        flag1 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player2;
                        lbPlayer.Text = "Player2";
                    }
                    
                }
            }
            else {
                
                if (pb1.Image.ToString() == Resources.question_mark_96.ToString() && s == pb1)
                {
                    flag3 = true;
                    pb1.Image = Resources.O;
                    pb1.Tag = "true";
                    if ((pb1.Tag.ToString() == "true") &&
                        (pb2.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb7.Tag.ToString() == "true") &&
                        (pb1.Tag.ToString() == "true") &&
                        (pb4.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb1.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb2.Image.ToString() == Resources.question_mark_96.ToString() && s == pb2)
                {
                    flag3 = true;
                    pb2.Image = Resources.O;
                    pb2.Tag = "true";
                    if ((pb1.Tag.ToString() == "true") &&
                        (pb2.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb2.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb2.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                   
                }
                else if (pb3.Image.ToString() == Resources.question_mark_96.ToString() && s == pb3)
                {
                    flag3 = true;
                    pb3.Image = Resources.O;
                    pb3.Tag = "true";
                    if ((pb1.Tag.ToString() == "true") &&
                        (pb2.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true") &&
                        (pb6.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb3.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb3.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb3.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb4.Image.ToString() == Resources.question_mark_96.ToString() && s == pb4)
                {
                    flag3 = true;
                    pb4.Image = Resources.O;
                    pb4.Tag = "true";
                    if ((pb4.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true") &&
                        (pb6.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb4.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb1.Tag.ToString() == "true") &&
                        (pb4.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb5.Image.ToString() == Resources.question_mark_96.ToString() && s == pb5)
                {
                    flag3 = true;
                    pb5.Image = Resources.O;
                    pb5.Tag = "true";
                    if ((pb5.Tag.ToString() == "true") &&
                        (pb4.Tag.ToString() == "true") &&
                        (pb6.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb5.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb2.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb5.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb1.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb5.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb6.Image.ToString() == Resources.question_mark_96.ToString() && s == pb6)
                {
                    flag3 = true;
                    pb6.Image = Resources.O;
                    pb6.Tag = "true";
                    if ((pb9.Tag.ToString() == "true") &&
                        (pb6.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb6.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb6.Tag.ToString() == "true") &&
                        (pb4.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb6.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb7.Image.ToString() == Resources.question_mark_96.ToString() && s == pb7)
                {
                    flag3 = true;
                    pb7.Image = Resources.O;
                    pb7.Tag = "true";
                    if ((pb1.Tag.ToString() == "true") &&
                        (pb4.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        pb4.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb5.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb7.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    ;
                }
                else if (pb8.Image.ToString() == Resources.question_mark_96.ToString() && s == pb8)
                {
                    flag3 = true;
                    pb8.Image = Resources.O;
                    pb8.Tag = "true";
                    if ((pb9.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb8.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb5.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb2.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb8.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb2.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
                else if (pb9.Image.ToString() == Resources.question_mark_96.ToString() && s == pb9)
                {
                    flag3 = true;
                    pb9.Image = Resources.O;
                    pb9.Tag = "true";
                    if ((pb9.Tag.ToString() == "true") &&
                        (pb8.Tag.ToString() == "true") &&
                        (pb7.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb9.BackColor = Color.Yellow;
                        pb8.BackColor = Color.Yellow;
                        pb7.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb6.Tag.ToString() == "true") &&
                        (pb3.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb9.BackColor = Color.Yellow;
                        pb6.BackColor = Color.Yellow;
                        pb3.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else if ((pb9.Tag.ToString() == "true") &&
                        (pb1.Tag.ToString() == "true") &&
                        (pb5.Tag.ToString() == "true"))
                    {
                        flag2 = true;
                        pb1.BackColor = Color.Yellow;
                        pb5.BackColor = Color.Yellow;
                        pb9.BackColor = Color.Yellow;
                        MadeThePrize();
                    }
                    else
                    {
                        playerType = PlayerType.Player1;
                        lbPlayer.Text = "Player1";
                    }
                    
                }
            }
            if (!flag3 && !flag2 && !flag1 &&(((pb1.Tag.ToString() == "true")|| (pb1.Tag.ToString() == "truex"))&&
                ((pb2.Tag.ToString() == "true") || (pb2.Tag.ToString() == "truex"))&&
                ((pb3.Tag.ToString() == "true") || (pb3.Tag.ToString() == "truex"))&&
                ((pb4.Tag.ToString() == "true") || (pb4.Tag.ToString() == "truex"))&&
                ((pb5.Tag.ToString() == "true") || (pb5.Tag.ToString() == "truex")) &&
                ((pb6.Tag.ToString() == "true") || (pb6.Tag.ToString() == "truex")) &&
                ((pb7.Tag.ToString() == "true") || (pb7.Tag.ToString() == "truex")) &&
                ((pb8.Tag.ToString() == "true") || (pb8.Tag.ToString() == "truex")) &&
                ((pb9.Tag.ToString() == "true") || (pb9.Tag.ToString() == "truex"))))
            {
                MadeThePrize();
            }
        }
        */
        /*
        private void ChangeState(Object s) {
        
            PictureBox currentpb = (PictureBox)s;

            if (currentpb.Tag.ToString() != "false") {
                return;
            }

            flag1 = false;
            flag2 = false;

            if (playerType == PlayerType.Player1)
            {
                currentpb.Image = Resources.X;
                currentpb.Tag = "truex";
                playerType = PlayerType.Player2;
                lbPlayer.Text = "Player2";
            }
            else {
                currentpb.Image = Resources.O;
                currentpb.Tag = "true";
                playerType = PlayerType.Player1;
                lbPlayer.Text = "Player1";
            }

            DecideWhoWin(currentpb.Tag.ToString());

            if (!flag1 && !flag2 && SeeIfAllFill()) { 
                MadeThePrize();
            }

        }

        bool SeeIfAllFill() {
            PictureBox[] pbs = { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
            foreach (PictureBox pb in pbs) {
                if (pb.Tag.ToString() == "false") { 
                    return false;
                }
            }
            return true;
        }

        private void DecideWhoWin(string currentTag) {


            

            bool CheckMatch(PictureBox fpb, PictureBox spb , PictureBox tpb) {
                return (fpb.Tag.ToString() == currentTag &&
                        spb.Tag.ToString() == currentTag &&
                        tpb.Tag.ToString() == currentTag);
            }
            bool won = false;
            if (CheckMatch(pb1,pb2,pb3)) { pb1.BackColor = pb2.BackColor = pb3.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb4, pb5, pb6)) { pb4.BackColor = pb5.BackColor = pb6.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb7, pb8, pb9)) { pb7.BackColor = pb8.BackColor = pb9.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb1, pb4, pb7)) { pb1.BackColor = pb4.BackColor = pb7.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb2, pb5, pb8)) { pb2.BackColor = pb5.BackColor = pb8.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb3, pb6, pb9)) { pb3.BackColor = pb6.BackColor = pb9.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb1, pb5, pb9)) { pb1.BackColor = pb5.BackColor = pb9.BackColor = Color.Yellow; won = true; }
            else if (CheckMatch(pb3, pb5, pb7)) { pb3.BackColor = pb5.BackColor = pb7.BackColor = Color.Yellow; won = true; }

            if (won) {
                if (currentTag == "truex") { 
                    flag1 = true;
                }
                else
                {
                    flag2 = true;
                }
                MadeThePrize();
            }


        }
        */
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white, 15);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            float v1 = (pb1.Location.X + pb1.Width + pb2.Location.X) / 2.0f;
            float v2 = (pb2.Location.X + pb2.Width + pb3.Location.X) / 2.0f;
            float h1 = (pb1.Location.Y + pb1.Height + pb4.Location.Y) / 2.0f;
            float h2 = (pb4.Location.Y + pb4.Height + pb7.Location.Y) / 2.0f;
            float padding = 30.0f;
            float startX = pb1.Location.X - padding;
            float endX = pb3.Location.X + pb3.Width + padding;
            float startY = pb1.Location.Y - padding;
            float endY = pb7.Location.Y + pb7.Height + padding;

            e.Graphics.DrawLine(pen,v1,startY,v1,endY);
            e.Graphics.DrawLine(pen,v2,startY,v2,endY);
            e.Graphics.DrawLine(pen,startX,h1,endX,h1);
            e.Graphics.DrawLine(pen,startX,h2,endX,h2);

            //float[] pointsArr = new float[4];
            //for (int i = 1; i <= 4; i++)
            //{
            //    pointsArr = CalculateTheCordainates(pointsArr ,i);
            //    e.Graphics.DrawLine(pen, pointsArr[0], pointsArr[1], pointsArr[2], pointsArr[3]);
            //}


        }

        //private float[] CalculateTheCordainates(float[]arr ,int i) {
        //    switch (i){
        //        case 1:
        //            arr[0] = ((pb2.Location.X - (pb1.Location.X + pb1.Width)) / 2) + (pb1.Location.X + pb1.Width);
        //            arr[1] = pb2.Location.Y - 30;
        //            arr[2] = arr[0];
        //            arr[3] = pb7.Location.Y + pb7.Height + 30;
        //            break;
        //        case 2:
        //            arr[0] = ((pb3.Location.X - (pb2.Location.X + pb2.Width)) / 2) + (pb2.Location.X + pb2.Width);
        //            arr[1] = pb2.Location.Y  - 30;
        //            arr[2] = arr[0];
        //            arr[3] = pb7.Location.Y + pb7.Height + 30;
        //            break;
        //        case 3:
        //            arr[0] = pb1.Location.X - 30;
        //            arr[1] = ((pb4.Location.Y - (pb1.Location.Y + pb1.Height))/2) + (pb1.Location.Y + pb1.Height);
        //            arr[2] = pb3.Location.X + pb3.Width + 30;
        //            arr[3] = arr[1];
        //            break;
        //        case 4:
        //            arr[0] = pb1.Location.X - 30;
        //            arr[1] = ((pb7.Location.Y - (pb4.Location.Y + pb4.Height)) / 2) + (pb4.Location.Y + pb4.Height);
        //            arr[2] = pb3.Location.X + pb3.Width + 30;
        //            arr[3] = arr[1];
        //            break;


        //    }
        //    return arr;
        //}
        private void pb_Click(object sender, EventArgs e) {
            ChangeImage(sender);
        }


        //private void pb1_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb2_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb3_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);

        //}

        //private void pb4_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb5_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb6_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb7_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb8_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        //private void pb9_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(sender);
        //    //  ChangeState(sender);
        //}

        private void btnRestart_Click(object sender, EventArgs e)
        {
           // flag1 = false;
           // flag2 = false;
            playerType = PlayerType.Player1;
            lbPlayer.Text = "Player1";
            lbWinner.Text = "In Progress";
            gameInfo.winner = PlayerType.InProgress;
            gameInfo.gameOver = false;
            gameInfo.GameCount = 0;
            pb1.Image = Resources.question_mark_96;
            pb2.Image = Resources.question_mark_96;
            pb3.Image = Resources.question_mark_96;
            pb4.Image = Resources.question_mark_96;
            pb5.Image = Resources.question_mark_96;
            pb6.Image = Resources.question_mark_96;
            pb7.Image = Resources.question_mark_96;
            pb8.Image = Resources.question_mark_96;
            pb9.Image = Resources.question_mark_96;
            pb1.Tag = "false";
            pb2.Tag = "false";
            pb3.Tag = "false";
            pb4.Tag = "false";
            pb5.Tag = "false";
            pb6.Tag = "false";
            pb7.Tag = "false";
            pb8.Tag = "false";
            pb9.Tag = "false";
            pb1.BackColor = Color.Black;
            pb2.BackColor = Color.Black;
            pb3.BackColor = Color.Black;
            pb4.BackColor = Color.Black;
            pb5.BackColor = Color.Black;
            pb6.BackColor = Color.Black;
            pb7.BackColor = Color.Black;
            pb8.BackColor = Color.Black;
            pb9.BackColor = Color.Black;
            pb1.Enabled = pb2.Enabled = pb3.Enabled = pb4.Enabled = pb5.Enabled = pb6.Enabled = pb7.Enabled = pb8.Enabled = pb9.Enabled = true;
        }
    }
}

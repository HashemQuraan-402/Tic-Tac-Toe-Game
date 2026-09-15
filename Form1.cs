using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    internal struct GameInfo
    {
        public PlayerType Winner;
        public byte MoveCount;
        public bool GameOver;
    }

    internal enum PlayerType
    {
        Player1,
        Player2,
        Draw,
        InProgress
    }

    public partial class Form1 : Form
    {
        private PlayerType currentPlayer = PlayerType.Player1;
        private GameInfo gameInfo;

        public Form1()
        {
            InitializeComponent();
            gameInfo = new GameInfo
            {
                Winner = PlayerType.InProgress,
                MoveCount = 0,
                GameOver = false
            };
        }

        private void ChangeImage(object sender)
        {
            PictureBox currentCell = (PictureBox)sender;

            if (currentCell.Tag.ToString() != "false" || gameInfo.GameOver)
            {
                return;
            }

            if (currentPlayer == PlayerType.Player1)
            {
                currentCell.Image = Resources.X;
                currentCell.Tag = "x";
                currentPlayer = PlayerType.Player2;
                lbPlayer.Text = "Player2";
            }
            else
            {
                currentCell.Image = Resources.O;
                currentCell.Tag = "o";
                currentPlayer = PlayerType.Player1;
                lbPlayer.Text = "Player1";
            }

            gameInfo.MoveCount++;
            CheckWin();

            if (gameInfo.MoveCount == 9 && !gameInfo.GameOver)
            {
                gameInfo.GameOver = true;
                gameInfo.Winner = PlayerType.Draw;
                EndGame();
            }
        }

        private bool CheckMatch(PictureBox first, PictureBox second, PictureBox third)
        {
            string firstValue = first.Tag.ToString();

            if (firstValue == "false" ||
                firstValue != second.Tag.ToString() ||
                firstValue != third.Tag.ToString())
            {
                return false;
            }

            first.BackColor = Color.Yellow;
            second.BackColor = Color.Yellow;
            third.BackColor = Color.Yellow;

            gameInfo.Winner = firstValue == "x"
                ? PlayerType.Player1
                : PlayerType.Player2;
            gameInfo.GameOver = true;
            EndGame();
            return true;
        }

        private void CheckWin()
        {
            if (CheckMatch(pb1, pb2, pb3)) return;
            if (CheckMatch(pb4, pb5, pb6)) return;
            if (CheckMatch(pb7, pb8, pb9)) return;
            if (CheckMatch(pb1, pb4, pb7)) return;
            if (CheckMatch(pb2, pb5, pb8)) return;
            if (CheckMatch(pb3, pb6, pb9)) return;
            if (CheckMatch(pb1, pb5, pb9)) return;
            CheckMatch(pb3, pb5, pb7);
        }

        private void EndGame()
        {
            lbPlayer.Text = "Game Over";
            SetBoardEnabled(false);

            if (gameInfo.Winner == PlayerType.Player1)
            {
                lbWinner.Text = "Player1";
                MessageBox.Show("Player1 wins. Game over.", "Game Over");
            }
            else if (gameInfo.Winner == PlayerType.Player2)
            {
                lbWinner.Text = "Player2";
                MessageBox.Show("Player2 wins. Game over.", "Game Over");
            }
            else
            {
                lbWinner.Text = "Draw";
                MessageBox.Show("The game ended in a draw.", "Game Over");
            }
        }

        private PictureBox[] GetBoardCells()
        {
            return new[] { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
        }

        private void SetBoardEnabled(bool enabled)
        {
            foreach (PictureBox cell in GetBoardCells())
            {
                cell.Enabled = enabled;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 15))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                float firstVertical = (pb1.Location.X + pb1.Width + pb2.Location.X) / 2.0f;
                float secondVertical = (pb2.Location.X + pb2.Width + pb3.Location.X) / 2.0f;
                float firstHorizontal = (pb1.Location.Y + pb1.Height + pb4.Location.Y) / 2.0f;
                float secondHorizontal = (pb4.Location.Y + pb4.Height + pb7.Location.Y) / 2.0f;
                float padding = 30.0f;
                float startX = pb1.Location.X - padding;
                float endX = pb3.Location.X + pb3.Width + padding;
                float startY = pb1.Location.Y - padding;
                float endY = pb7.Location.Y + pb7.Height + padding;

                e.Graphics.DrawLine(pen, firstVertical, startY, firstVertical, endY);
                e.Graphics.DrawLine(pen, secondVertical, startY, secondVertical, endY);
                e.Graphics.DrawLine(pen, startX, firstHorizontal, endX, firstHorizontal);
                e.Graphics.DrawLine(pen, startX, secondHorizontal, endX, secondHorizontal);
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            ChangeImage(sender);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentPlayer = PlayerType.Player1;
            lbPlayer.Text = "Player1";
            lbWinner.Text = "In Progress";
            gameInfo.Winner = PlayerType.InProgress;
            gameInfo.GameOver = false;
            gameInfo.MoveCount = 0;

            foreach (PictureBox cell in GetBoardCells())
            {
                cell.Image = Resources.question_mark_96;
                cell.Tag = "false";
                cell.BackColor = Color.Black;
                cell.Enabled = true;
            }
        }
    }
}

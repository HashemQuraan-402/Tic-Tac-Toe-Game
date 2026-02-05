namespace Tic_Tac_Toe_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pictureBox2.Location = new System.Drawing.Point(154, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.O;
            this.pictureBox3.Location = new System.Drawing.Point(296, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 98);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(118, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turn";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.White;
            this.lbPlayer.Location = new System.Drawing.Point(90, 225);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(189, 75);
            this.lbPlayer.TabIndex = 5;
            this.lbPlayer.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(52, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 75);
            this.label4.TabIndex = 6;
            this.label4.Text = "The Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(-1, 377);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(370, 114);
            this.lbWinner.TabIndex = 7;
            this.lbWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(17, 492);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(334, 78);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(496, 175);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 98);
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            this.pb1.Tag = "false";
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(723, 175);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 98);
            this.pb2.TabIndex = 10;
            this.pb2.TabStop = false;
            this.pb2.Tag = "false";
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(950, 175);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 98);
            this.pb3.TabIndex = 11;
            this.pb3.TabStop = false;
            this.pb3.Tag = "false";
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(723, 340);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 98);
            this.pb5.TabIndex = 12;
            this.pb5.TabStop = false;
            this.pb5.Tag = "false";
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(496, 340);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 98);
            this.pb4.TabIndex = 13;
            this.pb4.TabStop = false;
            this.pb4.Tag = "false";
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(950, 340);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 98);
            this.pb6.TabIndex = 14;
            this.pb6.TabStop = false;
            this.pb6.Tag = "false";
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(950, 505);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(100, 98);
            this.pb9.TabIndex = 17;
            this.pb9.TabStop = false;
            this.pb9.Tag = "false";
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(496, 505);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(100, 98);
            this.pb7.TabIndex = 16;
            this.pb7.TabStop = false;
            this.pb7.Tag = "false";
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(723, 505);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(100, 98);
            this.pb8.TabIndex = 15;
            this.pb8.TabStop = false;
            this.pb8.Tag = "false";
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1131, 650);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
    }
}


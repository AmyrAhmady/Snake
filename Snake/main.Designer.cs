namespace Game
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeLengthLabel = new System.Windows.Forms.Label();
            this.resetBg = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.foodTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.BackColor = System.Drawing.Color.Black;
            this.EndGameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EndGameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameLabel.ForeColor = System.Drawing.Color.Gray;
            this.EndGameLabel.Location = new System.Drawing.Point(155, 235);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(248, 171);
            this.EndGameLabel.TabIndex = 2;
            this.EndGameLabel.Text = "You Lost!\r\n\r\nThe snake collided with itself\r\n\r\nClick to play again";
            this.EndGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EndGameLabel.Visible = false;
            this.EndGameLabel.Click += new System.EventHandler(this.EndGameLabel_Click);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Board.ForeColor = System.Drawing.Color.Red;
            this.Board.Location = new System.Drawing.Point(34, 112);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(485, 485);
            this.Board.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Snake Length:";
            // 
            // SnakeLengthLabel
            // 
            this.SnakeLengthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SnakeLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SnakeLengthLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeLengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.SnakeLengthLabel.Location = new System.Drawing.Point(153, 67);
            this.SnakeLengthLabel.Name = "SnakeLengthLabel";
            this.SnakeLengthLabel.Size = new System.Drawing.Size(59, 35);
            this.SnakeLengthLabel.TabIndex = 14;
            this.SnakeLengthLabel.Text = "1";
            this.SnakeLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBg
            // 
            this.resetBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.resetBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.resetBg.Location = new System.Drawing.Point(366, 65);
            this.resetBg.Name = "resetBg";
            this.resetBg.Size = new System.Drawing.Size(151, 39);
            this.resetBg.TabIndex = 30;
            this.resetBg.Text = "Restart";
            this.resetBg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.restartButton.Location = new System.Drawing.Point(367, 66);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(149, 37);
            this.restartButton.TabIndex = 31;
            this.restartButton.Text = "Restart";
            this.restartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(524, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Restart";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.closeButton.Location = new System.Drawing.Point(525, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // foodTimer
            // 
            this.foodTimer.Interval = 5000;
            this.foodTimer.Tick += new System.EventHandler(this.foodTimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(552, 624);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.resetBg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnakeLengthLabel);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.EndGameLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label EndGameLabel;
        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SnakeLengthLabel;
        private System.Windows.Forms.Label resetBg;
        private System.Windows.Forms.Label restartButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Timer foodTimer;
    }
}
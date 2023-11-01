namespace Tic_Tac_Toe_Game_WIn_Loss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Restart = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            ResetGame = new Button();
            PlayWithCPU = new Button();
            TwoPlayerGame = new Button();
            GameStarted = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(366, 51);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Player Wins: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(558, 51);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins: 0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(287, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 76);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(378, 98);
            button2.Name = "button2";
            button2.Size = new Size(75, 76);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(469, 98);
            button3.Name = "button3";
            button3.Size = new Size(75, 76);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(287, 180);
            button4.Name = "button4";
            button4.Size = new Size(75, 76);
            button4.TabIndex = 7;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(378, 180);
            button5.Name = "button5";
            button5.Size = new Size(75, 76);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(469, 180);
            button6.Name = "button6";
            button6.Size = new Size(75, 76);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(287, 262);
            button7.Name = "button7";
            button7.Size = new Size(75, 76);
            button7.TabIndex = 10;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(378, 262);
            button8.Name = "button8";
            button8.Size = new Size(75, 76);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(469, 262);
            button9.Name = "button9";
            button9.Size = new Size(75, 76);
            button9.TabIndex = 8;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // Restart
            // 
            Restart.BackColor = SystemColors.GradientInactiveCaption;
            Restart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Restart.ForeColor = Color.Black;
            Restart.Location = new Point(558, 109);
            Restart.Name = "Restart";
            Restart.Size = new Size(144, 42);
            Restart.TabIndex = 11;
            Restart.Text = "Restart Game";
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // ResetGame
            // 
            ResetGame.BackColor = SystemColors.GradientInactiveCaption;
            ResetGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetGame.ForeColor = Color.DarkSlateGray;
            ResetGame.Location = new Point(558, 180);
            ResetGame.Name = "ResetGame";
            ResetGame.Size = new Size(144, 52);
            ResetGame.TabIndex = 12;
            ResetGame.Text = "Reset Game";
            ResetGame.UseVisualStyleBackColor = false;
            ResetGame.Click += ResetGame_Click;
            // 
            // PlayWithCPU
            // 
            PlayWithCPU.BackColor = Color.ForestGreen;
            PlayWithCPU.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlayWithCPU.ForeColor = Color.Black;
            PlayWithCPU.Location = new Point(12, 109);
            PlayWithCPU.Name = "PlayWithCPU";
            PlayWithCPU.Size = new Size(170, 65);
            PlayWithCPU.TabIndex = 13;
            PlayWithCPU.Text = "PlayWithCPU";
            PlayWithCPU.UseVisualStyleBackColor = false;
            PlayWithCPU.Click += PlayWithCPU_Click;
            // 
            // TwoPlayerGame
            // 
            TwoPlayerGame.BackColor = SystemColors.GrayText;
            TwoPlayerGame.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TwoPlayerGame.ForeColor = Color.Black;
            TwoPlayerGame.Location = new Point(12, 239);
            TwoPlayerGame.Name = "TwoPlayerGame";
            TwoPlayerGame.Size = new Size(170, 95);
            TwoPlayerGame.TabIndex = 14;
            TwoPlayerGame.Text = "Two Player Game";
            TwoPlayerGame.UseVisualStyleBackColor = false;
            TwoPlayerGame.Click += TwoPlayerGame_Click;
            // 
            // GameStarted
            // 
            GameStarted.BackColor = SystemColors.Highlight;
            GameStarted.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            GameStarted.ForeColor = Color.Black;
            GameStarted.Location = new Point(276, 376);
            GameStarted.Name = "GameStarted";
            GameStarted.Size = new Size(278, 62);
            GameStarted.TabIndex = 15;
            GameStarted.Text = "Start Game";
            GameStarted.UseVisualStyleBackColor = false;
            GameStarted.Click += GameStarted_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GameStarted);
            Controls.Add(TwoPlayerGame);
            Controls.Add(PlayWithCPU);
            Controls.Add(ResetGame);
            Controls.Add(Restart);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.BurlyWood;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button Restart;
        private System.Windows.Forms.Timer CPUTimer;
        private Button ResetGame;
        private Button PlayWithCPU;
        private Button TwoPlayerGame;
        private Button StartGame;
        private Button GameStarted;
    }
}
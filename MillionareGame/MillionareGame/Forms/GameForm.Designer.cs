namespace MillionareGame.Forms
{
    partial class GameForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.buttonAnswerA = new System.Windows.Forms.Button();
            this.buttonAnswerB = new System.Windows.Forms.Button();
            this.buttonAnswerC = new System.Windows.Forms.Button();
            this.buttonAnswerD = new System.Windows.Forms.Button();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.manButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.fiftyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoEllipsis = true;
            this.questionLabel.BackColor = System.Drawing.Color.Black;
            this.questionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.questionLabel.Location = new System.Drawing.Point(12, 70);
            this.questionLabel.MaximumSize = new System.Drawing.Size(1400, 492);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionLabel.Size = new System.Drawing.Size(1251, 174);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // buttonAnswerA
            // 
            this.buttonAnswerA.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerA.Location = new System.Drawing.Point(141, 325);
            this.buttonAnswerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswerA.Name = "buttonAnswerA";
            this.buttonAnswerA.Size = new System.Drawing.Size(451, 65);
            this.buttonAnswerA.TabIndex = 2;
            this.buttonAnswerA.Text = "A";
            this.buttonAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerA.UseVisualStyleBackColor = true;
            this.buttonAnswerA.Click += new System.EventHandler(this.buttonAnswerA_Click);
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerB.Location = new System.Drawing.Point(685, 325);
            this.buttonAnswerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(451, 65);
            this.buttonAnswerB.TabIndex = 3;
            this.buttonAnswerB.Text = "B";
            this.buttonAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerB.UseVisualStyleBackColor = true;
            this.buttonAnswerB.Click += new System.EventHandler(this.buttonAnswerB_Click);
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerC.Location = new System.Drawing.Point(141, 430);
            this.buttonAnswerC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(451, 65);
            this.buttonAnswerC.TabIndex = 4;
            this.buttonAnswerC.Text = "C";
            this.buttonAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerC.UseVisualStyleBackColor = true;
            this.buttonAnswerC.Click += new System.EventHandler(this.buttonAnswerC_Click);
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswerD.Location = new System.Drawing.Point(685, 430);
            this.buttonAnswerD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(451, 65);
            this.buttonAnswerD.TabIndex = 5;
            this.buttonAnswerD.Text = "D";
            this.buttonAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswerD.UseVisualStyleBackColor = true;
            this.buttonAnswerD.Click += new System.EventHandler(this.buttonAnswerD_Click);
            // 
            // winningsLabel
            // 
            this.winningsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winningsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winningsLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.winningsLabel.Location = new System.Drawing.Point(135, 620);
            this.winningsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(457, 38);
            this.winningsLabel.TabIndex = 6;
            this.winningsLabel.Text = "Выигрыш";
            this.winningsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoEllipsis = true;
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.MaximumSize = new System.Drawing.Size(900, 492);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerLabel.Size = new System.Drawing.Size(88, 38);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "Timer";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manButton
            // 
            this.manButton.AutoSize = true;
            this.manButton.BackColor = System.Drawing.Color.White;
            this.manButton.Image = global::MillionareGame.Properties.Resources.man;
            this.manButton.Location = new System.Drawing.Point(723, 597);
            this.manButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(101, 90);
            this.manButton.TabIndex = 9;
            this.manButton.UseVisualStyleBackColor = false;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // callButton
            // 
            this.callButton.AutoSize = true;
            this.callButton.BackColor = System.Drawing.Color.White;
            this.callButton.Image = global::MillionareGame.Properties.Resources.call;
            this.callButton.Location = new System.Drawing.Point(880, 597);
            this.callButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(101, 90);
            this.callButton.TabIndex = 10;
            this.callButton.UseVisualStyleBackColor = false;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // fiftyButton
            // 
            this.fiftyButton.AutoSize = true;
            this.fiftyButton.BackColor = System.Drawing.Color.White;
            this.fiftyButton.Image = global::MillionareGame.Properties.Resources.fifty;
            this.fiftyButton.Location = new System.Drawing.Point(1027, 597);
            this.fiftyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fiftyButton.Name = "fiftyButton";
            this.fiftyButton.Size = new System.Drawing.Size(101, 94);
            this.fiftyButton.TabIndex = 11;
            this.fiftyButton.UseVisualStyleBackColor = false;
            this.fiftyButton.Click += new System.EventHandler(this.fiftyButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MillionareGame.Properties.Resources.LHc0RaYGI3U1;
            this.ClientSize = new System.Drawing.Size(1275, 720);
            this.Controls.Add(this.fiftyButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.buttonAnswerD);
            this.Controls.Add(this.buttonAnswerC);
            this.Controls.Add(this.buttonAnswerB);
            this.Controls.Add(this.buttonAnswerA);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button buttonAnswerA;
        private System.Windows.Forms.Button buttonAnswerB;
        private System.Windows.Forms.Button buttonAnswerC;
        private System.Windows.Forms.Button buttonAnswerD;
        private System.Windows.Forms.Label winningsLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button fiftyButton;
    }
}
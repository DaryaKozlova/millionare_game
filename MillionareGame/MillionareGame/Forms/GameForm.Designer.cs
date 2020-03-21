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
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(543, 216);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(65, 17);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Question";
            // 
            // buttonAnswerA
            // 
            this.buttonAnswerA.Location = new System.Drawing.Point(137, 341);
            this.buttonAnswerA.Name = "buttonAnswerA";
            this.buttonAnswerA.Size = new System.Drawing.Size(319, 65);
            this.buttonAnswerA.TabIndex = 2;
            this.buttonAnswerA.Text = "A";
            this.buttonAnswerA.UseVisualStyleBackColor = true;
            this.buttonAnswerA.Click += new System.EventHandler(this.buttonAnswerA_Click);
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.Location = new System.Drawing.Point(709, 341);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(319, 65);
            this.buttonAnswerB.TabIndex = 3;
            this.buttonAnswerB.Text = "B";
            this.buttonAnswerB.UseVisualStyleBackColor = true;
            this.buttonAnswerB.Click += new System.EventHandler(this.buttonAnswerB_Click);
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.Location = new System.Drawing.Point(137, 503);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(319, 65);
            this.buttonAnswerC.TabIndex = 4;
            this.buttonAnswerC.Text = "C";
            this.buttonAnswerC.UseVisualStyleBackColor = true;
            this.buttonAnswerC.Click += new System.EventHandler(this.buttonAnswerC_Click);
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.Location = new System.Drawing.Point(709, 503);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(319, 65);
            this.buttonAnswerD.TabIndex = 5;
            this.buttonAnswerD.Text = "D";
            this.buttonAnswerD.UseVisualStyleBackColor = true;
            this.buttonAnswerD.Click += new System.EventHandler(this.buttonAnswerD_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 720);
            this.Controls.Add(this.buttonAnswerD);
            this.Controls.Add(this.buttonAnswerC);
            this.Controls.Add(this.buttonAnswerB);
            this.Controls.Add(this.buttonAnswerA);
            this.Controls.Add(this.questionLabel);
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
    }
}
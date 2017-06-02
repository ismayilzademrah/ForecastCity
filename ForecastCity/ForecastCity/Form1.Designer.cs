namespace ForecastCity
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
            this.questArea = new System.Windows.Forms.GroupBox();
            this.ansArea = new System.Windows.Forms.GroupBox();
            this.lblEnteredLtr = new System.Windows.Forms.Label();
            this.lblChance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnEnterLtr = new System.Windows.Forms.Button();
            this.txtLtr = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.ansArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // questArea
            // 
            this.questArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questArea.Location = new System.Drawing.Point(28, 41);
            this.questArea.Name = "questArea";
            this.questArea.Size = new System.Drawing.Size(481, 137);
            this.questArea.TabIndex = 0;
            this.questArea.TabStop = false;
            this.questArea.Text = "questionArea";
            // 
            // ansArea
            // 
            this.ansArea.Controls.Add(this.lblEnteredLtr);
            this.ansArea.Controls.Add(this.lblChance);
            this.ansArea.Controls.Add(this.label2);
            this.ansArea.Controls.Add(this.label1);
            this.ansArea.Controls.Add(this.btnGuess);
            this.ansArea.Controls.Add(this.txtGuess);
            this.ansArea.Controls.Add(this.btnEnterLtr);
            this.ansArea.Controls.Add(this.txtLtr);
            this.ansArea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansArea.Location = new System.Drawing.Point(28, 184);
            this.ansArea.Name = "ansArea";
            this.ansArea.Size = new System.Drawing.Size(481, 140);
            this.ansArea.TabIndex = 1;
            this.ansArea.TabStop = false;
            this.ansArea.Text = "answerArea";
            // 
            // lblEnteredLtr
            // 
            this.lblEnteredLtr.AutoSize = true;
            this.lblEnteredLtr.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnteredLtr.Location = new System.Drawing.Point(146, 62);
            this.lblEnteredLtr.Name = "lblEnteredLtr";
            this.lblEnteredLtr.Size = new System.Drawing.Size(28, 17);
            this.lblEnteredLtr.TabIndex = 4;
            this.lblEnteredLtr.Text = "    ";
            // 
            // lblChance
            // 
            this.lblChance.AutoSize = true;
            this.lblChance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChance.Location = new System.Drawing.Point(80, 96);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(15, 14);
            this.lblChance.TabIndex = 3;
            this.lblChance.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entered Letters:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(376, 16);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(270, 17);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 0;
            // 
            // btnEnterLtr
            // 
            this.btnEnterLtr.Location = new System.Drawing.Point(134, 18);
            this.btnEnterLtr.Name = "btnEnterLtr";
            this.btnEnterLtr.Size = new System.Drawing.Size(75, 23);
            this.btnEnterLtr.TabIndex = 1;
            this.btnEnterLtr.Text = "Enter Letter";
            this.btnEnterLtr.UseVisualStyleBackColor = true;
            this.btnEnterLtr.Click += new System.EventHandler(this.btnEnterLtr_Click);
            // 
            // txtLtr
            // 
            this.txtLtr.Location = new System.Drawing.Point(28, 19);
            this.txtLtr.Name = "txtLtr";
            this.txtLtr.Size = new System.Drawing.Size(100, 22);
            this.txtLtr.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.Location = new System.Drawing.Point(28, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(481, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(539, 336);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.ansArea);
            this.Controls.Add(this.questArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ansArea.ResumeLayout(false);
            this.ansArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questArea;
        private System.Windows.Forms.GroupBox ansArea;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnEnterLtr;
        private System.Windows.Forms.TextBox txtLtr;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnteredLtr;
    }
}


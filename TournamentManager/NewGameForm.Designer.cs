namespace TournamentManager.Services
{
    partial class NewGameForm
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
            this.comboWhite = new System.Windows.Forms.ComboBox();
            this.comboBlack = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioResultWhite = new System.Windows.Forms.RadioButton();
            this.radioResultDraw = new System.Windows.Forms.RadioButton();
            this.radioResultBlack = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTournament = new System.Windows.Forms.ComboBox();
            this.textBoxMoves = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTimeControl = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "White:";
            // 
            // comboWhite
            // 
            this.comboWhite.FormattingEnabled = true;
            this.comboWhite.Location = new System.Drawing.Point(66, 6);
            this.comboWhite.Name = "comboWhite";
            this.comboWhite.Size = new System.Drawing.Size(121, 24);
            this.comboWhite.TabIndex = 1;
            // 
            // comboBlack
            // 
            this.comboBlack.FormattingEnabled = true;
            this.comboBlack.Location = new System.Drawing.Point(241, 6);
            this.comboBlack.Name = "comboBlack";
            this.comboBlack.Size = new System.Drawing.Size(121, 24);
            this.comboBlack.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Black:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // radioResultWhite
            // 
            this.radioResultWhite.AutoSize = true;
            this.radioResultWhite.Location = new System.Drawing.Point(70, 44);
            this.radioResultWhite.Name = "radioResultWhite";
            this.radioResultWhite.Size = new System.Drawing.Size(49, 21);
            this.radioResultWhite.TabIndex = 5;
            this.radioResultWhite.TabStop = true;
            this.radioResultWhite.Text = "1:0";
            this.radioResultWhite.UseVisualStyleBackColor = true;
            // 
            // radioResultDraw
            // 
            this.radioResultDraw.AutoSize = true;
            this.radioResultDraw.Location = new System.Drawing.Point(125, 44);
            this.radioResultDraw.Name = "radioResultDraw";
            this.radioResultDraw.Size = new System.Drawing.Size(73, 21);
            this.radioResultDraw.TabIndex = 6;
            this.radioResultDraw.TabStop = true;
            this.radioResultDraw.Text = "1/2:1/2";
            this.radioResultDraw.UseVisualStyleBackColor = true;
            // 
            // radioResultBlack
            // 
            this.radioResultBlack.AutoSize = true;
            this.radioResultBlack.Location = new System.Drawing.Point(204, 44);
            this.radioResultBlack.Name = "radioResultBlack";
            this.radioResultBlack.Size = new System.Drawing.Size(49, 21);
            this.radioResultBlack.TabIndex = 7;
            this.radioResultBlack.TabStop = true;
            this.radioResultBlack.Text = "0:1";
            this.radioResultBlack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tournament:";
            // 
            // comboTournament
            // 
            this.comboTournament.FormattingEnabled = true;
            this.comboTournament.Location = new System.Drawing.Point(463, 6);
            this.comboTournament.Name = "comboTournament";
            this.comboTournament.Size = new System.Drawing.Size(121, 24);
            this.comboTournament.TabIndex = 9;
            // 
            // textBoxMoves
            // 
            this.textBoxMoves.Location = new System.Drawing.Point(15, 110);
            this.textBoxMoves.Multiline = true;
            this.textBoxMoves.Name = "textBoxMoves";
            this.textBoxMoves.Size = new System.Drawing.Size(569, 438);
            this.textBoxMoves.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moves:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time Control:";
            // 
            // comboTimeControl
            // 
            this.comboTimeControl.FormattingEnabled = true;
            this.comboTimeControl.Location = new System.Drawing.Point(463, 43);
            this.comboTimeControl.Name = "comboTimeControl";
            this.comboTimeControl.Size = new System.Drawing.Size(121, 24);
            this.comboTimeControl.TabIndex = 13;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(509, 554);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 33);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 595);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboTimeControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMoves);
            this.Controls.Add(this.comboTournament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioResultBlack);
            this.Controls.Add(this.radioResultDraw);
            this.Controls.Add(this.radioResultWhite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBlack);
            this.Controls.Add(this.comboWhite);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGameForm";
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboWhite;
        private System.Windows.Forms.ComboBox comboBlack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioResultWhite;
        private System.Windows.Forms.RadioButton radioResultDraw;
        private System.Windows.Forms.RadioButton radioResultBlack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTournament;
        private System.Windows.Forms.TextBox textBoxMoves;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTimeControl;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
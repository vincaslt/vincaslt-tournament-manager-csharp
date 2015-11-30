namespace TournamentManager.Forms
{
    partial class WizardForm
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOpen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkedListBoxTime = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAge = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(292, 327);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 34);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.label4);
            this.groupBoxCreate.Controls.Add(this.label3);
            this.groupBoxCreate.Controls.Add(this.checkedListBoxAge);
            this.groupBoxCreate.Controls.Add(this.checkedListBoxTime);
            this.groupBoxCreate.Controls.Add(this.textBoxName);
            this.groupBoxCreate.Controls.Add(this.label2);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(355, 269);
            this.groupBoxCreate.TabIndex = 1;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create new tournament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Or open existing:";
            // 
            // comboBoxOpen
            // 
            this.comboBoxOpen.FormattingEnabled = true;
            this.comboBoxOpen.Location = new System.Drawing.Point(133, 287);
            this.comboBoxOpen.Name = "comboBoxOpen";
            this.comboBoxOpen.Size = new System.Drawing.Size(234, 24);
            this.comboBoxOpen.TabIndex = 3;
            this.comboBoxOpen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // checkedListBoxTime
            // 
            this.checkedListBoxTime.FormattingEnabled = true;
            this.checkedListBoxTime.Location = new System.Drawing.Point(152, 74);
            this.checkedListBoxTime.Name = "checkedListBoxTime";
            this.checkedListBoxTime.Size = new System.Drawing.Size(197, 72);
            this.checkedListBoxTime.TabIndex = 2;
            // 
            // checkedListBoxAge
            // 
            this.checkedListBoxAge.FormattingEnabled = true;
            this.checkedListBoxAge.Location = new System.Drawing.Point(152, 164);
            this.checkedListBoxAge.Name = "checkedListBoxAge";
            this.checkedListBoxAge.Size = new System.Drawing.Size(197, 72);
            this.checkedListBoxAge.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Controls:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age groups:";
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 373);
            this.Controls.Add(this.comboBoxOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WizardForm";
            this.Text = "Tournament Wizard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WizardForm_Closed);
            this.Load += new System.EventHandler(this.WizardForm_Load);
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxAge;
        private System.Windows.Forms.CheckedListBox checkedListBoxTime;
    }
}
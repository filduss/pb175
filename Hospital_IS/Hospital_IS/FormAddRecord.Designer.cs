namespace WindowsFormsApp1
{
    partial class FormAddRecord
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxExaminations = new System.Windows.Forms.ComboBox();
            this.labelExaminationType = new System.Windows.Forms.Label();
            this.comboBoxPacient = new System.Windows.Forms.ComboBox();
            this.labelPacient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(644, 7);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // comboBoxExaminations
            // 
            this.comboBoxExaminations.FormattingEnabled = true;
            this.comboBoxExaminations.Location = new System.Drawing.Point(16, 29);
            this.comboBoxExaminations.Name = "comboBoxExaminations";
            this.comboBoxExaminations.Size = new System.Drawing.Size(243, 21);
            this.comboBoxExaminations.TabIndex = 1;
            // 
            // labelExaminationType
            // 
            this.labelExaminationType.AutoSize = true;
            this.labelExaminationType.Location = new System.Drawing.Point(13, 13);
            this.labelExaminationType.Name = "labelExaminationType";
            this.labelExaminationType.Size = new System.Drawing.Size(94, 13);
            this.labelExaminationType.TabIndex = 2;
            this.labelExaminationType.Text = "Vyberte vyšetření:";
            // 
            // comboBoxPacient
            // 
            this.comboBoxPacient.FormattingEnabled = true;
            this.comboBoxPacient.Location = new System.Drawing.Point(16, 80);
            this.comboBoxPacient.Name = "comboBoxPacient";
            this.comboBoxPacient.Size = new System.Drawing.Size(243, 21);
            this.comboBoxPacient.TabIndex = 3;
            // 
            // labelPacient
            // 
            this.labelPacient.AutoSize = true;
            this.labelPacient.Location = new System.Drawing.Point(13, 64);
            this.labelPacient.Name = "labelPacient";
            this.labelPacient.Size = new System.Drawing.Size(90, 13);
            this.labelPacient.TabIndex = 4;
            this.labelPacient.Text = "Vyberte pacienta:";
            // 
            // FormAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPacient);
            this.Controls.Add(this.comboBoxPacient);
            this.Controls.Add(this.labelExaminationType);
            this.Controls.Add(this.comboBoxExaminations);
            this.Controls.Add(this.monthCalendar);
            this.Name = "FormAddRecord";
            this.Text = "FormAddRecord";
            this.Load += new System.EventHandler(this.FormAddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxExaminations;
        private System.Windows.Forms.Label labelExaminationType;
        private System.Windows.Forms.ComboBox comboBoxPacient;
        private System.Windows.Forms.Label labelPacient;
    }
}
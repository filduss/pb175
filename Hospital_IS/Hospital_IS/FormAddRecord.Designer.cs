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
            this.labelPacientChose = new System.Windows.Forms.Label();
            this.labelPacient = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(314, 61);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // comboBoxExaminations
            // 
            this.comboBoxExaminations.FormattingEnabled = true;
            this.comboBoxExaminations.Location = new System.Drawing.Point(16, 61);
            this.comboBoxExaminations.Name = "comboBoxExaminations";
            this.comboBoxExaminations.Size = new System.Drawing.Size(286, 21);
            this.comboBoxExaminations.TabIndex = 1;
            // 
            // labelExaminationType
            // 
            this.labelExaminationType.AutoSize = true;
            this.labelExaminationType.Location = new System.Drawing.Point(13, 45);
            this.labelExaminationType.Name = "labelExaminationType";
            this.labelExaminationType.Size = new System.Drawing.Size(94, 13);
            this.labelExaminationType.TabIndex = 2;
            this.labelExaminationType.Text = "Vyberte vyšetření:";
            // 
            // labelPacientChose
            // 
            this.labelPacientChose.AutoSize = true;
            this.labelPacientChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPacientChose.Location = new System.Drawing.Point(12, 9);
            this.labelPacientChose.Name = "labelPacientChose";
            this.labelPacientChose.Size = new System.Drawing.Size(75, 22);
            this.labelPacientChose.TabIndex = 4;
            this.labelPacientChose.Text = "Pacient:";
            // 
            // labelPacient
            // 
            this.labelPacient.AutoSize = true;
            this.labelPacient.Location = new System.Drawing.Point(94, 17);
            this.labelPacient.Name = "labelPacient";
            this.labelPacient.Size = new System.Drawing.Size(0, 13);
            this.labelPacient.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(16, 109);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(286, 114);
            this.textBoxDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 93);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(117, 13);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Poznámka k vyšetření:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(16, 229);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(286, 39);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Přidat";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 432);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelPacient);
            this.Controls.Add(this.labelPacientChose);
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
        private System.Windows.Forms.Label labelPacientChose;
        private System.Windows.Forms.Label labelPacient;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
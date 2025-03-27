namespace WindowsFormsApp1
{
    partial class FormDoctor
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
            this.listBoxPacients = new System.Windows.Forms.ListBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonViewCard = new System.Windows.Forms.Button();
            this.labelDoctorText = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.buttonCreateAppointment = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.labelChosenPatient = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.monthCalendarExamDate = new System.Windows.Forms.MonthCalendar();
            this.labelChoosePatient = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTimePicker = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelCreate.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPacients
            // 
            this.listBoxPacients.FormattingEnabled = true;
            this.listBoxPacients.Location = new System.Drawing.Point(12, 83);
            this.listBoxPacients.Name = "listBoxPacients";
            this.listBoxPacients.Size = new System.Drawing.Size(158, 355);
            this.listBoxPacients.TabIndex = 0;
            this.listBoxPacients.SelectedIndexChanged += new System.EventHandler(this.listBoxPacients_SelectedIndexChanged);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(176, 390);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(126, 48);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "Přidat záznam";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonViewCard
            // 
            this.buttonViewCard.Location = new System.Drawing.Point(176, 336);
            this.buttonViewCard.Name = "buttonViewCard";
            this.buttonViewCard.Size = new System.Drawing.Size(126, 48);
            this.buttonViewCard.TabIndex = 2;
            this.buttonViewCard.Text = "Zobrazit kartu";
            this.buttonViewCard.UseVisualStyleBackColor = true;
            this.buttonViewCard.Click += new System.EventHandler(this.buttonViewCard_Click);
            // 
            // labelDoctorText
            // 
            this.labelDoctorText.AutoSize = true;
            this.labelDoctorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoctorText.Location = new System.Drawing.Point(13, 13);
            this.labelDoctorText.Name = "labelDoctorText";
            this.labelDoctorText.Size = new System.Drawing.Size(128, 22);
            this.labelDoctorText.TabIndex = 3;
            this.labelDoctorText.Text = "Přihlášen jako:";
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoctor.Location = new System.Drawing.Point(147, 16);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(0, 17);
            this.labelDoctor.TabIndex = 4;
            // 
            // buttonCreateAppointment
            // 
            this.buttonCreateAppointment.Location = new System.Drawing.Point(176, 283);
            this.buttonCreateAppointment.Name = "buttonCreateAppointment";
            this.buttonCreateAppointment.Size = new System.Drawing.Size(126, 47);
            this.buttonCreateAppointment.TabIndex = 7;
            this.buttonCreateAppointment.Text = "Vytvořit Schůzku";
            this.buttonCreateAppointment.UseVisualStyleBackColor = true;
            this.buttonCreateAppointment.Click += new System.EventHandler(this.buttonCreateAppointment_Click);
            // 
            // panelCreate
            // 
            this.panelCreate.Controls.Add(this.labelTime);
            this.panelCreate.Controls.Add(this.comboBoxTimePicker);
            this.panelCreate.Controls.Add(this.labelChosenPatient);
            this.panelCreate.Controls.Add(this.buttonSend);
            this.panelCreate.Controls.Add(this.comboBoxType);
            this.panelCreate.Controls.Add(this.labelType);
            this.panelCreate.Controls.Add(this.monthCalendarExamDate);
            this.panelCreate.Controls.Add(this.labelChoosePatient);
            this.panelCreate.Location = new System.Drawing.Point(344, 16);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(444, 277);
            this.panelCreate.TabIndex = 8;
            // 
            // labelChosenPatient
            // 
            this.labelChosenPatient.AutoSize = true;
            this.labelChosenPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChosenPatient.Location = new System.Drawing.Point(12, 45);
            this.labelChosenPatient.Name = "labelChosenPatient";
            this.labelChosenPatient.Size = new System.Drawing.Size(79, 25);
            this.labelChosenPatient.TabIndex = 6;
            this.labelChosenPatient.Text = "ŽÁDNÝ";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(107, 130);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(124, 41);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Odeslat";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(14, 99);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(217, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(14, 79);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(122, 17);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Vyberte vyšetření:";
            // 
            // monthCalendarExamDate
            // 
            this.monthCalendarExamDate.Location = new System.Drawing.Point(243, 9);
            this.monthCalendarExamDate.MaxSelectionCount = 1;
            this.monthCalendarExamDate.Name = "monthCalendarExamDate";
            this.monthCalendarExamDate.TabIndex = 2;
            // 
            // labelChoosePatient
            // 
            this.labelChoosePatient.AutoSize = true;
            this.labelChoosePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoosePatient.Location = new System.Drawing.Point(14, 18);
            this.labelChoosePatient.Name = "labelChoosePatient";
            this.labelChoosePatient.Size = new System.Drawing.Size(114, 17);
            this.labelChoosePatient.TabIndex = 1;
            this.labelChoosePatient.Text = "Vybraný pacient:";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDisplay.Controls.Add(this.label1);
            this.panelDisplay.Location = new System.Drawing.Point(344, 312);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(444, 422);
            this.panelDisplay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIS LABEL IS IN SHOW SECTION";
            // 
            // comboBoxTimePicker
            // 
            this.comboBoxTimePicker.FormattingEnabled = true;
            this.comboBoxTimePicker.Location = new System.Drawing.Point(17, 146);
            this.comboBoxTimePicker.Name = "comboBoxTimePicker";
            this.comboBoxTimePicker.Size = new System.Drawing.Size(84, 21);
            this.comboBoxTimePicker.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(14, 126);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(87, 17);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Vyberte čas:";
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.buttonCreateAppointment);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelDoctorText);
            this.Controls.Add(this.buttonViewCard);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.listBoxPacients);
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPacients;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonViewCard;
        private System.Windows.Forms.Label labelDoctorText;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Button buttonCreateAppointment;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.MonthCalendar monthCalendarExamDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChoosePatient;
        private System.Windows.Forms.Label labelChosenPatient;
        private System.Windows.Forms.ComboBox comboBoxTimePicker;
        private System.Windows.Forms.Label labelTime;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            this.listBoxPacients = new System.Windows.Forms.ListBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonViewCard = new System.Windows.Forms.Button();
            this.labelDoctorText = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.buttonCreateAppointment = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxTimePicker = new System.Windows.Forms.ComboBox();
            this.labelChosenPatient = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.monthCalendarExamDate = new System.Windows.Forms.MonthCalendar();
            this.labelChoosePatient = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.panelToday1 = new System.Windows.Forms.Panel();
            this.labelAppLeft1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelToday1Next = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxToday1Type = new System.Windows.Forms.CheckBox();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.panelToday2 = new System.Windows.Forms.Panel();
            this.labelAppLeft2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelToday2Next = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxToday2Type = new System.Windows.Forms.CheckBox();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.panelToday3 = new System.Windows.Forms.Panel();
            this.labelAppLeft3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelToday3Next = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxToday3Type = new System.Windows.Forms.CheckBox();
            this.labelDate3 = new System.Windows.Forms.Label();
            this.panelToday4 = new System.Windows.Forms.Panel();
            this.labelAppLeft4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panelToday4Next = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBoxToday4Type = new System.Windows.Forms.CheckBox();
            this.labelDate4 = new System.Windows.Forms.Label();
            this.panelToday5 = new System.Windows.Forms.Panel();
            this.labelAppLeft5 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panelToday5Next = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.checkBoxToday5Type = new System.Windows.Forms.CheckBox();
            this.labelDate5 = new System.Windows.Forms.Label();
            this.panelCreate.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.panelToday1.SuspendLayout();
            this.panelToday1Next.SuspendLayout();
            this.panelToday2.SuspendLayout();
            this.panelToday2Next.SuspendLayout();
            this.panelToday3.SuspendLayout();
            this.panelToday3Next.SuspendLayout();
            this.panelToday4.SuspendLayout();
            this.panelToday4Next.SuspendLayout();
            this.panelToday5.SuspendLayout();
            this.panelToday5Next.SuspendLayout();
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
            this.panelCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panelCreate.Size = new System.Drawing.Size(505, 210);
            this.panelCreate.TabIndex = 8;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(30, 135);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(87, 17);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Vyberte čas:";
            // 
            // comboBoxTimePicker
            // 
            this.comboBoxTimePicker.FormattingEnabled = true;
            this.comboBoxTimePicker.Location = new System.Drawing.Point(33, 159);
            this.comboBoxTimePicker.Name = "comboBoxTimePicker";
            this.comboBoxTimePicker.Size = new System.Drawing.Size(84, 21);
            this.comboBoxTimePicker.TabIndex = 7;
            // 
            // labelChosenPatient
            // 
            this.labelChosenPatient.AutoSize = true;
            this.labelChosenPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChosenPatient.Location = new System.Drawing.Point(31, 47);
            this.labelChosenPatient.Name = "labelChosenPatient";
            this.labelChosenPatient.Size = new System.Drawing.Size(79, 25);
            this.labelChosenPatient.TabIndex = 6;
            this.labelChosenPatient.Text = "ŽÁDNÝ";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(124, 135);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(124, 45);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Odeslat";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(33, 101);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(217, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(33, 81);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(122, 17);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Vyberte vyšetření:";
            // 
            // monthCalendarExamDate
            // 
            this.monthCalendarExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarExamDate.Location = new System.Drawing.Point(262, 18);
            this.monthCalendarExamDate.MaxSelectionCount = 1;
            this.monthCalendarExamDate.Name = "monthCalendarExamDate";
            this.monthCalendarExamDate.TabIndex = 2;
            // 
            // labelChoosePatient
            // 
            this.labelChoosePatient.AutoSize = true;
            this.labelChoosePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChoosePatient.Location = new System.Drawing.Point(33, 20);
            this.labelChoosePatient.Name = "labelChoosePatient";
            this.labelChoosePatient.Size = new System.Drawing.Size(114, 17);
            this.labelChoosePatient.TabIndex = 1;
            this.labelChoosePatient.Text = "Vybraný pacient:";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.panelDisplay.Controls.Add(this.panelToday1);
            this.panelDisplay.Controls.Add(this.panelToday2);
            this.panelDisplay.Controls.Add(this.panelToday3);
            this.panelDisplay.Controls.Add(this.panelToday4);
            this.panelDisplay.Controls.Add(this.panelToday5);
            this.panelDisplay.Location = new System.Drawing.Point(344, 3);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(505, 436);
            this.panelDisplay.TabIndex = 9;
            // 
            // panelToday1
            // 
            this.panelToday1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday1.Controls.Add(this.labelAppLeft1);
            this.panelToday1.Controls.Add(this.label6);
            this.panelToday1.Controls.Add(this.panelToday1Next);
            this.panelToday1.Controls.Add(this.labelDate1);
            this.panelToday1.Location = new System.Drawing.Point(2, 2);
            this.panelToday1.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday1.Name = "panelToday1";
            this.panelToday1.Size = new System.Drawing.Size(500, 84);
            this.panelToday1.TabIndex = 0;
            // 
            // labelAppLeft1
            // 
            this.labelAppLeft1.AutoSize = true;
            this.labelAppLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppLeft1.Location = new System.Drawing.Point(-4, 37);
            this.labelAppLeft1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLeft1.Name = "labelAppLeft1";
            this.labelAppLeft1.Size = new System.Drawing.Size(36, 39);
            this.labelAppLeft1.TabIndex = 15;
            this.labelAppLeft1.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(0, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zbývající schůzky";
            // 
            // panelToday1Next
            // 
            this.panelToday1Next.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelToday1Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday1Next.Controls.Add(this.label3);
            this.panelToday1Next.Controls.Add(this.label2);
            this.panelToday1Next.Controls.Add(this.checkBoxToday1Type);
            this.panelToday1Next.Location = new System.Drawing.Point(102, 9);
            this.panelToday1Next.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday1Next.Name = "panelToday1Next";
            this.panelToday1Next.Size = new System.Drawing.Size(382, 61);
            this.panelToday1Next.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            this.label3.Tag = "TodayName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-1, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            this.label2.Tag = "TodayTime";
            // 
            // checkBoxToday1Type
            // 
            this.checkBoxToday1Type.AutoSize = true;
            this.checkBoxToday1Type.Location = new System.Drawing.Point(2, 6);
            this.checkBoxToday1Type.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxToday1Type.Name = "checkBoxToday1Type";
            this.checkBoxToday1Type.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToday1Type.TabIndex = 0;
            this.checkBoxToday1Type.Tag = "Today1";
            this.checkBoxToday1Type.UseVisualStyleBackColor = true;
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate1.Location = new System.Drawing.Point(-2, 4);
            this.labelDate1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(90, 22);
            this.labelDate1.TabIndex = 0;
            this.labelDate1.Text = "28.3.2025";
            // 
            // panelToday2
            // 
            this.panelToday2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday2.Controls.Add(this.labelAppLeft2);
            this.panelToday2.Controls.Add(this.label9);
            this.panelToday2.Controls.Add(this.panelToday2Next);
            this.panelToday2.Controls.Add(this.labelDate2);
            this.panelToday2.Location = new System.Drawing.Point(2, 90);
            this.panelToday2.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday2.Name = "panelToday2";
            this.panelToday2.Size = new System.Drawing.Size(500, 84);
            this.panelToday2.TabIndex = 16;
            // 
            // labelAppLeft2
            // 
            this.labelAppLeft2.AutoSize = true;
            this.labelAppLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppLeft2.Location = new System.Drawing.Point(-4, 37);
            this.labelAppLeft2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLeft2.Name = "labelAppLeft2";
            this.labelAppLeft2.Size = new System.Drawing.Size(36, 39);
            this.labelAppLeft2.TabIndex = 15;
            this.labelAppLeft2.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Zbývající schůzky";
            // 
            // panelToday2Next
            // 
            this.panelToday2Next.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelToday2Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday2Next.Controls.Add(this.label12);
            this.panelToday2Next.Controls.Add(this.label13);
            this.panelToday2Next.Controls.Add(this.checkBoxToday2Type);
            this.panelToday2Next.Location = new System.Drawing.Point(102, 9);
            this.panelToday2Next.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday2Next.Name = "panelToday2Next";
            this.panelToday2Next.Size = new System.Drawing.Size(382, 61);
            this.panelToday2Next.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(2, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 2;
            this.label12.Tag = "TodayName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(-1, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 1;
            this.label13.Tag = "TodayTime";
            // 
            // checkBoxToday2Type
            // 
            this.checkBoxToday2Type.AutoSize = true;
            this.checkBoxToday2Type.Location = new System.Drawing.Point(2, 6);
            this.checkBoxToday2Type.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxToday2Type.Name = "checkBoxToday2Type";
            this.checkBoxToday2Type.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToday2Type.TabIndex = 0;
            this.checkBoxToday2Type.Tag = "Today2";
            this.checkBoxToday2Type.UseVisualStyleBackColor = true;
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate2.Location = new System.Drawing.Point(-2, 4);
            this.labelDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(90, 22);
            this.labelDate2.TabIndex = 0;
            this.labelDate2.Text = "28.3.2025";
            // 
            // panelToday3
            // 
            this.panelToday3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday3.Controls.Add(this.labelAppLeft3);
            this.panelToday3.Controls.Add(this.label16);
            this.panelToday3.Controls.Add(this.panelToday3Next);
            this.panelToday3.Controls.Add(this.labelDate3);
            this.panelToday3.Location = new System.Drawing.Point(2, 178);
            this.panelToday3.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday3.Name = "panelToday3";
            this.panelToday3.Size = new System.Drawing.Size(500, 84);
            this.panelToday3.TabIndex = 16;
            // 
            // labelAppLeft3
            // 
            this.labelAppLeft3.AutoSize = true;
            this.labelAppLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppLeft3.Location = new System.Drawing.Point(-4, 37);
            this.labelAppLeft3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLeft3.Name = "labelAppLeft3";
            this.labelAppLeft3.Size = new System.Drawing.Size(36, 39);
            this.labelAppLeft3.TabIndex = 15;
            this.labelAppLeft3.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(0, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Zbývající schůzky";
            // 
            // panelToday3Next
            // 
            this.panelToday3Next.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelToday3Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday3Next.Controls.Add(this.label19);
            this.panelToday3Next.Controls.Add(this.label20);
            this.panelToday3Next.Controls.Add(this.checkBoxToday3Type);
            this.panelToday3Next.Location = new System.Drawing.Point(102, 9);
            this.panelToday3Next.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday3Next.Name = "panelToday3Next";
            this.panelToday3Next.Size = new System.Drawing.Size(382, 61);
            this.panelToday3Next.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(2, 39);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 2;
            this.label19.Tag = "TodayName";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(-1, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 17);
            this.label20.TabIndex = 1;
            this.label20.Tag = "TodayTime";
            // 
            // checkBoxToday3Type
            // 
            this.checkBoxToday3Type.AutoSize = true;
            this.checkBoxToday3Type.Location = new System.Drawing.Point(2, 6);
            this.checkBoxToday3Type.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxToday3Type.Name = "checkBoxToday3Type";
            this.checkBoxToday3Type.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToday3Type.TabIndex = 0;
            this.checkBoxToday3Type.Tag = "Today3";
            this.checkBoxToday3Type.UseVisualStyleBackColor = true;
            // 
            // labelDate3
            // 
            this.labelDate3.AutoSize = true;
            this.labelDate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate3.Location = new System.Drawing.Point(-2, 4);
            this.labelDate3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate3.Name = "labelDate3";
            this.labelDate3.Size = new System.Drawing.Size(90, 22);
            this.labelDate3.TabIndex = 0;
            this.labelDate3.Text = "28.3.2025";
            // 
            // panelToday4
            // 
            this.panelToday4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday4.Controls.Add(this.labelAppLeft4);
            this.panelToday4.Controls.Add(this.label23);
            this.panelToday4.Controls.Add(this.panelToday4Next);
            this.panelToday4.Controls.Add(this.labelDate4);
            this.panelToday4.Location = new System.Drawing.Point(2, 266);
            this.panelToday4.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday4.Name = "panelToday4";
            this.panelToday4.Size = new System.Drawing.Size(500, 84);
            this.panelToday4.TabIndex = 17;
            // 
            // labelAppLeft4
            // 
            this.labelAppLeft4.AutoSize = true;
            this.labelAppLeft4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppLeft4.Location = new System.Drawing.Point(-4, 37);
            this.labelAppLeft4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLeft4.Name = "labelAppLeft4";
            this.labelAppLeft4.Size = new System.Drawing.Size(36, 39);
            this.labelAppLeft4.TabIndex = 15;
            this.labelAppLeft4.Text = "5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(0, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Zbývající schůzky";
            // 
            // panelToday4Next
            // 
            this.panelToday4Next.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelToday4Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday4Next.Controls.Add(this.label26);
            this.panelToday4Next.Controls.Add(this.label27);
            this.panelToday4Next.Controls.Add(this.checkBoxToday4Type);
            this.panelToday4Next.Location = new System.Drawing.Point(102, 8);
            this.panelToday4Next.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday4Next.Name = "panelToday4Next";
            this.panelToday4Next.Size = new System.Drawing.Size(382, 61);
            this.panelToday4Next.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(2, 39);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 17);
            this.label26.TabIndex = 2;
            this.label26.Tag = "TodayName";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(-1, 23);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 17);
            this.label27.TabIndex = 1;
            this.label27.Tag = "TodayTime";
            // 
            // checkBoxToday4Type
            // 
            this.checkBoxToday4Type.AutoSize = true;
            this.checkBoxToday4Type.Location = new System.Drawing.Point(2, 6);
            this.checkBoxToday4Type.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxToday4Type.Name = "checkBoxToday4Type";
            this.checkBoxToday4Type.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToday4Type.TabIndex = 0;
            this.checkBoxToday4Type.Tag = "Today4";
            this.checkBoxToday4Type.UseVisualStyleBackColor = true;
            // 
            // labelDate4
            // 
            this.labelDate4.AutoSize = true;
            this.labelDate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate4.Location = new System.Drawing.Point(-2, 4);
            this.labelDate4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate4.Name = "labelDate4";
            this.labelDate4.Size = new System.Drawing.Size(90, 22);
            this.labelDate4.TabIndex = 0;
            this.labelDate4.Text = "28.3.2025";
            // 
            // panelToday5
            // 
            this.panelToday5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday5.Controls.Add(this.labelAppLeft5);
            this.panelToday5.Controls.Add(this.label30);
            this.panelToday5.Controls.Add(this.panelToday5Next);
            this.panelToday5.Controls.Add(this.labelDate5);
            this.panelToday5.Location = new System.Drawing.Point(2, 354);
            this.panelToday5.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday5.Name = "panelToday5";
            this.panelToday5.Size = new System.Drawing.Size(500, 82);
            this.panelToday5.TabIndex = 18;
            // 
            // labelAppLeft5
            // 
            this.labelAppLeft5.AutoSize = true;
            this.labelAppLeft5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppLeft5.Location = new System.Drawing.Point(-4, 37);
            this.labelAppLeft5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppLeft5.Name = "labelAppLeft5";
            this.labelAppLeft5.Size = new System.Drawing.Size(36, 39);
            this.labelAppLeft5.TabIndex = 15;
            this.labelAppLeft5.Text = "5";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label30.Location = new System.Drawing.Point(0, 26);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 13);
            this.label30.TabIndex = 14;
            this.label30.Text = "Zbývající schůzky";
            // 
            // panelToday5Next
            // 
            this.panelToday5Next.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelToday5Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToday5Next.Controls.Add(this.label33);
            this.panelToday5Next.Controls.Add(this.label34);
            this.panelToday5Next.Controls.Add(this.checkBoxToday5Type);
            this.panelToday5Next.Location = new System.Drawing.Point(102, 9);
            this.panelToday5Next.Margin = new System.Windows.Forms.Padding(2);
            this.panelToday5Next.Name = "panelToday5Next";
            this.panelToday5Next.Size = new System.Drawing.Size(382, 61);
            this.panelToday5Next.TabIndex = 12;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label33.Location = new System.Drawing.Point(2, 39);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 17);
            this.label33.TabIndex = 2;
            this.label33.Tag = "TodayName";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label34.Location = new System.Drawing.Point(-1, 23);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(0, 17);
            this.label34.TabIndex = 1;
            this.label34.Tag = "TodayTime";
            // 
            // checkBoxToday5Type
            // 
            this.checkBoxToday5Type.AutoSize = true;
            this.checkBoxToday5Type.Location = new System.Drawing.Point(2, 6);
            this.checkBoxToday5Type.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxToday5Type.Name = "checkBoxToday5Type";
            this.checkBoxToday5Type.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToday5Type.TabIndex = 0;
            this.checkBoxToday5Type.Tag = "Today5";
            this.checkBoxToday5Type.UseVisualStyleBackColor = true;
            // 
            // labelDate5
            // 
            this.labelDate5.AutoSize = true;
            this.labelDate5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate5.Location = new System.Drawing.Point(-2, 4);
            this.labelDate5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate5.Name = "labelDate5";
            this.labelDate5.Size = new System.Drawing.Size(90, 22);
            this.labelDate5.TabIndex = 0;
            this.labelDate5.Text = "28.3.2025";
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.buttonCreateAppointment);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelDoctorText);
            this.Controls.Add(this.buttonViewCard);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.listBoxPacients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informační systém KnPO";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            this.panelToday1.ResumeLayout(false);
            this.panelToday1.PerformLayout();
            this.panelToday1Next.ResumeLayout(false);
            this.panelToday1Next.PerformLayout();
            this.panelToday2.ResumeLayout(false);
            this.panelToday2.PerformLayout();
            this.panelToday2Next.ResumeLayout(false);
            this.panelToday2Next.PerformLayout();
            this.panelToday3.ResumeLayout(false);
            this.panelToday3.PerformLayout();
            this.panelToday3Next.ResumeLayout(false);
            this.panelToday3Next.PerformLayout();
            this.panelToday4.ResumeLayout(false);
            this.panelToday4.PerformLayout();
            this.panelToday4Next.ResumeLayout(false);
            this.panelToday4Next.PerformLayout();
            this.panelToday5.ResumeLayout(false);
            this.panelToday5.PerformLayout();
            this.panelToday5Next.ResumeLayout(false);
            this.panelToday5Next.PerformLayout();
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
        private System.Windows.Forms.Label labelChoosePatient;
        private System.Windows.Forms.Label labelChosenPatient;
        private System.Windows.Forms.ComboBox comboBoxTimePicker;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.FlowLayoutPanel panelDisplay;
        private System.Windows.Forms.Panel panelToday1;
        private System.Windows.Forms.Panel panelToday1Next;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.CheckBox checkBoxToday1Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAppLeft1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelToday2;
        private System.Windows.Forms.Label labelAppLeft2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelToday2Next;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxToday2Type;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Panel panelToday3;
        private System.Windows.Forms.Label labelAppLeft3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelToday3Next;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBoxToday3Type;
        private System.Windows.Forms.Label labelDate3;
        private System.Windows.Forms.Panel panelToday4;
        private System.Windows.Forms.Label labelAppLeft4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panelToday4Next;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox checkBoxToday4Type;
        private System.Windows.Forms.Label labelDate4;
        private System.Windows.Forms.Panel panelToday5;
        private System.Windows.Forms.Label labelAppLeft5;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panelToday5Next;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox checkBoxToday5Type;
        private System.Windows.Forms.Label labelDate5;
    }
}
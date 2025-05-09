namespace WindowsFormsApp1
{
    partial class FormDisplayAppointments
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
            this.flowLayoutPanelAppointments = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAppointments
            // 
            this.flowLayoutPanelAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelAppointments.AutoScroll = true;
            this.flowLayoutPanelAppointments.Location = new System.Drawing.Point(38, 85);
            this.flowLayoutPanelAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelAppointments.Name = "flowLayoutPanelAppointments";
            this.flowLayoutPanelAppointments.Size = new System.Drawing.Size(524, 271);
            this.flowLayoutPanelAppointments.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.Location = new System.Drawing.Point(469, 56);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 24);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Hledat";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moje schůzky";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.IntegralHeight = false;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "ZOBRAZIT VŠE",
            "Anamnéza a fyzikální vyšetření  ",
            "Měření krevního tlaku  ",
            "Měření teploty  ",
            "Měření pulzu  ",
            "Saturace kyslíku (SpO2)  ",
            "Odběr krve  ",
            "Krevní obraz  ",
            "Biochemie krve  ",
            "Srážlivost krve  ",
            "Hormonální testy  ",
            "Mikrobiologické kultivace  ",
            "Rentgen hrudníku  ",
            "Rentgen končetin  ",
            "Ultrazvuk břicha  ",
            "CT mozku  ",
            "MRI páteře  ",
            "EKG (klidové)  ",
            "EKG zátěžové  ",
            "Holter EKG  ",
            "ECHO srdce  ",
            "Spirometrie  ",
            "Bronchoskopie  ",
            "Polysomnografie  ",
            "EEG  ",
            "EMG  ",
            "Lumbální punkce  ",
            "Rentgen kloubů  ",
            "Denzitometrie  ",
            "Artroskopie  ",
            "Měření zrakové ostrosti  ",
            "Tonometrie  ",
            "OCT sítnice  ",
            "Audiometrie  ",
            "Tympanometrie  ",
            "Endoskopie nosu a krku  ",
            "Biopsie nádorů  ",
            "Tumorové markery  ",
            "Kolonoskopie  ",
            "Gastroskopie  ",
            "Gynekologický ultrazvuk  ",
            "Cytologie děložního čípku  ",
            "Hormonální profil  ",
            "Uroflowmetrie  ",
            "Cystoskopie  ",
            "PSA test (prostata)"});
            this.comboBoxSearch.Location = new System.Drawing.Point(38, 56);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSearch.MaxDropDownItems = 15;
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(428, 25);
            this.comboBoxSearch.TabIndex = 4;
            // 
            // FormDisplayAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.flowLayoutPanelAppointments);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDisplayAppointments";
            this.Text = "FormDisplayAppointments";
            this.Load += new System.EventHandler(this.FormDisplayAppointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAppointments;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
    }
}
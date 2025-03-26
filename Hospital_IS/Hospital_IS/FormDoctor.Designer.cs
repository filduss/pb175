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
            this.SuspendLayout();
            // 
            // listBoxPacients
            // 
            this.listBoxPacients.FormattingEnabled = true;
            this.listBoxPacients.Location = new System.Drawing.Point(12, 83);
            this.listBoxPacients.Name = "listBoxPacients";
            this.listBoxPacients.Size = new System.Drawing.Size(158, 355);
            this.listBoxPacients.TabIndex = 0;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(176, 415);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(126, 23);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "Přidat záznam";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonViewCard
            // 
            this.buttonViewCard.Location = new System.Drawing.Point(176, 386);
            this.buttonViewCard.Name = "buttonViewCard";
            this.buttonViewCard.Size = new System.Drawing.Size(126, 23);
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
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelDoctorText);
            this.Controls.Add(this.buttonViewCard);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.listBoxPacients);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPacients;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonViewCard;
        private System.Windows.Forms.Label labelDoctorText;
        private System.Windows.Forms.Label labelDoctor;
    }
}
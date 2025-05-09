namespace WindowsFormsApp1
{
    partial class FormPacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacient));
            this.buttonMedicalRecords = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMedicalRecords
            // 
            this.buttonMedicalRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMedicalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicalRecords.Location = new System.Drawing.Point(76, 50);
            this.buttonMedicalRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMedicalRecords.Name = "buttonMedicalRecords";
            this.buttonMedicalRecords.Size = new System.Drawing.Size(130, 40);
            this.buttonMedicalRecords.TabIndex = 0;
            this.buttonMedicalRecords.Text = "Zdravotní karta";
            this.buttonMedicalRecords.UseVisualStyleBackColor = true;
            this.buttonMedicalRecords.Click += new System.EventHandler(this.buttonMedicalRecords_Click);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointments.Location = new System.Drawing.Point(76, 108);
            this.buttonAppointments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(130, 40);
            this.buttonAppointments.TabIndex = 1;
            this.buttonAppointments.Text = "Schůzky";
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // FormPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 196);
            this.Controls.Add(this.buttonAppointments);
            this.Controls.Add(this.buttonMedicalRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPacient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informační systém KnPO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMedicalRecords;
        private System.Windows.Forms.Button buttonAppointments;
    }
}
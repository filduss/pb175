namespace WindowsFormsApp1
{
    partial class FormAddDoctor
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
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.textBoxDoctorEmail = new System.Windows.Forms.TextBox();
            this.textBoxDoctorPassword = new System.Windows.Forms.TextBox();
            this.labelDoctorEmail = new System.Windows.Forms.Label();
            this.labelDoctorPassword = new System.Windows.Forms.Label();
            this.buttonCreateDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoctorName.Location = new System.Drawing.Point(77, 90);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(195, 28);
            this.textBoxDoctorName.TabIndex = 0;
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorName.Location = new System.Drawing.Point(72, 67);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(64, 20);
            this.labelDoctorName.TabIndex = 1;
            this.labelDoctorName.Text = "Jméno:";
            // 
            // textBoxDoctorEmail
            // 
            this.textBoxDoctorEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxDoctorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoctorEmail.Location = new System.Drawing.Point(76, 162);
            this.textBoxDoctorEmail.Name = "textBoxDoctorEmail";
            this.textBoxDoctorEmail.Size = new System.Drawing.Size(195, 28);
            this.textBoxDoctorEmail.TabIndex = 2;
            // 
            // textBoxDoctorPassword
            // 
            this.textBoxDoctorPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxDoctorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoctorPassword.Location = new System.Drawing.Point(76, 236);
            this.textBoxDoctorPassword.Name = "textBoxDoctorPassword";
            this.textBoxDoctorPassword.PasswordChar = '*';
            this.textBoxDoctorPassword.Size = new System.Drawing.Size(195, 28);
            this.textBoxDoctorPassword.TabIndex = 5;
            // 
            // labelDoctorEmail
            // 
            this.labelDoctorEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDoctorEmail.AutoSize = true;
            this.labelDoctorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorEmail.Location = new System.Drawing.Point(72, 139);
            this.labelDoctorEmail.Name = "labelDoctorEmail";
            this.labelDoctorEmail.Size = new System.Drawing.Size(56, 20);
            this.labelDoctorEmail.TabIndex = 4;
            this.labelDoctorEmail.Text = "Email:";
            // 
            // labelDoctorPassword
            // 
            this.labelDoctorPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDoctorPassword.AutoSize = true;
            this.labelDoctorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorPassword.Location = new System.Drawing.Point(72, 213);
            this.labelDoctorPassword.Name = "labelDoctorPassword";
            this.labelDoctorPassword.Size = new System.Drawing.Size(58, 20);
            this.labelDoctorPassword.TabIndex = 5;
            this.labelDoctorPassword.Text = "Heslo:";
            // 
            // buttonCreateDoctor
            // 
            this.buttonCreateDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCreateDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateDoctor.Location = new System.Drawing.Point(96, 294);
            this.buttonCreateDoctor.Name = "buttonCreateDoctor";
            this.buttonCreateDoctor.Size = new System.Drawing.Size(155, 49);
            this.buttonCreateDoctor.TabIndex = 6;
            this.buttonCreateDoctor.Text = "Vytvořit účet";
            this.buttonCreateDoctor.UseVisualStyleBackColor = true;
            this.buttonCreateDoctor.Click += new System.EventHandler(this.buttonCreateDoctor_Click);
            // 
            // FormAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 402);
            this.Controls.Add(this.buttonCreateDoctor);
            this.Controls.Add(this.labelDoctorPassword);
            this.Controls.Add(this.labelDoctorEmail);
            this.Controls.Add(this.textBoxDoctorPassword);
            this.Controls.Add(this.textBoxDoctorEmail);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.textBoxDoctorName);
            this.Name = "FormAddDoctor";
            this.Text = "Informační systém KnPO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.TextBox textBoxDoctorEmail;
        private System.Windows.Forms.TextBox textBoxDoctorPassword;
        private System.Windows.Forms.Label labelDoctorEmail;
        private System.Windows.Forms.Label labelDoctorPassword;
        private System.Windows.Forms.Button buttonCreateDoctor;
    }
}
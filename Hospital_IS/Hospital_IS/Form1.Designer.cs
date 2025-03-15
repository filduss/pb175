namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(93, 230);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(197, 60);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Potvrdit";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(93, 125);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 26);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(93, 107);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(93, 166);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(37, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Heslo:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(93, 184);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(197, 30);
            this.textBoxPassword.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "DOKTOR",
            "PACIENT"});
            this.comboBoxRole.Location = new System.Drawing.Point(93, 73);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(197, 21);
            this.comboBoxRole.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(90, 57);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(73, 13);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Typ uživatele:";
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCreateAccount.Location = new System.Drawing.Point(179, 292);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(111, 13);
            this.labelCreateAccount.TabIndex = 7;
            this.labelCreateAccount.Text = "Nemám účet pacienta";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            this.labelCreateAccount.MouseEnter += new System.EventHandler(this.labelCreateAccount_MouseEnter);
            this.labelCreateAccount.MouseLeave += new System.EventHandler(this.labelCreateAccount_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 361);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelCreateAccount;
    }
}


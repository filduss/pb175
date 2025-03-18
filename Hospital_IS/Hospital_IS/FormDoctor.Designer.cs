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
            this.SuspendLayout();
            // 
            // listBoxPacients
            // 
            this.listBoxPacients.FormattingEnabled = true;
            this.listBoxPacients.Location = new System.Drawing.Point(12, 12);
            this.listBoxPacients.Name = "listBoxPacients";
            this.listBoxPacients.Size = new System.Drawing.Size(158, 394);
            this.listBoxPacients.TabIndex = 0;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(13, 413);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(157, 23);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "Přidat záznam";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.listBoxPacients);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPacients;
        private System.Windows.Forms.Button buttonAddRecord;
    }
}
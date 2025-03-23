namespace WindowsFormsApp1
{
    partial class FormMedicalRecords
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
            this.listBoxRecords = new System.Windows.Forms.ListBox();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRecords
            // 
            this.listBoxRecords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecords.FormattingEnabled = true;
            this.listBoxRecords.ItemHeight = 25;
            this.listBoxRecords.Location = new System.Drawing.Point(12, 61);
            this.listBoxRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxRecords.Name = "listBoxRecords";
            this.listBoxRecords.Size = new System.Drawing.Size(250, 504);
            this.listBoxRecords.TabIndex = 0;
            this.listBoxRecords.SelectedIndexChanged += new System.EventHandler(this.listBoxRecords_SelectedIndexChanged);
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetail.Location = new System.Drawing.Point(273, 61);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(509, 508);
            this.textBoxDetail.TabIndex = 1;
            this.textBoxDetail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(290, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(264, 38);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Vaše zdravotní karta";
            // 
            // FormMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 581);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.listBoxRecords);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMedicalRecords";
            this.Text = "FormMedicalRecords";
            this.Load += new System.EventHandler(this.FormMedicalRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRecords;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Label labelTitle;
    }
}
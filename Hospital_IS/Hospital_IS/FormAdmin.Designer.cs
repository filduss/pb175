namespace WindowsFormsApp1
{
    partial class FormAdmin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonSavePatients = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabPageDoctors = new System.Windows.Forms.TabPage();
            this.buttonDeleteDoctor = new System.Windows.Forms.Button();
            this.buttonSaveDoctors = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.tabControlAdmin.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPageDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPagePatients);
            this.tabControlAdmin.Controls.Add(this.tabPageDoctors);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1067, 554);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.buttonDeletePatient);
            this.tabPagePatients.Controls.Add(this.buttonSavePatients);
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePatients.Location = new System.Drawing.Point(4, 27);
            this.tabPagePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePatients.Size = new System.Drawing.Size(1059, 523);
            this.tabPagePatients.TabIndex = 0;
            this.tabPagePatients.Text = "Pacienti";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePatient.Location = new System.Drawing.Point(859, 66);
            this.buttonDeletePatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(187, 52);
            this.buttonDeletePatient.TabIndex = 2;
            this.buttonDeletePatient.Text = "Odstránit pacienta";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonSavePatients
            // 
            this.buttonSavePatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePatients.Location = new System.Drawing.Point(859, 7);
            this.buttonSavePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSavePatients.Name = "buttonSavePatients";
            this.buttonSavePatients.Size = new System.Drawing.Size(187, 52);
            this.buttonSavePatients.TabIndex = 1;
            this.buttonSavePatients.Text = "Uložit změny";
            this.buttonSavePatients.UseVisualStyleBackColor = true;
            this.buttonSavePatients.Click += new System.EventHandler(this.buttonSavePatients_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1048, 508);
            this.dataGridViewPatients.TabIndex = 0;
            // 
            // tabPageDoctors
            // 
            this.tabPageDoctors.Controls.Add(this.buttonDeleteDoctor);
            this.tabPageDoctors.Controls.Add(this.buttonSaveDoctors);
            this.tabPageDoctors.Controls.Add(this.dataGridViewDoctors);
            this.tabPageDoctors.Location = new System.Drawing.Point(4, 27);
            this.tabPageDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDoctors.Name = "tabPageDoctors";
            this.tabPageDoctors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDoctors.Size = new System.Drawing.Size(1059, 523);
            this.tabPageDoctors.TabIndex = 1;
            this.tabPageDoctors.Text = "Lékaři";
            this.tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDoctor
            // 
            this.buttonDeleteDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDoctor.Location = new System.Drawing.Point(859, 66);
            this.buttonDeleteDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            this.buttonDeleteDoctor.Size = new System.Drawing.Size(187, 52);
            this.buttonDeleteDoctor.TabIndex = 2;
            this.buttonDeleteDoctor.Text = "Odstránit lékaře";
            this.buttonDeleteDoctor.UseVisualStyleBackColor = true;
            this.buttonDeleteDoctor.Click += new System.EventHandler(this.buttonDeleteDoctor_Click);
            // 
            // buttonSaveDoctors
            // 
            this.buttonSaveDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveDoctors.Location = new System.Drawing.Point(859, 7);
            this.buttonSaveDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveDoctors.Name = "buttonSaveDoctors";
            this.buttonSaveDoctors.Size = new System.Drawing.Size(187, 52);
            this.buttonSaveDoctors.TabIndex = 1;
            this.buttonSaveDoctors.Text = "Uložit změny";
            this.buttonSaveDoctors.UseVisualStyleBackColor = true;
            this.buttonSaveDoctors.Click += new System.EventHandler(this.buttonSaveDoctors_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(1048, 508);
            this.dataGridViewDoctors.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmin";
            this.Text = "Informační systém KnPO";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPageDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPageDoctors;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button buttonSavePatients;
        private System.Windows.Forms.Button buttonSaveDoctors;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonDeleteDoctor;
    }
}
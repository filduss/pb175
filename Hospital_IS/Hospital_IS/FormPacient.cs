using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPacient : Form
    {
        string connectionPassword = null;
        private int patientId;
        public FormPacient(string connectionPassword, int patientId)
        {
            InitializeComponent();
            this.connectionPassword = connectionPassword;
            this.patientId = patientId;
        }

        private void buttonMedicalRecords_Click(object sender, EventArgs e)
        {
            FormMedicalRecords records = new FormMedicalRecords(connectionPassword, patientId);
            records.ShowDialog();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            FormDisplayAppointments appointments = new FormDisplayAppointments(connectionPassword, patientId);
            appointments.ShowDialog();
        }
    }
}

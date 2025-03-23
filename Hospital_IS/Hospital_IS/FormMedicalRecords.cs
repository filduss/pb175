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
    public partial class FormMedicalRecords: Form
    {
        private string connectionPassword;
        private int patientId;
        public FormMedicalRecords(string connectionPassword, int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.connectionPassword = connectionPassword;
        }
    }
}

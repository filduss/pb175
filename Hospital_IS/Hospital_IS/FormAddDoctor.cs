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
    public partial class FormAddDoctor: Form
    {
        private string connectionPassword;

        public FormAddDoctor(string connectionPassword)
        {
            InitializeComponent();
            this.connectionPassword = connectionPassword;
        }
    }
}

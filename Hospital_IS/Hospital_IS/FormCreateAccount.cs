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
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount(string connectionString)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                labelMatch.ForeColor = Color.Red;
                labelMatch.Text = "Hesla se neshodují";
            }
            else
            {
                labelMatch.Text = "";
            }
        }
    }
}

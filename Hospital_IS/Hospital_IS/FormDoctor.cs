using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDoctor : Form
    {
        private string connectionPassword = null;
        private List<PacientBasicInfo> pacients = new List<PacientBasicInfo>();
        private string username = null;
        private int userId = -1;
        public FormDoctor(string connectionPassword, string username, int userId)
        {
            this.username = username;
            this.userId = userId;
            this.connectionPassword = connectionPassword;
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            labelDoctor.Text = username;
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string query = $"SELECT Id, UserName, Email FROM dbo.pacients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PacientBasicInfo pacient = new PacientBasicInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            pacients.Add(pacient);
                        }
                    }
                }
                listBoxPacients.DataSource = pacients;
                listBoxPacients.DisplayMember = "Name";
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (listBoxPacients.SelectedIndex == -1)
            {
                MessageBox.Show("Prvni vyberte pacienta");
            }
            FormAddRecord addRecord = new FormAddRecord(connectionPassword, pacients[listBoxPacients.SelectedIndex].Id, pacients[listBoxPacients.SelectedIndex].Name, userId);
            addRecord.Show();
        }

        private void buttonViewCard_Click(object sender, EventArgs e)
        {
            if (listBoxPacients.SelectedIndex == -1)
            {
                MessageBox.Show("Prvni vyberte pacienta");
            }

            FormMedicalRecords medicalForm = new FormMedicalRecords(connectionPassword, pacients[listBoxPacients.SelectedIndex].Id);
            medicalForm.Show();
        }
    }
}

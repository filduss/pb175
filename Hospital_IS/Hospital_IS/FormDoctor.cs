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
        private List<PacientBasicInfo> Pacients = new List<PacientBasicInfo>();
        class PacientBasicInfo
        {
            private int id;
            private string name;
            private string email;

            public PacientBasicInfo(int id, string name, string email)
            {
                this.id = id;
                this.name = name;
                this.email = email;
            }

            public int Id { get { return id; } }
            public string Name { get { return name; } }
            public string Email { get { return email; } }
        }
        public FormDoctor(string connectionPassword)
        {
            this.connectionPassword = connectionPassword;
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
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
                            Pacients.Add(pacient);
                        }
                    }

                }
                foreach (var pacient in Pacients)
                {
                    listBoxPacients.Items.Add(pacient.Id + "\t" + pacient.Name);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPacients.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte pacienta, kterého chcete smazat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show(Pacients[listBoxPacients.SelectedIndex].Name + "\n"+ Pacients[listBoxPacients.SelectedIndex].Id + "\n" + Pacients[listBoxPacients.SelectedIndex].Email);
        }
    }
}

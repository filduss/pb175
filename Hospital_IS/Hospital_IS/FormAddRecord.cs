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
    public partial class FormAddRecord : Form
    {
        private string connectionPassword;
        private int pacientId;
        private string pacientName;
        private int doctorId;
        private List<Examination> examinations;
        public FormAddRecord(string connectionPassword, int pacientId, string pacientName, int doctorId, List<Examination> examinations)
        {
            this.connectionPassword = connectionPassword;
            this.pacientId = pacientId;
            this.pacientName = pacientName;
            this.doctorId = doctorId;
            this.examinations = examinations;
            InitializeComponent();
        }
        public class Examination
        {
            public string Category { get; set; }
            public string Name { get; set; }

            public Examination(string category, string name)
            {
                Category = category;
                Name = name;
            }
        }

        private void FormAddRecord_Load(object sender, EventArgs e)
        {
            comboBoxExaminations.DataSource = examinations;
            comboBoxExaminations.DisplayMember = "Name";
            labelPacient.Text = pacientName;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxExaminations.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte typ vyšetření");
                return;
            }

            DateTime date = monthCalendar.SelectionStart;
            if (date == null)
            {
                date = DateTime.Now;
            }
            
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO health_records (DoctorId, PatientId, RecordText, RecordDate, RecordType) VALUES (@DoctorId, @PatientId, @RecordText, @RecordDate, @RecordType)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                    cmd.Parameters.AddWithValue("@PatientId", pacientId);
                    cmd.Parameters.AddWithValue("@RecordText", textBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@RecordDate", date);
                    cmd.Parameters.AddWithValue("@RecordType", comboBoxExaminations.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Záznam byl úspěšně přidán");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Přidání se nepodařilo z důvodu: \n{ex.Message}");
            }
        }
    }
}

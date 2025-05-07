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
    public partial class FormAdmin : Form
    {
        private string connectionPassword;

        public FormAdmin(string connectionPassword)
        {
            InitializeComponent();
            this.connectionPassword = connectionPassword;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            string connectionString = $"Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={connectionPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email, DateOfBirth FROM dbo.pacients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewPatients.DataSource = table;
                dataGridViewPatients.Columns["Id"].ReadOnly = true;
            }
        }

        private void buttonSavePatients_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Id, Username, Email, DateOfBirth FROM dbo.pacients";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable table = (DataTable)dataGridViewPatients.DataSource;
                adapter.Update(table);

                MessageBox.Show("Zmeny byly úspěšně uloženy.");
            }
        }

        private void LoadDoctors()
        {
            string connectionString = $"Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={connectionPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email FROM dbo.doctors";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDoctors.DataSource = table;
                dataGridViewDoctors.Columns["Id"].ReadOnly = true;
            }
        }

        private void buttonSaveDoctors_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format(
        "Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;",
        connectionPassword);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Email FROM dbo.doctors";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable table = (DataTable)dataGridViewDoctors.DataSource;
                adapter.Update(table);

                MessageBox.Show("Změny byly úspešně uloženy.");
            }
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte pacienta, kterého chcete odstranit.");
                return;
            }

            int selectedId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["Id"].Value);
            string patientName = dataGridViewPatients.SelectedRows[0].Cells["Username"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete odstranit pacienta „{patientName}“?",
                "Potvrzení odstranění",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                string connectionString = string.Format(
                    "Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;",
                    connectionPassword);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM dbo.pacients WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", selectedId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pacient byl úspěšně odstraněn.");
                            LoadPatients();
                        }
                        else
                        {
                            MessageBox.Show("Odstranění se nezdařilo.");
                        }
                    }
                }
            }
        }

        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte lékaře, kterého chcete odstranit.");
                return;
            }

            int selectedId = Convert.ToInt32(dataGridViewDoctors.SelectedRows[0].Cells["Id"].Value);
            string doctorName = dataGridViewDoctors.SelectedRows[0].Cells["Username"].Value.ToString();

            if (doctorName == "admin")
            {
                MessageBox.Show("Administrátorský účet nelze odstranit.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete odstranit lékaře „{doctorName}“?",
                "Potvrzení odstranění",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                string connectionString = string.Format(
                    "Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;",
                    connectionPassword);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM dbo.doctors WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", selectedId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Lékař byl úspěšně odstraněn.");
                            LoadDoctors();
                        }
                        else
                        {
                            MessageBox.Show("Odstranění se nezdařilo.");
                        }
                    }
                }
            }
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            FormAddDoctor addForm = new FormAddDoctor(connectionPassword);
            addForm.FormClosed += (s, args) => LoadDoctors();
            addForm.ShowDialog();
        }
    }
}
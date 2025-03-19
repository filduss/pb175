using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCreateAccount : Form
    {
        string connectionPassword = null;
        public FormCreateAccount(string connectionString)
        {
            this.connectionPassword = connectionString;
            InitializeComponent();
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

        private bool IsValidDate(int day, int month, int year)
        {
            string dateString = $"{year}-{month}-{day}";
            return DateTime.TryParse(dateString, out _);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (labelMatch.Text != "" || textBoxPassword.Text == "" || textBoxRepeatPassword.Text == "")
            {
                MessageBox.Show("Heslo je povinne");
                return;
            }

            int day = int.Parse(comboBoxDay.SelectedItem.ToString());
            int month = int.Parse(comboBoxMonth.SelectedItem.ToString());
            int year = int.Parse(comboBoxYear.SelectedItem.ToString());

            if (!IsValidDate(day, month, year))
            {
                MessageBox.Show("Neplatný dátum! Skontrolujte deň, mesiac a rok.");
                return;
            }

            DateTime dateOfBirth = new DateTime(year, month, day);
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            InsertNewPacient(connectionString, textBoxPassword.Text, textBoxEmail.Text, textBoxName.Text, dateOfBirth);
        }
        private static void InsertNewPacient(string connectionString, string password, string email, string username, DateTime dateOfBirth)
        {

            var (hash, salt) = HashPassword(password);
            string sqlQuery = "INSERT INTO dbo.pacients (Username, PasswordHash, Salt, Email, DateOfBirth) " +
                          "VALUES (@Username, @PasswordHash, @Salt, @Email, @DateOfBirth)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hash);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pacient created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create new Pacient.");
                    }
                }
            }
        }
        public static (string hash, string salt) HashPassword(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                string salt = Convert.ToBase64String(saltBytes);

                var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 13000);
                byte[] hashBytes = pbkdf2.GetBytes(32);

                return (Convert.ToBase64String(hashBytes), salt);
            }
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBoxDay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i);
            }

            comboBoxDay.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
        }
    }
}

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
    public partial class FormAddDoctor: Form
    {
        private string connectionPassword;

        public FormAddDoctor(string connectionPassword)
        {
            InitializeComponent();
            this.connectionPassword = connectionPassword;
        }

        private void buttonCreateDoctor_Click(object sender, EventArgs e)
        {
            string name = textBoxDoctorName.Text.Trim();
            string email = textBoxDoctorEmail.Text.Trim();
            string password = textBoxDoctorPassword.Text;

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Všechna pole jsou povinná.");
                return;
            }

            string connectionString = $"Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={connectionPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";

            bool success = InsertNewDoctor(connectionString, password, email, name);
            if (success)
            {
                MessageBox.Show("Lékař byl úspěšně přidán.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vytvoření nového lékaře zlyhalo.");
            }
        }

        private static bool InsertNewDoctor(string connectionString, string password, string email, string username)
        {
            var (hash, salt) = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM dbo.doctors WHERE Email = @Email";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Tento e-mail je již zaregistrovaný. Zvolte prosím jiný.");
                        return false;
                    }
                }

                string insertQuery = "INSERT INTO dbo.doctors (Username, PasswordHash, Salt, Email) VALUES (@Username, @PasswordHash, @Salt, @Email)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hash);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@Email", email);
                    return command.ExecuteNonQuery() > 0;
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

    }
}

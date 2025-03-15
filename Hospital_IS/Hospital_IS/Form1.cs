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
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.IdentityModel.Protocols.WSTrust;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionPassword = null;
        private static (string hash, string salt) GetPasswordHashAndSalt(string connectionPassword, string userEmail, int userType)
        {
            string passwordHash = string.Empty;
            string salt = string.Empty;
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            string type = null;
            if (userType == 0)
            {
                type = "dbo.doctors";
            }
            else if (userType == 1)
            {
                type = "dbo.pacients";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show(type);
                string queryHash = $"SELECT PasswordHash FROM {type} WHERE Email LIKE '{userEmail}'";
                string querySalt = $"SELECT Salt FROM {type} WHERE Email LIKE '{userEmail}'";

                string queryCorrectness = $"SELECT COUNT(1) FROM {type} WHERE Email LIKE '{userEmail}'";

                using (SqlCommand command = new SqlCommand(queryCorrectness, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        throw new Exception();
                    }
                }

                using (SqlCommand command = new SqlCommand(queryHash, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        passwordHash = result.ToString();
                    }
                }

                using (SqlCommand command = new SqlCommand(querySalt, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        salt = result.ToString();
                    }
                }
            }
            return (passwordHash, salt);
        }

        private static bool VerifyPassword(string password, string hash, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 13000);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(hashBytes) == hash;
        }
        public static async Task<string> RetrieveSecret()
        {
            string databasePassword = "";
            string keyVaultUrl = "https://databasepb175vault.vault.azure.net/";
            try
            {
                var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
                KeyVaultSecret secret = await client.GetSecretAsync("password");
                databasePassword = secret.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving secret: {ex.Message} \n PLEASE RESTART THE APPLICATION");
            }
            return databasePassword;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userEmail = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            if (comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte prosím typ uživatele");
            }

            (string hash, string salt) = GetPasswordHashAndSalt(connectionPassword, userEmail, comboBoxRole.SelectedIndex);

            if (VerifyPassword(password, hash, salt))
            {
                
                MessageBox.Show("SUCCESS");
            }
            else
            {
                MessageBox.Show("FAILED");
            }
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            connectionPassword = await RetrieveSecret();
            buttonLogin.Enabled = true;
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount createAccount = new FormCreateAccount(connectionPassword);
            createAccount.ShowDialog();
        }

        private void labelCreateAccount_MouseHover(object sender, EventArgs e)
        {
            // FINISH UNDERLINE
        }
    }
}

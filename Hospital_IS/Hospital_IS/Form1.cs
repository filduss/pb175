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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionPassword = null;
        private static (string hash, string salt, string username) GetInformation(string connectionPassword, string userEmail, int userType)
        {
            string passwordHash = string.Empty;
            string salt = string.Empty;
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            string type = null;
            string username = null;
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
                string queryHash = $"SELECT PasswordHash FROM {type} WHERE Email LIKE '{userEmail}'";
                string querySalt = $"SELECT Salt FROM {type} WHERE Email LIKE '{userEmail}'";
                string queryUserName = $"SELECT Username FROM {type} WHERE Email LIKE '{userEmail}'";

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

                using (SqlCommand command = new SqlCommand(queryUserName, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        username = result.ToString();
                    }
                }
            }
            return (passwordHash, salt, username);
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

        private static int GetUserId(string connectionPassword, string userEmail, int userType)
        {
            int userId = -1;
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            string table = (userType == 0) ? "dbo.doctors" : "dbo.pacients";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT Id FROM {table} WHERE CAST(Email AS NVARCHAR(MAX)) = @Email";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", userEmail);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Používateľ s daným emailom neexistuje.");
                    }
                }
            }

            return userId;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userEmail = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte prosím typ uživatele");
                return;
            }

            if (userEmail == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Email i heslo je povinne!");
                return;
            }

            string hash = null;
            string salt = null;
            string username = null;

            if (userEmail.ToLower() == "admin")
            {
                try
                {
                    (hash, salt, username) = GetInformation(connectionPassword, "admin", 0);
                }
                catch
                {
                    MessageBox.Show("Admin účet neexistuje.");
                    return;
                }

                if (VerifyPassword(password, hash, salt))
                {
                    this.Hide();
                    FormAdmin adminForm = new FormAdmin(connectionPassword);
                    adminForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Špatné heslo pro admina.");
                }

                return;
            }

            try
            {
                (hash, salt, username) = GetInformation(connectionPassword, userEmail, comboBoxRole.SelectedIndex);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
                //MessageBox.Show("Nespravné údaje");
                return;
            }

            if (VerifyPassword(password, hash, salt))
            {
                this.Hide();
                if (comboBoxRole.SelectedIndex == 0)
                {
                    int userId = -1;
                    try
                    {
                        userId = GetUserId(connectionPassword, userEmail, comboBoxRole.SelectedIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nepodarilo sa získať ID používateľa: " + ex.Message);
                        return;
                    }
                    FormDoctor doctor = new FormDoctor(connectionPassword, username, userId);
                    doctor.ShowDialog();
                }
                else if (comboBoxRole.SelectedIndex == 1)
                {
                    int userId;
                    try
                    {
                        userId = GetUserId(connectionPassword, userEmail, comboBoxRole.SelectedIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nepodarilo sa získať ID používateľa: " + ex.Message);
                        return;
                    }

                    FormPacient pacient = new FormPacient(connectionPassword, userId);
                    pacient.ShowDialog();
                }
                this.Show();
            }
            else
            {
                textBoxPassword.Text = "";
                MessageBox.Show("Špatné heslo, zkuste znovu");
            }
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            buttonLogin.Enabled = false;
            connectionPassword = await RetrieveSecret();
            buttonLogin.Enabled = true;
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            if (connectionPassword == null)
            {
                MessageBox.Show("Vyckejte na pripojeni k databazi");
                return;
            }
            FormCreateAccount createAccount = new FormCreateAccount(connectionPassword);
            createAccount.ShowDialog();
        }

        private void labelCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            labelCreateAccount.Font = new Font(labelCreateAccount.Font, FontStyle.Underline | FontStyle.Italic);
        }

        private void labelCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            labelCreateAccount.Font = new Font(labelCreateAccount.Font, FontStyle.Italic);
        }
    }
}

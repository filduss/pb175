using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static WindowsFormsApp1.FormAddRecord;

namespace WindowsFormsApp1
{
    public partial class FormDoctor : Form
    {
        private string connectionPassword = null;
        private List<PacientBasicInfo> pacients = new List<PacientBasicInfo>();
        private string username = null;
        private int userId = -1;
        private List<Examination> examinations = new List<Examination>
            {
                new Examination("Základní vyšetření", "Anamnéza a fyzikální vyšetření"),
                new Examination("Základní vyšetření", "Měření krevního tlaku"),
                new Examination("Základní vyšetření", "Měření teploty"),
                new Examination("Základní vyšetření", "Měření pulzu"),
                new Examination("Základní vyšetření", "Saturace kyslíku (SpO2)"),
                new Examination("Základní vyšetření", "Odběr krve"),
                new Examination("Laboratorní vyšetření", "Krevní obraz"),
                new Examination("Laboratorní vyšetření", "Biochemie krve"),
                new Examination("Laboratorní vyšetření", "Srážlivost krve"),
                new Examination("Laboratorní vyšetření", "Hormonální testy"),
                new Examination("Laboratorní vyšetření", "Mikrobiologické kultivace"),
                new Examination("Zobrazovací vyšetření", "Rentgen hrudníku"),
                new Examination("Zobrazovací vyšetření", "Rentgen končetin"),
                new Examination("Zobrazovací vyšetření", "Ultrazvuk břicha"),
                new Examination("Zobrazovací vyšetření", "CT mozku"),
                new Examination("Zobrazovací vyšetření", "MRI páteře"),
                new Examination("Kardiologická vyšetření", "EKG (klidové)"),
                new Examination("Kardiologická vyšetření", "EKG zátěžové"),
                new Examination("Kardiologická vyšetření", "Holter EKG"),
                new Examination("Kardiologická vyšetření", "ECHO srdce"),
                new Examination("Plicní vyšetření", "Spirometrie"),
                new Examination("Plicní vyšetření", "Bronchoskopie"),
                new Examination("Plicní vyšetření", "Polysomnografie"),
                new Examination("Neurologická vyšetření", "EEG"),
                new Examination("Neurologická vyšetření", "EMG"),
                new Examination("Neurologická vyšetření", "Lumbální punkce"),
                new Examination("Ortopedická vyšetření", "Rentgen kloubů"),
                new Examination("Ortopedická vyšetření", "Denzitometrie"),
                new Examination("Ortopedická vyšetření", "Artroskopie"),
                new Examination("Oční vyšetření", "Měření zrakové ostrosti"),
                new Examination("Oční vyšetření", "Tonometrie"),
                new Examination("Oční vyšetření", "OCT sítnice"),
                new Examination("ORL vyšetření", "Audiometrie"),
                new Examination("ORL vyšetření", "Tympanometrie"),
                new Examination("ORL vyšetření", "Endoskopie nosu a krku"),
                new Examination("Onkologická vyšetření", "Biopsie nádorů"),
                new Examination("Onkologická vyšetření", "Tumorové markery"),
                new Examination("Onkologická vyšetření", "Kolonoskopie"),
                new Examination("Onkologická vyšetření", "Gastroskopie"),
                new Examination("Gynekologická vyšetření", "Gynekologický ultrazvuk"),
                new Examination("Gynekologická vyšetření", "Cytologie děložního čípku"),
                new Examination("Gynekologická vyšetření", "Hormonální profil"),
                new Examination("Urologická vyšetření", "Uroflowmetrie"),
                new Examination("Urologická vyšetření", "Cystoskopie"),
                new Examination("Urologická vyšetření", "PSA test (prostata)")
            };
        public FormDoctor(string connectionPassword, string username, int userId)
        {
            this.username = username;
            this.userId = userId;
            this.connectionPassword = connectionPassword;
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            panelDisplay.Visible = true;
            panelDisplay.BringToFront();
            panelCreate.SendToBack();
            comboBoxType.DataSource = examinations;
            comboBoxType.DisplayMember = "Name";

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

            comboBoxTimePicker.DropDownStyle = ComboBoxStyle.DropDownList;

            DateTime startTime = DateTime.Today.AddHours(6);
            DateTime endTime = DateTime.Today.AddHours(18);

            while (startTime <= endTime)
            {
                comboBoxTimePicker.Items.Add(startTime.ToString("HH:mm"));
                startTime = startTime.AddMinutes(30);
            }

            comboBoxTimePicker.SelectedIndex = 0;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (listBoxPacients.SelectedIndex == -1)
            {
                MessageBox.Show("Prvni vyberte pacienta");
            }
            FormAddRecord addRecord = new FormAddRecord(connectionPassword, pacients[listBoxPacients.SelectedIndex].Id, pacients[listBoxPacients.SelectedIndex].Name, userId, examinations);
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

        private void buttonCreateAppointment_Click(object sender, EventArgs e)
        {
            if (buttonCreateAppointment.Text == "Vytvořit Schůzku")
            {
                panelCreate.BringToFront();
                panelDisplay.SendToBack();
                panelDisplay.Visible = false;
                buttonCreateAppointment.Text = "Zobrazit Schůzky";
            }
            else
            {
                panelDisplay.Visible = true;
                panelDisplay.BringToFront();
                panelCreate.SendToBack();
                buttonCreateAppointment.Text = "Vytvořit Schůzku";
            }
        }

        private void listBoxPacients_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelChosenPatient.Text = pacients[listBoxPacients.SelectedIndex].Name;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            DateTime examDate = monthCalendarExamDate.SelectionStart;
            if (examDate == null)
            {
                MessageBox.Show("Select a date");
                return;
            }
            if (comboBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte vyšetření");
                return;
            }
            if (comboBoxTimePicker.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte čas");
                return;
            }
            TimeSpan time = TimeSpan.Parse(comboBoxTimePicker.Text.ToString());
            DateTime finDate = examDate + time;

            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            string sqlQuery = "INSERT INTO dbo.appointments (appointment_date, examination_type, patient_id, doctor_id) " +
                          "VALUES (@Date, @Type, @Patient_Id, @Doctor_Id)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Date", finDate);
                    command.Parameters.AddWithValue("@Type", comboBoxType.Text);
                    command.Parameters.AddWithValue("@Patient_Id", pacients[listBoxPacients.SelectedIndex].Id);
                    command.Parameters.AddWithValue("@Doctor_Id", userId);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Schůzka úspěšně vytvořena", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxType.SelectedIndex = -1;
            comboBoxTimePicker.SelectedIndex = -1;
            labelChosenPatient.Text = "ŽÁDNÝ";
        }
    }
}

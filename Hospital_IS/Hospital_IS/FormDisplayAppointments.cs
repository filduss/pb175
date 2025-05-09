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
    public partial class FormDisplayAppointments: Form
    {
        string connectionPassword = null;
        private int patientId;
        public FormDisplayAppointments(string connectionPassword, int patientId)
        {
            InitializeComponent();
            this.connectionPassword = connectionPassword;
            this.patientId = patientId;
        }

        private void FormDisplayAppointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments(string filter = "")
        {
            List<AppointmentInfo> appointments = new List<AppointmentInfo>();
            string connectionString = string.Format(
                "Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;",
                connectionPassword);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                            SELECT a.appointment_date, a.examination_type, d.Username AS DoctorName
                            FROM dbo.appointments a
                            JOIN dbo.doctors d ON a.doctor_id = d.Id
                            WHERE a.patient_id = @PatientId";

                if (!string.IsNullOrWhiteSpace(filter))
                {
                    query += " AND LTRIM(RTRIM(LOWER(a.examination_type))) = @Filter";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    if (!string.IsNullOrWhiteSpace(filter))
                        command.Parameters.AddWithValue("@Filter", filter);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new AppointmentInfo
                            {
                                ExaminationDate = reader.GetDateTime(0),
                                ExaminationType = reader.GetString(1),
                                DoctorName = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            appointments = appointments.OrderBy(a => a.ExaminationDate).ToList();
            DisplayAppointments(appointments);
        }

        private void DisplayAppointments(List<AppointmentInfo> appointments)
        {
            flowLayoutPanelAppointments.Controls.Clear();

            foreach (var appt in appointments)
            {
                Panel panel = new Panel
                {
                    Size = new Size(490, 80),
                    Margin = new Padding(5, 3, 5, 3),
                    BackColor = Color.LightBlue
                };

                Label labelDate = new Label
                {
                    Text = appt.ExaminationDate.ToString("dd.MM.yyyy"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(15, 10),
                    AutoSize = true
                };

                Label labelTime = new Label
                {
                    Text = appt.ExaminationDate.ToString("HH:mm"),
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Location = new Point(15, 35),
                    AutoSize = true
                };

                Label labelType = new Label
                {
                    Text = appt.ExaminationType,
                    Font = new Font("Segoe UI", 11),
                    Location = new Point(120, 25),
                    AutoSize = true
                };

                Label labelDoctor = new Label
                {
                    Text = "Lékař: " + appt.DoctorName,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Location = new Point(120, 50),
                    AutoSize = true
                };

                panel.Controls.Add(labelDate);
                panel.Controls.Add(labelTime);
                panel.Controls.Add(labelType);
                panel.Controls.Add(labelDoctor);

                flowLayoutPanelAppointments.Controls.Add(panel);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedIndex == 0)
            {
                LoadAppointments();
                return;
            }
            string filter = comboBoxSearch.SelectedItem?.ToString()?.Trim().ToLower();
            LoadAppointments(filter);
        }
    }

    public class AppointmentInfo
    {
        public DateTime ExaminationDate { get; set; }
        public string ExaminationType { get; set; }
        public string DoctorName { get; set; }
    }
}

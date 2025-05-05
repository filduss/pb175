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

            DisplayAppointments(appointments);
        }

        private void DisplayAppointments(List<AppointmentInfo> appointments)
        {
            flowLayoutPanelAppointments.Controls.Clear();

            foreach (var appt in appointments)
            {
                Panel panel = new Panel();
                panel.Size = new Size(500, 80);
                panel.BackColor = Color.LightBlue;

                Label labelDate = new Label();
                labelDate.Text = appt.ExaminationDate.ToShortDateString();
                labelDate.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                labelDate.Location = new Point(10, 10);
                labelDate.AutoSize = true;

                Label labelType = new Label();
                labelType.Text = appt.ExaminationType;
                labelType.Location = new Point(10, 30);
                labelType.AutoSize = true;

                Label labelDoctor = new Label();
                labelDoctor.Text = "Lékař: " + appt.DoctorName;
                labelDoctor.Location = new Point(10, 50);
                labelDoctor.AutoSize = true;

                panel.Controls.Add(labelDate);
                panel.Controls.Add(labelType);
                panel.Controls.Add(labelDoctor);

                flowLayoutPanelAppointments.Controls.Add(panel);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
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

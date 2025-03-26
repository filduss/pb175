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
    public partial class FormMedicalRecords: Form
    {
        private string connectionPassword;
        private int patientId;
        public FormMedicalRecords(string connectionPassword, int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.connectionPassword = connectionPassword;
        }

        private List<MedicalRecordBasicInfo> records = new List<MedicalRecordBasicInfo>();

        private void FormMedicalRecords_Load(object sender, EventArgs e)
        {
            string connectionString = string.Format(
        "Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password={0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;",
        connectionPassword);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT mr.Id, d.UserName AS DoctorName, mr.RecordDate, mr.RecordText, mr.RecordType
                                FROM dbo.health_records mr
                                JOIN dbo.doctors d ON mr.DoctorId = d.Id
                                WHERE mr.PatientId = @PatientId
                                ORDER BY mr.RecordDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string doctor = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            string text = reader.GetString(3);
                            string rec_type = reader.GetString(4);

                            string summary = $"{date.ToShortDateString()} – {doctor}";
                            MedicalRecordBasicInfo record = new MedicalRecordBasicInfo(id, summary, text, rec_type);
                            records.Add(record);
                        }
                    }
                }
            }

            listBoxRecords.DataSource = records;
            listBoxRecords.DisplayMember = "Summary";
        }

        private void listBoxRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecords.SelectedItem is MedicalRecordBasicInfo selected)
            {
                textBoxDetail.Text = selected.FullText;
                textBoxRecType.Text = selected.RecType;
            }
        }
    }
}

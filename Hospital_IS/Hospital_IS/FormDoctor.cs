﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
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
        private Dictionary<System.Windows.Forms.CheckBox, Panel> groupMap;
        private List<System.Windows.Forms.Label> leftLabels;
        private List<Appointment> queueToday1 = new List<Appointment>();
        private List<Appointment> queueToday2 = new List<Appointment>();
        private List<Appointment> queueToday3 = new List<Appointment>();
        private List<Appointment> queueToday4 = new List<Appointment>();
        private List<Appointment> queueToday5 = new List<Appointment>();
        private List<List<Appointment>> appointmentQueues;
        private List<Appointment> newAppointments = new List<Appointment>();
        List<System.Windows.Forms.Label> dateLabels = new List<System.Windows.Forms.Label>();
        public FormDoctor(string connectionPassword, string username, int userId)
        {
            this.username = username;
            this.userId = userId;
            this.connectionPassword = connectionPassword;
            InitializeComponent();


            groupMap = new Dictionary<System.Windows.Forms.CheckBox, Panel>
            {
                { checkBoxToday1Type, panelToday1Next },
                { checkBoxToday2Type, panelToday2Next },
                { checkBoxToday3Type, panelToday3Next },
                { checkBoxToday4Type, panelToday4Next },
                { checkBoxToday5Type, panelToday5Next }
            };

            leftLabels = new List<System.Windows.Forms.Label>
            {
                labelAppLeft1, labelAppLeft2, labelAppLeft3, labelAppLeft4, labelAppLeft5
            };
        }

        private void deleteAppointment(Appointment appointment)
        {
            string deleteQuery = @"
                DELETE FROM dbo.appointments 
                WHERE 
                    appointment_date = @Date AND 
                    examination_type = @Type AND 
                    patient_id = @PatientId AND 
                    doctor_id = @DoctorId";
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Date", appointment.date);
                    deleteCommand.Parameters.AddWithValue("@Type", appointment.type);
                    deleteCommand.Parameters.AddWithValue("@PatientId", appointment.patient_id);
                    deleteCommand.Parameters.AddWithValue("@DoctorId", userId);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Appointment deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No appointment found to delete.");
                    }
                }
            }

        }

        private void EventChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox clickedCheckBox = sender as System.Windows.Forms.CheckBox;
            if (!clickedCheckBox.Checked)
            {
                return;
            }
            Debug.WriteLine(clickedCheckBox.Name);
            Panel relatedPanel = groupMap[clickedCheckBox];

            // 14. char is number garanted
            string name = Convert.ToString(clickedCheckBox.Name);
            int choice = int.Parse(name[13].ToString());
            choice--;

            Debug.WriteLine(appointmentQueues[choice].Count);

            clickedCheckBox.Checked = false;

            if (appointmentQueues[choice].Count == 0)
            {
                return;
            }

            //DEBUG PRINTS
            for (int i = 0; i < 5; i++)
            {
                List<Appointment> queuel = appointmentQueues[i];
                Debug.WriteLine($"--**-- {queuel.Count}, its: {i} th queue");
                foreach (var elem in queuel)
                {
                    Debug.WriteLine(elem.type);
                }
            }

            deleteAppointment(appointmentQueues[choice][0]);
            appointmentQueues[choice].RemoveAt(0);

            if (appointmentQueues[choice].Count == 0)
            {
                Appointment empty = new Appointment(DateTime.Today, "", -1);
                changeText(empty, relatedPanel);
            }
            else
            {
                Appointment newDisplayAppointment = appointmentQueues[choice][0];
                changeText(newDisplayAppointment, relatedPanel);
            }

            List<System.Windows.Forms.Label> leftLabels = new List<System.Windows.Forms.Label>
            {
                labelAppLeft1, labelAppLeft2, labelAppLeft3, labelAppLeft4, labelAppLeft5
            };

            leftLabels[choice].Text = appointmentQueues[choice].Count.ToString();

        }

        private void changeText(Appointment appointment, Panel relatedPanel)
        {
            string patientName = "";
            for (int i = 0; i < pacients.Count; i++)
            {
                if (pacients[i].Id == appointment.patient_id)
                {
                    patientName = pacients[i].Name;
                    break;
                }
            }

            Debug.WriteLine($"{appointment.patient_id} + {appointment.type} :)");
            string appointmentDate = appointment.date.ToString();
            if (appointment.patient_id == -1)
            {
                appointmentDate = "";
            }
            foreach (Control control in relatedPanel.Controls)
            {
                if (control is System.Windows.Forms.Label)
                {
                    string controlTag = Convert.ToString(control.Tag);

                    if (controlTag == "TodayName")
                    {
                        control.Text = patientName;
                    }
                    else if (controlTag == "TodayTime")
                    {
                        control.Text = appointmentDate;
                    }
                }
                else if (control is System.Windows.Forms.CheckBox)
                {
                    control.Text = appointment.type;
                }
            }
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            string connectionString = string.Format("Server=tcp:pb175database.database.windows.net,1433;Initial Catalog=pb175database;Persist Security Info=False;User ID=pb175admin;Password= {0};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;", connectionPassword);
            checkBoxToday1Type.CheckedChanged += EventChanged;
            checkBoxToday2Type.CheckedChanged += EventChanged;
            checkBoxToday3Type.CheckedChanged += EventChanged;
            checkBoxToday4Type.CheckedChanged += EventChanged;
            checkBoxToday5Type.CheckedChanged += EventChanged;

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

            appointmentQueues = new List<List<Appointment>>
            {
                queueToday1, queueToday2, queueToday3, queueToday4, queueToday5
            };

            dateLabels = new List<System.Windows.Forms.Label>
            {
                labelDate1, labelDate2, labelDate3, labelDate4, labelDate5
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                List<Appointment> appointments = new List<Appointment>();
                string query = $"SELECT Id, appointment_date, examination_type, patient_id FROM dbo.appointments WHERE doctor_id = {userId} ORDER BY appointment_date ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment(reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3));
                            appointments.Add(appointment);                            
                        }
                    }
                    enqueueAppointments(appointments);
                }
                
            }

            panelDisplay.Visible = true;
            panelDisplay.BringToFront();
            panelCreate.SendToBack();
            comboBoxType.DataSource = examinations;
            comboBoxType.DisplayMember = "Name";

            labelDoctor.Text = username;

            comboBoxTimePicker.DropDownStyle = ComboBoxStyle.DropDownList;

            DateTime startTime = DateTime.Today.AddHours(6);
            DateTime endTime = DateTime.Today.AddHours(18);

            while (startTime <= endTime)
            {
                comboBoxTimePicker.Items.Add(startTime.ToString("HH:mm"));
                startTime = startTime.AddMinutes(30);
            }

            List<System.Windows.Forms.Label> leftLabels = new List<System.Windows.Forms.Label>
            {
                labelAppLeft1, labelAppLeft2, labelAppLeft3, labelAppLeft4, labelAppLeft5
            };

            for (int i = 0; i < 5; i++)
            {
                leftLabels[i].Text = appointmentQueues[i].Count.ToString();
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
                enqueueAppointments(newAppointments);
                newAppointments.Clear();
                for (int i = 0; i < 5; i++)
                {
                    leftLabels[i].Text = appointmentQueues[i].Count.ToString();
                }
            }
        }

        private void enqueueAppointments(List<Appointment> appointments)
        {
            List<System.Windows.Forms.CheckBox> checkBoxes = new List<System.Windows.Forms.CheckBox>{ checkBoxToday1Type, checkBoxToday2Type, checkBoxToday3Type, checkBoxToday4Type, checkBoxToday5Type};

            DateTime target = DateTime.Today;
            for (int i = 0; i < 5; i++)
            {
                List<Appointment> currentQueue = appointmentQueues[i];
                dateLabels[i].Text = $"{target.Day}.{target.Month}.{target.Year}";
                foreach (Appointment elem in appointments)
                {
                    if (elem.date.Day == target.Day)
                    {
                        if (currentQueue.Count == 0)
                        {
                            changeText(elem, groupMap[checkBoxes[i]]);
                        }
                        currentQueue.Add(elem);
                    }
                }

                if (target.DayOfWeek == DayOfWeek.Friday)
                {
                    target = target.AddDays(2);
                }
                
                target = target.AddDays(1);
            }
        }

        private void listBoxPacients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPacients.SelectedIndex == -1)
            {
                return;
            }
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
            Appointment appointment = new Appointment(finDate, comboBoxType.Text, pacients[listBoxPacients.SelectedIndex].Id);
            newAppointments.Add(appointment);
            MessageBox.Show("Schůzka úspěšně vytvořena", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxType.SelectedIndex = -1;
            listBoxPacients.SelectedIndex = -1;
            comboBoxTimePicker.SelectedIndex = -1;
            labelChosenPatient.Text = "ŽÁDNÝ";
        }
    }
    class Appointment
    {
        public DateTime date;
        public string type;
        public int patient_id;
        public Appointment(DateTime date, string type, int patient_id)
        {
            this.date = date;
            this.type = type;
            this.patient_id = patient_id;
        }

    }
}

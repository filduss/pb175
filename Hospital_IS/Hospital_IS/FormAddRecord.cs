using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddRecord : Form
    {
        private string connectionPassword;
        private int pacientId;
        public FormAddRecord(string connectionPassword, int pacientId)
        {
            this.connectionPassword = connectionPassword;
            this.pacientId = pacientId;
            InitializeComponent();
        }
        public class Examination
        {
            public string Category { get; set; }
            public string Name { get; set; }

            public Examination(string category, string name)
            {
                Category = category;
                Name = name;
            }
        }

        private void FormAddRecord_Load(object sender, EventArgs e)
        {
            List<Examination> examinations = new List<Examination>
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

            comboBoxExaminations.DataSource = examinations;
            comboBoxExaminations.DisplayMember = "Name";

        }
    }
}

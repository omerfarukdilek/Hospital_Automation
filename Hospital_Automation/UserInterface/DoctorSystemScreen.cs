using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Management;
using Entities;

namespace UserInterface
{
    public partial class DoctorSystemScreen : Form
    {
        AppointmentManagement appointmentManagement;
        ExaminationManagement examinationManagement;
        DatabaseContext database;
        public int doctorId { get; set; }

        public DoctorSystemScreen()
        {
            InitializeComponent();
            appointmentManagement = new AppointmentManagement();
            examinationManagement = new ExaminationManagement();
            database = new DatabaseContext();
        }

        private void DoctorSystemScreen_Load(object sender, EventArgs e)
        {
            ListForDoctorSystem(DateTime.Today,2);
        }

        private void dtPickerWorkingDate_ValueChanged(object sender, EventArgs e)
        {
            ListForDoctorSystem(DateTime.Today, doctorId);
        }
        private void btnCreateInspection_Click(object sender, EventArgs e)
        {
            int appointmentId = Convert.ToInt32(dtGridViewDoctorAppointmentScreen.CurrentRow.Cells[0].Value);
            int patientId = Convert.ToInt32(dtGridViewDoctorAppointmentScreen.CurrentRow.Cells[1].Value);

            Examination examination = new Examination
            {
                AppointmentId=appointmentId,
                Status=true
            };
            examinationManagement.AddExamination(examination);

            DoctorExaminationSystem doctorInspectionSystem = new DoctorExaminationSystem();

            doctorInspectionSystem.GetAppointmentId = appointmentId;
            doctorInspectionSystem.GetPatientId = patientId;

            doctorInspectionSystem.Show();
        }


        public void ListForDoctorSystem(DateTime date,int doctorId)
        {
            var result = from a in database.Appointments
                         where  a.DoctorWorkingHour.Date == date && a.DoctorWorkingHour.DoctorId == doctorId
                         select new
                         {
                             RandevuNumarası = a.AppointmentId,
                             HastaNo=a.PatientId,
                             HastaAdSoyad = a.Patient.FirstName + " " + a.Patient.LastName,
                             DogumTarihi = a.Patient.BirthDate,
                             MuayeneTarihi = a.DoctorWorkingHour.Date,
                             MuayeneSaati = a.DoctorWorkingHour.Hour,

                         };
            dtGridViewDoctorAppointmentScreen.DataSource = result.ToList();

        }
    }
}

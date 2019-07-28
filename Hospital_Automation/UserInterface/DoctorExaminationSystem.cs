using DataAccess;
using DataAccess.Management;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class DoctorExaminationSystem : Form
    {
        //--------------------------Instance---------------------------------//
        DatabaseContext database;
        ExaminationManagement examinationManagement;

        //--------------------------Property---------------------------------//

        public string Analysis { get; set; }
        public int GetPatientId { get; set; }
        public int GetAppointmentId { get; set; }

        public DoctorExaminationSystem()
        {
            InitializeComponent();
            database = new DatabaseContext();
            examinationManagement = new ExaminationManagement();
        }


        private void BtnNotCreateInspection_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination
            {
                AppointmentId = GetAppointmentId,
                Status = false

            };
            examinationManagement.UpdateExamination(examination);

            DoctorSystemScreen doctorSystemScreen = new DoctorSystemScreen();
            doctorSystemScreen.Show();
            this.Hide();
        }

        private void btnSearchDiagnosis_Click(object sender, EventArgs e)
        {
            SearchDiagnosis(txtDiagnosisSearch.Text);

        }//Bakma     

        private void btnAnalysisRequest_Click(object sender, EventArgs e)
        {
            Analysis analysis = new Analysis();
            analysis.Show();
        }//Bakma

        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            PrescriptionSystem prescriptionSystem = new PrescriptionSystem();
            prescriptionSystem.Show();
        }//Bakma

        private void DoctorExaminationSystem_Load(object sender, EventArgs e)
        {
        }

        private void SearchDiagnosis(string diagnosis)
        {
            var result = from d in database.Diagnosis
                          where d.DiagnosisName.Contains(diagnosis)
                         select new
                         {
                            No= d.DiagnosisId,
                            Teshis= d.DiagnosisName
                         };
                          
            dtDiagnosis.DataSource = result.ToList();

        }//Bakma//Teşhis Bulma

        private void btnExaminationSearch_Click(object sender, EventArgs e)
        {
            var result = from ex in database.Examinations 
                         where ex.AppointmentId==GetAppointmentId
                         select new
                         {
                             Muayene_No=ex.ExaminationId,
                             Randevu_No=ex.AppointmentId,
                             Durum=ex.Status,
                             Teshis=ex.Diagnosis,
                             Tahlil=ex.Test
                         };
            dtExaminationView.DataSource = result.ToList();
        }

        private void btnInspenctionResult_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination
            {
                AppointmentId = GetAppointmentId,
                Diagnosis = dtDiagnosis.CurrentRow.Cells[1].Value.ToString(),
                Test=Analysis
            };

            examinationManagement.UpdateExamination(examination);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show();
        }
    }
}

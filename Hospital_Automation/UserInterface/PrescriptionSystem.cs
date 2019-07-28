using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Management;
using Entities;

namespace UserInterface
{
    public partial class PrescriptionSystem : Form
    {
        PrescriptionManagement prescriptionManagement;
        public int GetPatientId { get; set; }
        public PrescriptionSystem()
        {
            InitializeComponent();
            prescriptionManagement = new PrescriptionManagement();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            lstDrugs.Items.Add(txtDrug.Text.Trim());
            txtDrug.Clear();

        }

        private void btnPrescriptonAdd_Click(object sender, EventArgs e)
        {
            string drugs=string.Empty;
            foreach (var item in lstDrugs.Items)
            {
                drugs += item+",";
            }
            Prescription prescription = new Prescription
            {
                PatientId = 2,
                PrescriptionDate=DateTime.Now,
                Drugs=drugs               

            };
            var result=prescriptionManagement.AddPrescription(prescription);
            lstDrugs.Items.Clear();

        }
    }
}

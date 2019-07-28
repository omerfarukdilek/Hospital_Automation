using DataAccess;
using DataAccess.Management;
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
    public partial class PharmacistSystemScreen : Form
    {
        PharmacistManagement pharmacistManagement;
        PrescriptionManagement prescriptionManagement;
        DatabaseContext database;

        public int getPharmacistId { get; set; }

        public PharmacistSystemScreen()
        {
            InitializeComponent();
            pharmacistManagement = new PharmacistManagement();
            prescriptionManagement = new PrescriptionManagement();
            database = new DatabaseContext();
        }

        private void btnSearchRecipe_Click(object sender, EventArgs e)
        {
            
            ListForRecipe();
            
        }

        public void ListForRecipe()
        {
            if (txtRecipeSearch.Text != null)
            {
                var prescriptionListId = txtRecipeSearch.Text;
                int selectedPrescriptionId = Convert.ToInt32(prescriptionListId);
                var result = (from p in database.Prescriptions
                              .Where(p => p.PrescriptionId == selectedPrescriptionId)
                              select new
                              {
                                  ReçeteNumarası = p.PrescriptionId,
                                  İlaçAdı = p.Drugs,
                                  ReçeteOluşturmaTarihi = p.PrescriptionDate
                              }
                              ).ToList();
                DtGridViewListPrescription.DataSource = result;

            }
            else
            {
                MessageBox.Show("Lütfen reçete numarası giriniz.");
            }
        }

        private void btnRecipeDelete_Click(object sender, EventArgs e)
        {
            if (txtRecipeSearch.Text != null)
            {
                txtRecipeSearch.Text = null;                
            }

            if (DtGridViewListPrescription.DataSource != null)
            {
                DtGridViewListPrescription.DataSource = null;
            }
            if (dtGridViewRecipeList.DataSource != null)
            {
                dtGridViewRecipeList.DataSource = null;
            }
        }

        private void btnOldRecipes_Click(object sender, EventArgs e)
        {
            var prescriptionListId = txtRecipeSearch.Text;
            int selectedPrescriptionId = Convert.ToInt32(prescriptionListId);
            var result = (from p in database.Prescriptions
                          .Where(p=>p.PatientId==selectedPrescriptionId)
                          select new
                          {
                              ReçeteNumarası = p.PrescriptionId,
                              İlaçAdı = p.Drugs,
                              ReçeteOluşturmaTarihi = p.PrescriptionDate
                          }
                          ).ToList();
            dtGridViewRecipeList.DataSource = result;

        }
    }
}

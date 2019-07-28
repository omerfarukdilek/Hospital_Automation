using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class PrescriptionManagement
    {
        DatabaseContext database;
        public PrescriptionManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPrescription(Prescription p)
        {
            try
            {
                database.Prescriptions.Add(p);
                database.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public void RemovePrescription(Prescription p)
        {
            if (p.PrescriptionId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPrescription = database.Prescriptions.FirstOrDefault(x => x.PrescriptionId == p.PrescriptionId);
                if (selectedPrescription == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show($"{p.PrescriptionId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Reçete Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Prescriptions.Remove(selectedPrescription);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdatePrescription(Prescription p)
        {
            Prescription updatedPrescription = database.Prescriptions.FirstOrDefault(x => x.PrescriptionId == p.PrescriptionId);
            
            database.Entry(updatedPrescription).CurrentValues.SetValues(updatedPrescription);
            database.Entry(updatedPrescription).State = EntityState.Modified;
        }

        public List<Prescription> ListPrescription()
        {
            return database.Prescriptions.ToList();
        }

        public Prescription PrescriptionQuery(int prescriptionId)
        {
           var result= database.Prescriptions.SingleOrDefault(x => x.PrescriptionId == prescriptionId);
            return result;
        }
    }
}

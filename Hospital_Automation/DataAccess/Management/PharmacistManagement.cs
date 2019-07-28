using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class PharmacistManagement
    {
        DatabaseContext database;
        public PharmacistManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPharmacist(Pharmacist p)
        {
            try
            {
                database.Pharmacists.Add(p);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemovePharmacist(Pharmacist p)
        {
            if (p.PharmacistId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPharmacist = database.Pharmacists.FirstOrDefault(x => x.PharmacistId == p.PharmacistId);
                if (selectedPharmacist == null)
                {

                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show($"{p.PharmacistId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Eczacı Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Pharmacists.Remove(selectedPharmacist);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdatePharmacist(Pharmacist p)
        {
            Pharmacist updatedPharmacist = database.Pharmacists.FirstOrDefault(X => X.PharmacistId == p.PharmacistId);

            database.Entry(updatedPharmacist).CurrentValues.SetValues(updatedPharmacist);
            database.Entry(updatedPharmacist).State = EntityState.Modified;

        }

        public List<Pharmacist> ListPharmacist()
        {
            return database.Pharmacists.ToList();
        }



    }
}

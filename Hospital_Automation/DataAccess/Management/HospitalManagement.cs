using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class HospitalManagement
    {
        DatabaseContext database;
        public HospitalManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddHospital(Hospital h)
        {
            try
            {
                database.Hospitals.Add(h);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemoveHospital(Hospital h)
        {
            if (h.HospitalId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedHospital = database.Hospitals.FirstOrDefault(x => x.HospitalId == h.HospitalId);

                if (selectedHospital == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{h.HospitalId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Hastane Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Hospitals.Remove(selectedHospital);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdateHospital(Hospital h)
        {
            Hospital updatedHospital = database.Hospitals.FirstOrDefault(x => x.HospitalId == h.HospitalId);

            database.Entry(updatedHospital).CurrentValues.SetValues(updatedHospital);
            database.Entry(updatedHospital).State = EntityState.Modified;

        }

        public List<Hospital> ListHospital()
        {
            return database.Hospitals.ToList();
        }
    }
}

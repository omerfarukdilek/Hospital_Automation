using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class PolyclinicManagement
    {
        DatabaseContext database;
        public PolyclinicManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPolyclinic(Polyclinic p)
        {
            try
            {
                database.Polyclinics.Add(p);
                database.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }


        public void RemovePolyclinic(Polyclinic p)
        {
            if (p.PolyclinicId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPolyclinic = database.Polyclinics.FirstOrDefault(x => x.PolyclinicId == p.PolyclinicId);

                if (selectedPolyclinic == null)
                {

                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{p.PolyclinicId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Poliklinik Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Polyclinics.Remove(selectedPolyclinic);
                        database.SaveChanges();
                    }
                }
            }
        }


        public void UpdatePolyclinic(Polyclinic p)
        {
            Polyclinic updatedPloyclinic = database.Polyclinics.FirstOrDefault(x => x.PolyclinicId == p.PolyclinicId);

            database.Entry(updatedPloyclinic).CurrentValues.SetValues(updatedPloyclinic);
            database.Entry(updatedPloyclinic).State = EntityState.Modified;

        }

        public List<Polyclinic> ListPolyclinic()
        {
            return database.Polyclinics.ToList();
        }


    }
}

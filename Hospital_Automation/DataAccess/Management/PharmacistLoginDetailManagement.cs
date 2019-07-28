using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public class PharmacistLoginDetailManagement
    {
        DatabaseContext database;
        public PharmacistLoginDetailManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPharmacistLoginDetail(PharmacistLoginDetail pl)
        {
            PharmacistLoginDetail pld;
            try
            {
                pld = database.PharmacistLoginDetails.Add(pl);
                database.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
              
            }
        }

        public void RemovePharmacistLoginDetail(PharmacistLoginDetail pl)
        {
            if (pl.PharmacistId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPharmacistLoginDetail = database.PharmacistLoginDetails.FirstOrDefault(x => x.PharmacistId == pl.PharmacistId);
                if (selectedPharmacistLoginDetail == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{pl.PharmacistId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Eczacı Giriş Detayı Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.PharmacistLoginDetails.Remove(selectedPharmacistLoginDetail);
                        database.SaveChanges();
                    }
                }
            }
        
        }

        public void UpdatePharmacistLoginDetail(PharmacistLoginDetail pl)
        {
            PharmacistLoginDetail updatedPharmacistLoginDetail = database.PharmacistLoginDetails.FirstOrDefault(x => x.PharmacistId == pl.PharmacistId);

            database.Entry(updatedPharmacistLoginDetail).CurrentValues.SetValues(updatedPharmacistLoginDetail);
            database.Entry(updatedPharmacistLoginDetail).State = EntityState.Modified;

        }

        public List<PharmacistLoginDetail> ListPharmacistLoginDetail()
        {
            return database.PharmacistLoginDetails.ToList();
        }
        public PharmacistLoginDetail FindPharmacist(PharmacistLoginDetail pharmacist)
        {
                var result = database.PharmacistLoginDetails.SingleOrDefault(p => p.UserName == pharmacist.UserName && p.Password == pharmacist.Password);
            return result;
            //if (result==null)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;

            //}
         
        }


    }
}

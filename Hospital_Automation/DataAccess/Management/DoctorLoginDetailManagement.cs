
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Entities;

namespace DataAccess
{
    public class DoctorLoginDetailManagement
    {
        DatabaseContext database;
        public DoctorLoginDetailManagement()
        {
            database = new DatabaseContext();
        }


        public bool AddDoctorLoginDetail(DoctorLoginDetail dld)
        {
            DoctorLoginDetail dl;
            try
            {
                dl = database.DoctorLoginDetails.Add(dld);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemoveDoctorLoginDetail(DoctorLoginDetail dld)
        {
            if (dld.LoginDetailId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedDoctorLoginDetail = database.DoctorLoginDetails.FirstOrDefault(x => x.LoginDetailId == dld.LoginDetailId);
                if (selectedDoctorLoginDetail == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{dld.LoginDetailId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Doktor Giriş Detay Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.DoctorLoginDetails.Remove(selectedDoctorLoginDetail);
                        database.SaveChanges();
                    }
                }

            }
        }

        public void UpdateDoctorLoginDetail(DoctorLoginDetail dld)
        {
            DoctorLoginDetail updatedDoctorLoginDetail = database.DoctorLoginDetails.FirstOrDefault(x => x.LoginDetailId == dld.LoginDetailId);

            database.Entry(updatedDoctorLoginDetail).CurrentValues.SetValues(updatedDoctorLoginDetail);
            database.Entry(updatedDoctorLoginDetail).State = EntityState.Modified;

        }

        public List<DoctorLoginDetail> ListDoctorLoginDetail()
        {
            return database.DoctorLoginDetails.ToList();
        }
        public DoctorLoginDetail FindDoctor(DoctorLoginDetail doctor)
        {
            var result = database.DoctorLoginDetails.SingleOrDefault(d => d.UserName == doctor.UserName && d.Password == doctor.Password);
            return result;
        }


    }

}

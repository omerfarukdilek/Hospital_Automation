
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
    public class DoctorManagement
    {
        DatabaseContext database;
        public DoctorManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddDoctor(Doctor d)
        {
           
            try
            {
               database.Doctors.Add(d);
                database.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
                
            }  
        }

        public void RemoveDoctor(Doctor d)
        {
            if(d.DoctorId<=0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedDoctor = database.Doctors.FirstOrDefault(x => x.DoctorId == d.DoctorId);
                if(selectedDoctor==null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{d.DoctorId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Doktor Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Doctors.Remove(selectedDoctor);
                        database.SaveChanges();
                    }
                }
            }
        }


        public void UpdateDoctor(Doctor d)
        {
            Doctor updatedDoctor = database.Doctors.FirstOrDefault(x => x.DoctorId== d.DoctorId);

            database.Entry(updatedDoctor).CurrentValues.SetValues(updatedDoctor);
            database.Entry(updatedDoctor).State = EntityState.Modified;
        }

        public List<Doctor> ListDoctor()
        {
           return database.Doctors.ToList();
        }
    }
         
}

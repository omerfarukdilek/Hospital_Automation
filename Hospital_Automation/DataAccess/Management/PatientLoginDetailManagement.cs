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
    public class PatientLoginDetailManagement
    {
        DatabaseContext database;
        public PatientLoginDetailManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPatientLoginDetail(PatientLoginDetail pld)
        {
            try
            {
                database.PatientLoginDetails.Add(pld);
                database.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void RemovePatientLoginDetail(PatientLoginDetail pld)
        {
            if (pld.LoginDetailId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPatientLoginDetail = database.PatientLoginDetails.FirstOrDefault(x => x.LoginDetailId == pld.LoginDetailId);
                if (selectedPatientLoginDetail == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{pld.LoginDetailId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Hasta Giriş Detayı Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.PatientLoginDetails.Remove(selectedPatientLoginDetail);
                        database.SaveChanges();
                    }
                }
            }
        }


        public void UpdatePatientLoginDetail(PatientLoginDetail pld)
        {
            PatientLoginDetail updatedPatientLoginDetail = database.PatientLoginDetails.FirstOrDefault(x => x.LoginDetailId == pld.LoginDetailId);

            database.Entry(updatedPatientLoginDetail).CurrentValues.SetValues(updatedPatientLoginDetail);
            database.Entry(updatedPatientLoginDetail).State = EntityState.Modified;

        }

        public List<PatientLoginDetail> ListPatientLoginDetail()
        {
            return database.PatientLoginDetails.ToList();
        }
        public PatientLoginDetail FindPatient(PatientLoginDetail patient)
        {
            var result = database.PatientLoginDetails.SingleOrDefault(p => p.UserName == patient.UserName && p.Password == patient.Password);
            return result;

            //if (result == null)
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

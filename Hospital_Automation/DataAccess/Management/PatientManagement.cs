using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Entities;

namespace DataAccess
{
    public class PatientManagement
    {
        DatabaseContext database;
        public PatientManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddPatient(Patient p)
        {
            try
            {

                database.Patients.Add(p);
                database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public void RemovePatient(Patient p)
        {
            if (p.PatientId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedPatient = database.Patients.FirstOrDefault(x => x.PatientId == p.PatientId);
                if (selectedPatient == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{p.PatientId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Hasta Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Patients.Remove(selectedPatient);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdatePatient(Patient p)
        {
            Patient updatedPatient = database.Patients.FirstOrDefault(x => x.PatientId == p.PatientId);

            database.Entry(updatedPatient).CurrentValues.SetValues(updatedPatient);
            database.Entry(updatedPatient).State = EntityState.Modified;
        }

        public List<Patient> ListPatient()
        {
            return database.Patients.ToList();
        }
        public int SearchPatient(long tcNumber)
        {
            var result = database.Patients.SingleOrDefault(s=> s.TCNumber== tcNumber);
            return result.PatientId;
        }
        public Patient GetPatient(int patientId)
        {
            var result = database.Patients.SingleOrDefault(s => s.PatientId==patientId);
            return result;
        }

    }
}

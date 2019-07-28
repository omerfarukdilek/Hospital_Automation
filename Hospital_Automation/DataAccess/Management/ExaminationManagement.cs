using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class ExaminationManagement
    {
        DatabaseContext database;
        public ExaminationManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddExamination(Examination e)
        {
            try
            {
                database.Examinations.Add(e);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveExamination(Examination e)
        {
            if (e.ExaminationId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedExamination = database.Examinations.FirstOrDefault(x => x.ExaminationId == e.ExaminationId);
                if (selectedExamination == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{e.ExaminationId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Muayene Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Examinations.Remove(selectedExamination);
                        database.SaveChanges();
                    }
                }
            }

        }

        public void UpdateExamination(Examination e)
        {
            Examination updateExamination = database.Examinations.SingleOrDefault(x => x.AppointmentId == e.AppointmentId);
            updateExamination.AppointmentId = e.AppointmentId;
            updateExamination.Status = e.Status;

            database.Set<Examination>().Attach(updateExamination);
            var entry = database.Entry(updateExamination);
            entry.State = EntityState.Modified;
            database.SaveChanges();
            //database.Entry(updateExamination).CurrentValues.SetValues(e);
            //database.Entry(updateExamination).State = EntityState.Modified;
        }
        public List<Examination> ListExamination()
        {
            return database.Examinations.ToList();
        }
    }

}

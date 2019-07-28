using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class AppointmentManagement
    {

        DatabaseContext database;
        public AppointmentManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddAppointment(Appointment a)
        {
            try
            {
                database.Appointments.Add(a);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public void RemoveAppointment(Appointment a)
        {
            if (a.AppointmentId <= 0)
            {
                MessageBox.Show("Kayıt Silebilmek İçin Bir Kayıt Seçilmelidir..");
            }
            else
            {
                var selectedAppointment = database.Appointments.FirstOrDefault(x => x.AppointmentId == a.AppointmentId);

                if (selectedAppointment == null)
                {
                    MessageBox.Show("Silinebilecek bir kayıt bulunmadı...");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"{a.AppointmentId} Numaralı Kaydı Silmek İstediğinizden Emin Misiniz ?", "Randevu Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        database.Appointments.Remove(selectedAppointment);
                        database.SaveChanges();
                    }
                }
            }
        }

        public void UpdateAppointment(Appointment a)
        {
            Appointment updatedAppointment = database.Appointments.FirstOrDefault(x => x.AppointmentId == a.AppointmentId);

            database.Entry(updatedAppointment).CurrentValues.SetValues(updatedAppointment);
            database.Entry(updatedAppointment).State = EntityState.Modified;
        }

        public List<Appointment> ListAppointment()
        {
            return database.Appointments.ToList();
        }
    }
}

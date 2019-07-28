using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess.Management
{
    public class DoctorWorkingHourManagement
    {
        DatabaseContext database;
        public DoctorWorkingHourManagement()
        {
            database = new DatabaseContext();
        }

        public void UpdateWorkingHour(DoctorWorkingHour hour)
        { DoctorWorkingHour updateHour = database.DoctorWorkingHours.SingleOrDefault(h=> h.DoctorWorkingHourId==hour.DoctorWorkingHourId);
            updateHour.Status = hour.Status;

            database.Set<DoctorWorkingHour>().Attach(updateHour);
            var entry = database.Entry(updateHour);
            entry.State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}

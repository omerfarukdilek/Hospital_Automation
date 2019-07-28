using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DoctorWorkingHour
    {
        public int DoctorWorkingHourId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public bool Status { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual List<Appointment> Appointments { get; set; }

    }
}

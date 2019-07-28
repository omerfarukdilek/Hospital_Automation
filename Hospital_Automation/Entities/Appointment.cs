using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointment//Randevular
    {
        public int AppointmentId { get; set; }
        public int HospitalDetailId { get; set; }
        public int DoctorWorkingHourId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateOfAppointment { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual HospitalDetail HospitalDetails { get; set; }
        public virtual DoctorWorkingHour DoctorWorkingHour { get; set; }
        public virtual List<Examination> Examination { get; set; }

    }
}

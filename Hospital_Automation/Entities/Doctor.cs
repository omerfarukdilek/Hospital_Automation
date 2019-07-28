using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<DoctorLoginDetail> DoctorLoginDetails { get; set; }
        public virtual List<HospitalDetail> HospitalDetails { get; set; }
        public virtual List<DoctorWorkingHour> DoctorWorkingHours { get; set; }

    }
}

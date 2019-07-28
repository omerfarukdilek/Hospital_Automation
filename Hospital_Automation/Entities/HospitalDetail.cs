using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HospitalDetail
    {
        public int DetailId { get; set; }
        public int HospitalId { get; set; }
        public int PolyclinicId { get; set; }
        public int DepartmentId { get; set; }
        public int DoctorId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Polyclinic Polyclinic { get; set; }
        public virtual Department Department { get; set; }
        public  virtual Doctor Doctor { get; set; }
        public  virtual List<Appointment> Appointment { get; set; }

        
        


    }
}

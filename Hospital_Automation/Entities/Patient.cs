using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public long TCNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public virtual List<PatientLoginDetail> PatientLoginDetails { get; set; }
        public virtual List<Appointment> Appointment { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Prescription//Reçete
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public string Drugs { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public virtual Patient Patient{ get; set; }


    }
}

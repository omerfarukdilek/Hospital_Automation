using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Examination//Muayene Sonuçları
    {
        public int ExaminationId { get; set; }
        public int AppointmentId { get; set; }
        public bool Status { get; set; }//hastanın randevuya gelip gelmeme durumu
        public string Diagnosis { get; set; }//teşhis
        public string Test { get; set; }//tahlil

        public virtual Appointment Appointment { get; set; }

    }
}

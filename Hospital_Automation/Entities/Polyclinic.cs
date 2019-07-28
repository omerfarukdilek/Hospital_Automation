using System.Collections.Generic;

namespace Entities
{
    public class Polyclinic
    {
        public int PolyclinicId { get; set; }
        public string PolyclinicName { get; set; }
        public virtual List<HospitalDetail> HospitalDetails { get; set; }

    }
}

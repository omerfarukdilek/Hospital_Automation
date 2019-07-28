using System.Collections.Generic;

namespace Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual List<HospitalDetail> HospitalDetails { get; set; }

    }
}

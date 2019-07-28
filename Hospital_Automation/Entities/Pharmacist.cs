using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pharmacist
    {
        public int PharmacistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<PharmacistLoginDetail> PharmacistLoginDetails { get; set; }

    }
}

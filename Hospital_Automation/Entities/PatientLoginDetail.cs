using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PatientLoginDetail
    {
        public int LoginDetailId { get; set; }
        public int PatientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

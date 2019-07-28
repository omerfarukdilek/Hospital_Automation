using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DoctorLoginDetail
    {
        public int LoginDetailId { get; set; }
        public int DoctorId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}

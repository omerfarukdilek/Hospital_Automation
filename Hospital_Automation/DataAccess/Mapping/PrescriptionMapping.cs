using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class PrescriptionMapping: EntityTypeConfiguration<Prescription>
    {
        public PrescriptionMapping()
        {
            ToTable("Prescriptions");
            Property(p=> p.Drugs).IsRequired().HasColumnType("ntext");
            Property(p => p.PrescriptionDate).IsRequired().HasColumnType("datetime");
    }
    }
}

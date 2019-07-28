using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Mapping
{
    public class DiagnosisMapping : EntityTypeConfiguration<Diagnosis>
    {
        public DiagnosisMapping()
        {
            ToTable("Diagnosis");
            HasKey(d=> d.DiagnosisId);
            Property(d=> d.DiagnosisName).IsRequired().HasColumnType("nvarchar").IsMaxLength();
        }
    }
}

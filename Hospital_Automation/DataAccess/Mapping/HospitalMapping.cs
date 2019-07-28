using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class HospitalMapping : EntityTypeConfiguration<Hospital>
    {
        public HospitalMapping()
        {
            ToTable("Hospitals");
            Property(h => h.HospitalName).IsRequired().HasColumnType("nvarchar").HasMaxLength(90);

        }
    }
}

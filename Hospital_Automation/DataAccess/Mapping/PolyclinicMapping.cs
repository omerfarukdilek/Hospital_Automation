using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class PolyclinicMapping : EntityTypeConfiguration<Polyclinic>
    {
        public PolyclinicMapping()
        {
            ToTable("Polyclinic");
            Property(p => p.PolyclinicName).IsRequired().HasColumnType("nvarchar").HasMaxLength(90);
        }
    }
}

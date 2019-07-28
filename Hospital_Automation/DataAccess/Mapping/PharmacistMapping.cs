using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class PharmacistMapping : EntityTypeConfiguration<Pharmacist>
    {
        public PharmacistMapping()
        {
            ToTable("Pharmacists");
            HasKey(p => p.PharmacistId);
            Property(p => p.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(p => p.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }

    }
}

using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class PharmacistLoginDetailMapping : EntityTypeConfiguration<PharmacistLoginDetail>
    {
        public PharmacistLoginDetailMapping()
        {
            ToTable("PharmacistLoginDetails");
            HasKey(p => p.LoginDetailId);
            Property(p=> p.UserName).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(p=> p.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(16);
            Property(p=> p.Status).IsRequired().HasColumnType("bit");
            HasRequired(p=> p.Pharmacist).WithMany(p=> p.PharmacistLoginDetails).HasForeignKey(p=> p.PharmacistId);

        }
    }
}

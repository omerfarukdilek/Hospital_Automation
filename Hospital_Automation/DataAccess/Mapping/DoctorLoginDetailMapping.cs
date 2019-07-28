using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class DoctorLoginDetailMapping: EntityTypeConfiguration<DoctorLoginDetail>
    {
        public DoctorLoginDetailMapping()
        {
            ToTable("DoctorLoginDetails");
            HasKey(d => d.LoginDetailId);
            Property(d => d.UserName).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(d => d.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(16);
            Property(d => d.Status).IsRequired().HasColumnType("bit");
            HasRequired(d=> d.Doctor).WithMany(p => p.DoctorLoginDetails).HasForeignKey(p=> p.DoctorId);
        }
    }
}

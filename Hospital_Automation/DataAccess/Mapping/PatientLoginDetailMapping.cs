using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class PatientLoginDetailMapping : EntityTypeConfiguration<PatientLoginDetail>
    {
        public PatientLoginDetailMapping()
        {
            ToTable("PatientLoginDetails");
            HasKey(p => p.LoginDetailId);
            Property(p => p.UserName).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(p => p.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(16);
            Property(p => p.Status).IsRequired().HasColumnType("bit");
            HasRequired(p => p.Patient).WithMany(p => p.PatientLoginDetails).HasForeignKey(p=> p.PatientId);
        }
    }
}

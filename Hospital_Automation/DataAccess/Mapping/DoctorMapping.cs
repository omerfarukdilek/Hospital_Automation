using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class DoctorMapping : EntityTypeConfiguration<Doctor>
    {
        public DoctorMapping()
        {
            ToTable("Doctors");
            HasKey(d => d.DoctorId);
            Property(d => d.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(d => d.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            

        }
    }
}

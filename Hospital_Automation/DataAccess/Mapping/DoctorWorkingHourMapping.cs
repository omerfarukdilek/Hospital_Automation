using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class DoctorWorkingHourMapping: EntityTypeConfiguration<DoctorWorkingHour>
    {
        public DoctorWorkingHourMapping()
        {
            ToTable("DoctorWorkingHours");
            HasKey(d => d.DoctorWorkingHourId);
            Property(d=> d.Date).IsRequired().HasColumnType("datetime");
            Property(d => d.Hour).IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(d => d.Status).IsRequired().HasColumnType("bit");
            HasRequired(d => d.Doctor).WithMany(d => d.DoctorWorkingHours).HasForeignKey(d => d.DoctorId);
        }
    }


}

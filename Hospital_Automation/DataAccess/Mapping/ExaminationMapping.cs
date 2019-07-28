using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class ExaminationMapping : EntityTypeConfiguration<Examination>
    {
        public ExaminationMapping()//muayene
        {
            ToTable("Examinations");
            HasKey(e=> e.ExaminationId);
            Property(e=> e.Status).IsRequired().HasColumnType("bit");
            Property(e => e.Diagnosis).HasColumnType("nvarchar").HasMaxLength(90).IsOptional();
            Property(e => e.Test).HasColumnType("nvarchar").HasMaxLength(90).IsOptional();

            HasRequired(e=> e.Appointment).WithMany(e=> e.Examination).HasForeignKey(e=> e.AppointmentId);

        }
    }
}

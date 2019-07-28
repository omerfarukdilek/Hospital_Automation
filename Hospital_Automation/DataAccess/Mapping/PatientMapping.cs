using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DataAccess
{
    public class PatientMapping : EntityTypeConfiguration<Patient>
    {
        public PatientMapping()
        {
            ToTable("Patients");
            HasKey(p => p.PatientId);
            Property(p => p.TCNumber).IsRequired().HasColumnType("bigint");
            Property(p => p.FirstName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(p => p.LastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(p => p.BirthDate).IsRequired().HasColumnType("datetime");
            Property(p => p.Gender).IsRequired().HasColumnType("bit");
            Property(p => p.Phone).IsRequired().HasColumnType("nvarchar").HasMaxLength(11);
        }
    }
}

using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class HospitalDetailMapping : EntityTypeConfiguration<HospitalDetail>
    {
        public HospitalDetailMapping()
        {
            ToTable("HospitalDetails");
            HasKey(h => h.DetailId);
            HasRequired(h => h.Hospital).WithMany(h => h.HospitalDetails).HasForeignKey(h => h.HospitalId);
            HasRequired(h => h.Polyclinic).WithMany(h => h.HospitalDetails).HasForeignKey(h => h.PolyclinicId);
            HasRequired(h => h.Department).WithMany(h => h.HospitalDetails).HasForeignKey(h => h.DepartmentId);
            HasRequired(h => h.Doctor).WithMany(h => h.HospitalDetails).HasForeignKey(h => h.DoctorId);

           

        }
    }
}

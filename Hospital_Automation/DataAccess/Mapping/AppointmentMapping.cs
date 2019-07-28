using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Mapping
{
    public class AppointmentMapping : EntityTypeConfiguration<Appointment>
    {
        public AppointmentMapping()
        {
            ToTable("Appointments");
            HasKey(a=> a.AppointmentId);
            Property(a=> a.DateOfAppointment).IsRequired().HasColumnType("datetime2");
            HasRequired(a => a.HospitalDetails).WithMany(a=> a.Appointment).HasForeignKey(a=> a.HospitalDetailId);
            HasRequired(a => a.Patient).WithMany(a=> a.Appointment).HasForeignKey(a=> a.PatientId);
            HasRequired(a=> a.DoctorWorkingHour).WithMany(a=> a.Appointments).HasForeignKey(a=> a.DoctorWorkingHourId);         

                
        }
    }

}

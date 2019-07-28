using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Mapping;
using Entities;

namespace DataAccess
{
    public class DatabaseContext:DbContext
    {    //:base(@"Server=BK-LAB204-IS016;Database=HospitalAutomation;UID=sa;Password=123")
        //Server=BK-LAB204-IS003;
        //@"Data Source=BK-LAB204-IS003;Initial Catalog=HospitalAutomation;User ID=sa;Password=123"

        public DatabaseContext():base(@"Data Source=USER-PC;Initial Catalog=HospitalAutomation;Integrated Security=True;")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pharmacist> Pharmacists { get; set; }

        public DbSet<PatientLoginDetail> PatientLoginDetails { get; set; }
        public DbSet<DoctorLoginDetail> DoctorLoginDetails { get; set; }
        public DbSet<PharmacistLoginDetail> PharmacistLoginDetails { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Polyclinic> Polyclinics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HospitalDetail> HospitalDetails { get; set; }

        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<DoctorWorkingHour> DoctorWorkingHours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppointmentMapping());
            modelBuilder.Configurations.Add(new DepartmentMapping());
            modelBuilder.Configurations.Add(new DoctorLoginDetailMapping());
            modelBuilder.Configurations.Add(new DoctorMapping());
            modelBuilder.Configurations.Add(new ExaminationMapping());
            modelBuilder.Configurations.Add(new HospitalDetailMapping());
            modelBuilder.Configurations.Add(new HospitalMapping());
            modelBuilder.Configurations.Add(new PatientLoginDetailMapping());
            modelBuilder.Configurations.Add(new PatientMapping());
            modelBuilder.Configurations.Add(new PharmacistLoginDetailMapping());
            modelBuilder.Configurations.Add(new PharmacistMapping());
            modelBuilder.Configurations.Add(new PolyclinicMapping());
            modelBuilder.Configurations.Add(new PrescriptionMapping());
            modelBuilder.Configurations.Add(new DiagnosisMapping());
            modelBuilder.Configurations.Add(new DoctorWorkingHourMapping());
            base.OnModelCreating(modelBuilder);
        }

    }
}

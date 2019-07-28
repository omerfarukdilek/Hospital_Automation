namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        HospitalDetailId = c.Int(nullable: false),
                        DoctorsId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Hour = c.String(nullable: false, maxLength: 5),
                        DoctorWorkingHour_HourId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.DoctorWorkingHours", t => t.DoctorWorkingHour_HourId)
                .ForeignKey("dbo.Doctors", t => t.DoctorsId, cascadeDelete: true)
                .ForeignKey("dbo.HospitalDetails", t => t.HospitalDetailId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.HospitalDetailId)
                .Index(t => t.DoctorsId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorWorkingHour_HourId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorLoginDetails",
                c => new
                    {
                        LoginDetailId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 16),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoginDetailId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorWorkingHours",
                c => new
                    {
                        HourId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Hour = c.String(nullable: false, maxLength: 5),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HourId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.HospitalDetails",
                c => new
                    {
                        DetailId = c.Int(nullable: false, identity: true),
                        HospitalId = c.Int(nullable: false),
                        PolyclinicId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetailId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: false)
                .ForeignKey("dbo.Hospitals", t => t.HospitalId, cascadeDelete: true)
                .ForeignKey("dbo.Polyclinic", t => t.PolyclinicId, cascadeDelete: true)
                .Index(t => t.HospitalId)
                .Index(t => t.PolyclinicId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(nullable: false, maxLength: 90),
                    })
                .PrimaryKey(t => t.HospitalId);
            
            CreateTable(
                "dbo.Polyclinic",
                c => new
                    {
                        PolyclinicId = c.Int(nullable: false, identity: true),
                        PolyclinicName = c.String(nullable: false, maxLength: 90),
                    })
                .PrimaryKey(t => t.PolyclinicId);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        ExaminationId = c.Int(nullable: false, identity: true),
                        AppointmentId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Diagnosis = c.String(maxLength: 90),
                        Test = c.String(maxLength: 90),
                        PrescriptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExaminationId)
                .ForeignKey("dbo.Appointments", t => t.AppointmentId, cascadeDelete: true)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionId, cascadeDelete: true)
                .Index(t => t.AppointmentId)
                .Index(t => t.PrescriptionId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        Drugs = c.String(nullable: false, storeType: "ntext"),
                        PrescriptionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: false)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        TCNumber = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.PatientLoginDetails",
                c => new
                    {
                        LoginDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 16),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoginDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        DiagnosisId = c.Int(nullable: false, identity: true),
                        DiagnosisName = c.String(),
                    })
                .PrimaryKey(t => t.DiagnosisId);
            
            CreateTable(
                "dbo.PharmacistLoginDetails",
                c => new
                    {
                        LoginDetailId = c.Int(nullable: false, identity: true),
                        PharmacistId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 16),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoginDetailId)
                .ForeignKey("dbo.Pharmacists", t => t.PharmacistId, cascadeDelete: true)
                .Index(t => t.PharmacistId);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        PharmacistId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PharmacistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PharmacistLoginDetails", "PharmacistId", "dbo.Pharmacists");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "HospitalDetailId", "dbo.HospitalDetails");
            DropForeignKey("dbo.Examinations", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientLoginDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Examinations", "AppointmentId", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "DoctorsId", "dbo.Doctors");
            DropForeignKey("dbo.HospitalDetails", "PolyclinicId", "dbo.Polyclinic");
            DropForeignKey("dbo.HospitalDetails", "HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.HospitalDetails", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.HospitalDetails", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.DoctorWorkingHours", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "DoctorWorkingHour_HourId", "dbo.DoctorWorkingHours");
            DropForeignKey("dbo.DoctorLoginDetails", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.PharmacistLoginDetails", new[] { "PharmacistId" });
            DropIndex("dbo.PatientLoginDetails", new[] { "PatientId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.Examinations", new[] { "PrescriptionId" });
            DropIndex("dbo.Examinations", new[] { "AppointmentId" });
            DropIndex("dbo.HospitalDetails", new[] { "DoctorId" });
            DropIndex("dbo.HospitalDetails", new[] { "DepartmentId" });
            DropIndex("dbo.HospitalDetails", new[] { "PolyclinicId" });
            DropIndex("dbo.HospitalDetails", new[] { "HospitalId" });
            DropIndex("dbo.DoctorWorkingHours", new[] { "DoctorId" });
            DropIndex("dbo.DoctorLoginDetails", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "DoctorWorkingHour_HourId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "DoctorsId" });
            DropIndex("dbo.Appointments", new[] { "HospitalDetailId" });
            DropTable("dbo.Pharmacists");
            DropTable("dbo.PharmacistLoginDetails");
            DropTable("dbo.Diagnosis");
            DropTable("dbo.PatientLoginDetails");
            DropTable("dbo.Patients");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Examinations");
            DropTable("dbo.Polyclinic");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Departments");
            DropTable("dbo.HospitalDetails");
            DropTable("dbo.DoctorWorkingHours");
            DropTable("dbo.DoctorLoginDetails");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}

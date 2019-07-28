namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "DoctorsId", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "DoctorsId" });
            CreateTable(
                "dbo.DoctorWorkingHours",
                c => new
                    {
                        DoctorWorkingHourId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Hour = c.String(nullable: false, maxLength: 5),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorWorkingHourId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            AddColumn("dbo.Appointments", "DoctorWorkingHourId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "DateOfAppointment", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Diagnosis", "DiagnosisName", c => c.String(nullable: false, maxLength: 4000));
            CreateIndex("dbo.Appointments", "DoctorWorkingHourId");
            AddForeignKey("dbo.Appointments", "DoctorWorkingHourId", "dbo.DoctorWorkingHours", "DoctorWorkingHourId", cascadeDelete: true);
            DropColumn("dbo.Appointments", "DoctorsId");
            DropColumn("dbo.Appointments", "Date");
            DropColumn("dbo.Appointments", "Hour");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Hour", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Appointments", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Appointments", "DoctorsId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Appointments", "DoctorWorkingHourId", "dbo.DoctorWorkingHours");
            DropForeignKey("dbo.DoctorWorkingHours", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.DoctorWorkingHours", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "DoctorWorkingHourId" });
            AlterColumn("dbo.Diagnosis", "DiagnosisName", c => c.String());
            DropColumn("dbo.Appointments", "DateOfAppointment");
            DropColumn("dbo.Appointments", "DoctorWorkingHourId");
            DropTable("dbo.DoctorWorkingHours");
            CreateIndex("dbo.Appointments", "DoctorsId");
            AddForeignKey("dbo.Appointments", "DoctorsId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
        }
    }
}

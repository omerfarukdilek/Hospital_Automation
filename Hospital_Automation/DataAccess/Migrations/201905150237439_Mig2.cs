namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "DoctorWorkingHour_HourId", "dbo.DoctorWorkingHours");
            DropForeignKey("dbo.DoctorWorkingHours", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "DoctorWorkingHour_HourId" });
            DropIndex("dbo.DoctorWorkingHours", new[] { "DoctorId" });
            DropColumn("dbo.Appointments", "DoctorWorkingHour_HourId");
            DropTable("dbo.DoctorWorkingHours");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.HourId);
            
            AddColumn("dbo.Appointments", "DoctorWorkingHour_HourId", c => c.Int());
            CreateIndex("dbo.DoctorWorkingHours", "DoctorId");
            CreateIndex("dbo.Appointments", "DoctorWorkingHour_HourId");
            AddForeignKey("dbo.DoctorWorkingHours", "DoctorId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "DoctorWorkingHour_HourId", "dbo.DoctorWorkingHours", "HourId");
        }
    }
}

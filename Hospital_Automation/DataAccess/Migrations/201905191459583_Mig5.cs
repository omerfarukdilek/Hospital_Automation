namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Examinations", "PrescriptionId", "dbo.Prescriptions");
            DropIndex("dbo.Examinations", new[] { "PrescriptionId" });
            DropColumn("dbo.Examinations", "PrescriptionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Examinations", "PrescriptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Examinations", "PrescriptionId");
            AddForeignKey("dbo.Examinations", "PrescriptionId", "dbo.Prescriptions", "PrescriptionId", cascadeDelete: true);
        }
    }
}

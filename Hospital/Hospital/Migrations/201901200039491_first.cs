namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "Time", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ScheduleDoctors", "StartTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ScheduleDoctors", "FinishTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScheduleDoctors", "FinishTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ScheduleDoctors", "StartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Appointments", "Time", c => c.DateTime(nullable: false));
        }
    }
}

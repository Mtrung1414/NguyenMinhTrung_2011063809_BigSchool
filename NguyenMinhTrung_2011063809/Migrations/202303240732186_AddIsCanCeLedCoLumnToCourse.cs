namespace NguyenMinhTrung_2011063809.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanCeLedCoLumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}

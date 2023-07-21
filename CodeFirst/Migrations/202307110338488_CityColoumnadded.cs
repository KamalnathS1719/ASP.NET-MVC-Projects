namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityColoumnadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentDatas", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentDatas", "City");
        }
    }
}

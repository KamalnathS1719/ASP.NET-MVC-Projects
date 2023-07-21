namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDatas",
                c => new
                    {
                        StudID = c.Int(nullable: false, identity: true),
                        StudName = c.String(nullable: false),
                        StudAge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentDatas");
        }
    }
}

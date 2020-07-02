namespace CodeFirstDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sname = c.String(nullable: false),
                        Sbirth = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        DTB = c.Double(nullable: false),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculty", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "FacultyId", "dbo.Faculty");
            DropIndex("dbo.Student", new[] { "FacultyId" });
            DropTable("dbo.Student");
            DropTable("dbo.Faculty");
        }
    }
}

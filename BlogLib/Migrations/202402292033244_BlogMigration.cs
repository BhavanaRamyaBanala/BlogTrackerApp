namespace BlogLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminInfoes",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.BlogInfoes",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        DateOfCreation = c.DateTime(nullable: false),
                        BlogUrl = c.String(nullable: false),
                        EmpEmailId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.EmpInfoes",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        DateOfJoining = c.DateTime(nullable: false),
                        PassCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpInfoes");
            DropTable("dbo.BlogInfoes");
            DropTable("dbo.AdminInfoes");
        }
    }
}

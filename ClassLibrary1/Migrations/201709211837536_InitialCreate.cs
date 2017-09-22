namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 40),
                        FullName = c.String(maxLength: 50),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.FullName);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "FullName" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropTable("dbo.Users");
        }
    }
}

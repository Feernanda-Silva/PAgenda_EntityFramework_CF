namespace PAgenda_EntityFramework_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Telephones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        phone = c.String(),
                        mobile = c.String(),
                        name_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.name_name)
                .Index(t => t.name_name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telephones", "name_name", "dbo.People");
            DropIndex("dbo.Telephones", new[] { "name_name" });
            DropTable("dbo.Telephones");
            DropTable("dbo.People");
        }
    }
}

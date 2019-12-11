namespace MvcApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201912041702 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SideBars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Contorller = c.String(nullable: false, maxLength: 20),
                        Action = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SideBars");
        }
    }
}

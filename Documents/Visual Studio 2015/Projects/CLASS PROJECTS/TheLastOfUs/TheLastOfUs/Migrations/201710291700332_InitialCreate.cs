namespace TheLastOfUs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        MoveInDate = c.DateTime(nullable: false),
                        MoveOutDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Details = c.String(),
                        IsSafe = c.Boolean(nullable: false),
                        HasMedicine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SafeHavens", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.SafeHavens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SafeHaven_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SafeHavens", t => t.SafeHaven_ID)
                .Index(t => t.SafeHaven_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.SafeHavens");
            DropForeignKey("dbo.SafeHavens", "SafeHaven_ID", "dbo.SafeHavens");
            DropIndex("dbo.SafeHavens", new[] { "SafeHaven_ID" });
            DropIndex("dbo.Reviews", new[] { "CategoryID" });
            DropTable("dbo.SafeHavens");
            DropTable("dbo.Reviews");
        }
    }
}

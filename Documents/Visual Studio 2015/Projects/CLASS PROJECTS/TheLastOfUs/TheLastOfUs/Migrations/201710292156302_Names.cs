namespace TheLastOfUs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Names : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Name");
        }
    }
}

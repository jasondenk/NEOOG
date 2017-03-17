namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHaveWant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exchanges", "HaveNeed", c => c.Int(nullable: false));
            DropColumn("dbo.Exchanges", "GetGive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exchanges", "GetGive", c => c.String());
            DropColumn("dbo.Exchanges", "HaveNeed");
        }
    }
}

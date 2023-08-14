namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "PId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "PId");
            AddForeignKey("dbo.Clients", "PId", "dbo.Payments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "PId", "dbo.Payments");
            DropIndex("dbo.Clients", new[] { "PId" });
            DropColumn("dbo.Clients", "PId");
        }
    }
}

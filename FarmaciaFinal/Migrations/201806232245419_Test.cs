namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrdenVenta", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.OrdenVenta", new[] { "ApplicationUser_Id" });
            AddColumn("dbo.OrdenVenta", "Cliente_id", c => c.Int(nullable: false));
            CreateIndex("dbo.OrdenVenta", "Cliente_id");
            AddForeignKey("dbo.OrdenVenta", "Cliente_id", "dbo.Cliente", "Id", cascadeDelete: true);
            DropColumn("dbo.OrdenVenta", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrdenVenta", "ApplicationUser_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.OrdenVenta", "Cliente_id", "dbo.Cliente");
            DropIndex("dbo.OrdenVenta", new[] { "Cliente_id" });
            DropColumn("dbo.OrdenVenta", "Cliente_id");
            CreateIndex("dbo.OrdenVenta", "ApplicationUser_Id");
            AddForeignKey("dbo.OrdenVenta", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

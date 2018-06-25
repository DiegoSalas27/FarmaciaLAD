namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrdenVenta", "FirstName", c => c.String(maxLength: 160));
            AlterColumn("dbo.OrdenVenta", "LastName", c => c.String(maxLength: 160));
            AlterColumn("dbo.OrdenVenta", "Address", c => c.String(maxLength: 70));
            AlterColumn("dbo.OrdenVenta", "City", c => c.String(maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "State", c => c.String(maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "PostalCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.OrdenVenta", "Country", c => c.String(maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "Phone", c => c.String(maxLength: 24));
            AlterColumn("dbo.OrdenVenta", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrdenVenta", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.OrdenVenta", "Phone", c => c.String(nullable: false, maxLength: 24));
            AlterColumn("dbo.OrdenVenta", "Country", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.OrdenVenta", "State", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "City", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.OrdenVenta", "Address", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.OrdenVenta", "LastName", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.OrdenVenta", "FirstName", c => c.String(nullable: false, maxLength: 160));
        }
    }
}

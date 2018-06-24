namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdenVentaFixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrdenVenta", "Delivery", c => c.String());
            AlterColumn("dbo.OrdenVenta", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrdenVenta", "Estado", c => c.String(nullable: false));
            AlterColumn("dbo.OrdenVenta", "Delivery", c => c.String(nullable: false));
        }
    }
}

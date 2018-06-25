namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrdenVenta", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrdenVenta", "Email", c => c.String());
        }
    }
}

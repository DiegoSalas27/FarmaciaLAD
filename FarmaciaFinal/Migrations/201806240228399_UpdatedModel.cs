namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrdenVenta", "Cliente_id", "dbo.Cliente");
            DropIndex("dbo.OrdenVenta", new[] { "Cliente_id" });
            AddColumn("dbo.OrdenVenta", "Username", c => c.String());
            AddColumn("dbo.OrdenVenta", "FirstName", c => c.String(nullable: false, maxLength: 160));
            AddColumn("dbo.OrdenVenta", "LastName", c => c.String(nullable: false, maxLength: 160));
            AddColumn("dbo.OrdenVenta", "Address", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.OrdenVenta", "City", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.OrdenVenta", "State", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.OrdenVenta", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.OrdenVenta", "Country", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.OrdenVenta", "Phone", c => c.String(nullable: false, maxLength: 24));
            AddColumn("dbo.OrdenVenta", "Email", c => c.String(nullable: false));
            DropColumn("dbo.OrdenVenta", "Cliente_id");
            DropTable("dbo.Cliente");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 255),
                        Telefono = c.Int(nullable: false),
                        Direccion = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Ruc = c.Int(nullable: false),
                        Puntaje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.OrdenVenta", "Cliente_id", c => c.Int(nullable: false));
            DropColumn("dbo.OrdenVenta", "Email");
            DropColumn("dbo.OrdenVenta", "Phone");
            DropColumn("dbo.OrdenVenta", "Country");
            DropColumn("dbo.OrdenVenta", "PostalCode");
            DropColumn("dbo.OrdenVenta", "State");
            DropColumn("dbo.OrdenVenta", "City");
            DropColumn("dbo.OrdenVenta", "Address");
            DropColumn("dbo.OrdenVenta", "LastName");
            DropColumn("dbo.OrdenVenta", "FirstName");
            DropColumn("dbo.OrdenVenta", "Username");
            CreateIndex("dbo.OrdenVenta", "Cliente_id");
            AddForeignKey("dbo.OrdenVenta", "Cliente_id", "dbo.Cliente", "Id", cascadeDelete: true);
        }
    }
}

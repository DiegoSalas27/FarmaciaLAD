namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCarritoDeCompra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrito",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        Producto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId)
                .ForeignKey("dbo.Producto", t => t.Producto_Id, cascadeDelete: true)
                .Index(t => t.Producto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carrito", "Producto_Id", "dbo.Producto");
            DropIndex("dbo.Carrito", new[] { "Producto_Id" });
            DropTable("dbo.Carrito");
        }
    }
}

namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Detalle_compra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Producto_id = c.Int(nullable: false),
                        Compra_id = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio_unitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdenCompra", t => t.Compra_id, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.Producto_id, cascadeDelete: true)
                .Index(t => t.Producto_id)
                .Index(t => t.Compra_id);
            
            CreateTable(
                "dbo.OrdenCompra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha_orden = c.DateTime(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IGV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Costo_envio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Composicion = c.String(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Cantidad_por_unidad = c.Int(nullable: false),
                        Tipo_unidad_medida = c.String(nullable: false),
                        Fecha_vencimiento = c.DateTime(nullable: false),
                        Categoria_id = c.Int(nullable: false),
                        Presentacion_id = c.Int(nullable: false),
                        Laboratorio_id = c.Int(nullable: false),
                        Marca_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.Categoria_id, cascadeDelete: true)
                .ForeignKey("dbo.Laboratorio", t => t.Laboratorio_id, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.Marca_id, cascadeDelete: true)
                .ForeignKey("dbo.Presentacion", t => t.Presentacion_id, cascadeDelete: true)
                .Index(t => t.Categoria_id)
                .Index(t => t.Presentacion_id)
                .Index(t => t.Laboratorio_id)
                .Index(t => t.Marca_id);
            
            CreateTable(
                "dbo.Laboratorio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Telefono = c.Int(nullable: false),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Email = c.String(),
                        Estado = c.Boolean(nullable: false),
                        Ruc = c.Int(nullable: false),
                        Razon_social = c.String(),
                        Ciudad = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Presentacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Detalle_venta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio_unitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Orden_id = c.Int(nullable: false),
                        Producto_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdenVenta", t => t.Orden_id, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.Producto_id, cascadeDelete: true)
                .Index(t => t.Orden_id)
                .Index(t => t.Producto_id);
            
            CreateTable(
                "dbo.OrdenVenta",
                c => new
                    {
                        MyProperty = c.Int(nullable: false, identity: true),
                        Cliente_id = c.Int(nullable: false),
                        FechaCompra = c.DateTime(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IGV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Delivery = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MyProperty)
                .ForeignKey("dbo.Cliente", t => t.Cliente_id, cascadeDelete: true)
                .Index(t => t.Cliente_id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Detalle_venta", "Producto_id", "dbo.Producto");
            DropForeignKey("dbo.Detalle_venta", "Orden_id", "dbo.OrdenVenta");
            DropForeignKey("dbo.OrdenVenta", "Cliente_id", "dbo.Cliente");
            DropForeignKey("dbo.Detalle_compra", "Producto_id", "dbo.Producto");
            DropForeignKey("dbo.Producto", "Presentacion_id", "dbo.Presentacion");
            DropForeignKey("dbo.Producto", "Marca_id", "dbo.Marca");
            DropForeignKey("dbo.Producto", "Laboratorio_id", "dbo.Laboratorio");
            DropForeignKey("dbo.Producto", "Categoria_id", "dbo.Categoria");
            DropForeignKey("dbo.Detalle_compra", "Compra_id", "dbo.OrdenCompra");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.OrdenVenta", new[] { "Cliente_id" });
            DropIndex("dbo.Detalle_venta", new[] { "Producto_id" });
            DropIndex("dbo.Detalle_venta", new[] { "Orden_id" });
            DropIndex("dbo.Producto", new[] { "Marca_id" });
            DropIndex("dbo.Producto", new[] { "Laboratorio_id" });
            DropIndex("dbo.Producto", new[] { "Presentacion_id" });
            DropIndex("dbo.Producto", new[] { "Categoria_id" });
            DropIndex("dbo.Detalle_compra", new[] { "Compra_id" });
            DropIndex("dbo.Detalle_compra", new[] { "Producto_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.OrdenVenta");
            DropTable("dbo.Detalle_venta");
            DropTable("dbo.Presentacion");
            DropTable("dbo.Marca");
            DropTable("dbo.Laboratorio");
            DropTable("dbo.Producto");
            DropTable("dbo.OrdenCompra");
            DropTable("dbo.Detalle_compra");
            DropTable("dbo.Cliente");
            DropTable("dbo.Categoria");
        }
    }
}

namespace FarmaciaFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Producto", "Image");
        }
    }
}

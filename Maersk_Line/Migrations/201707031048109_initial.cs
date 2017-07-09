namespace Maersk_Line.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        WarehouseID = c.Int(nullable: false),
                        ShipYardID = c.Int(nullable: false),
                        ShipID = c.Int(nullable: false),
                        ContainerID = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Date = c.String(),
                        Time = c.String(),
                        Departure = c.String(),
                        Destination = c.String(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Containers", t => t.ContainerID, cascadeDelete: true)
                .ForeignKey("dbo.Ships", t => t.ShipID, cascadeDelete: true)
                .ForeignKey("dbo.ShipYards", t => t.ShipYardID, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseID, cascadeDelete: true)
                .Index(t => t.WarehouseID)
                .Index(t => t.ShipYardID)
                .Index(t => t.ShipID)
                .Index(t => t.ContainerID);
            
            CreateTable(
                "dbo.Containers",
                c => new
                    {
                        ContainerID = c.Int(nullable: false, identity: true),
                        ContainerName = c.String(),
                        ContainerDescription = c.String(),
                        ContainerAmount = c.Int(nullable: false),
                        ContainerWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ContainerID);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipID = c.Int(nullable: false, identity: true),
                        ShipName = c.String(),
                        ShipDescription = c.String(),
                        NumberOfContainersCarried = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShipID);
            
            CreateTable(
                "dbo.ShipYards",
                c => new
                    {
                        ShipyardID = c.Int(nullable: false, identity: true),
                        ShipYardName = c.String(nullable: false),
                        CurrentNumberOfShipsDocked = c.Int(nullable: false),
                        ShipYardDockNumber = c.Int(nullable: false),
                        TotalNumberOfContainers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShipyardID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseID = c.Int(nullable: false, identity: true),
                        WarehouseName = c.String(),
                        Supervisor = c.String(),
                        NumberOfContainersStored = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WarehouseID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeePass = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.Bookings", "ShipYardID", "dbo.ShipYards");
            DropForeignKey("dbo.Bookings", "ShipID", "dbo.Ships");
            DropForeignKey("dbo.Bookings", "ContainerID", "dbo.Containers");
            DropIndex("dbo.Bookings", new[] { "ContainerID" });
            DropIndex("dbo.Bookings", new[] { "ShipID" });
            DropIndex("dbo.Bookings", new[] { "ShipYardID" });
            DropIndex("dbo.Bookings", new[] { "WarehouseID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Warehouses");
            DropTable("dbo.ShipYards");
            DropTable("dbo.Ships");
            DropTable("dbo.Containers");
            DropTable("dbo.Bookings");
        }

        
    }
}

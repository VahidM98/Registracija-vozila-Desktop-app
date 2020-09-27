namespace RegistracijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizacijas",
                c => new
                    {
                        OrganizacijaId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 30),
                        Grad = c.String(nullable: false, maxLength: 15),
                        Ulica = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.OrganizacijaId);
            
            CreateTable(
                "dbo.Radniks",
                c => new
                    {
                        RadnikId = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 20),
                        Prezime = c.String(nullable: false, maxLength: 20),
                        Godine = c.Int(),
                        OrganizacijaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RadnikId)
                .ForeignKey("dbo.Organizacijas", t => t.OrganizacijaId, cascadeDelete: true)
                .Index(t => t.OrganizacijaId);
            
            CreateTable(
                "dbo.Putnickoes",
                c => new
                    {
                        PutnickoId = c.Int(nullable: false, identity: true),
                        Proizvodjac = c.String(nullable: false, maxLength: 20),
                        Tip = c.String(nullable: false, maxLength: 20),
                        GodProizvodnje = c.Int(nullable: false),
                        Snaga = c.Single(nullable: false),
                        Boja = c.String(nullable: false, maxLength: 20),
                        VlasnikId = c.Int(nullable: false),
                        Registracija_RegistracijaId = c.Int(),
                    })
                .PrimaryKey(t => t.PutnickoId)
                .ForeignKey("dbo.Registracijas", t => t.Registracija_RegistracijaId)
                .ForeignKey("dbo.Vlasniks", t => t.VlasnikId, cascadeDelete: true)
                .Index(t => t.VlasnikId)
                .Index(t => t.Registracija_RegistracijaId);
            
            CreateTable(
                "dbo.Registracijas",
                c => new
                    {
                        RegistracijaId = c.Int(nullable: false, identity: true),
                        Cena = c.Int(nullable: false),
                        Datum = c.String(nullable: false),
                        RadnikId = c.Int(nullable: false),
                        VoziloId = c.Int(nullable: false),
                        tipVozila = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RegistracijaId)
                .ForeignKey("dbo.Radniks", t => t.RadnikId, cascadeDelete: true)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.Vlasniks",
                c => new
                    {
                        VlasnikId = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 20),
                        Prezime = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.VlasnikId);
            
            CreateTable(
                "dbo.Voziloes",
                c => new
                    {
                        VoziloId = c.Int(nullable: false, identity: true),
                        Proizvodjac = c.String(),
                        Tip = c.String(),
                        GodProizvodnje = c.Int(nullable: false),
                        Boja = c.String(),
                        VlasnikId = c.Int(nullable: false),
                        Registracija_RegistracijaId = c.Int(),
                    })
                .PrimaryKey(t => t.VoziloId)
                .ForeignKey("dbo.Registracijas", t => t.Registracija_RegistracijaId)
                .ForeignKey("dbo.Vlasniks", t => t.VlasnikId, cascadeDelete: true)
                .Index(t => t.VlasnikId)
                .Index(t => t.Registracija_RegistracijaId);
            
            CreateTable(
                "dbo.Teretnoes",
                c => new
                    {
                        TeretnoId = c.Int(nullable: false, identity: true),
                        Proizvodjac = c.String(nullable: false, maxLength: 20),
                        Tip = c.String(nullable: false, maxLength: 20),
                        GodProizvodnje = c.Int(nullable: false),
                        Nosivost = c.Single(nullable: false),
                        Boja = c.String(nullable: false, maxLength: 20),
                        VlasnikId = c.Int(nullable: false),
                        Registracija_RegistracijaId = c.Int(),
                    })
                .PrimaryKey(t => t.TeretnoId)
                .ForeignKey("dbo.Registracijas", t => t.Registracija_RegistracijaId)
                .ForeignKey("dbo.Vlasniks", t => t.VlasnikId, cascadeDelete: true)
                .Index(t => t.VlasnikId)
                .Index(t => t.Registracija_RegistracijaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teretnoes", "VlasnikId", "dbo.Vlasniks");
            DropForeignKey("dbo.Teretnoes", "Registracija_RegistracijaId", "dbo.Registracijas");
            DropForeignKey("dbo.Putnickoes", "VlasnikId", "dbo.Vlasniks");
            DropForeignKey("dbo.Voziloes", "VlasnikId", "dbo.Vlasniks");
            DropForeignKey("dbo.Voziloes", "Registracija_RegistracijaId", "dbo.Registracijas");
            DropForeignKey("dbo.Putnickoes", "Registracija_RegistracijaId", "dbo.Registracijas");
            DropForeignKey("dbo.Registracijas", "RadnikId", "dbo.Radniks");
            DropForeignKey("dbo.Radniks", "OrganizacijaId", "dbo.Organizacijas");
            DropIndex("dbo.Teretnoes", new[] { "Registracija_RegistracijaId" });
            DropIndex("dbo.Teretnoes", new[] { "VlasnikId" });
            DropIndex("dbo.Voziloes", new[] { "Registracija_RegistracijaId" });
            DropIndex("dbo.Voziloes", new[] { "VlasnikId" });
            DropIndex("dbo.Registracijas", new[] { "RadnikId" });
            DropIndex("dbo.Putnickoes", new[] { "Registracija_RegistracijaId" });
            DropIndex("dbo.Putnickoes", new[] { "VlasnikId" });
            DropIndex("dbo.Radniks", new[] { "OrganizacijaId" });
            DropTable("dbo.Teretnoes");
            DropTable("dbo.Voziloes");
            DropTable("dbo.Vlasniks");
            DropTable("dbo.Registracijas");
            DropTable("dbo.Putnickoes");
            DropTable("dbo.Radniks");
            DropTable("dbo.Organizacijas");
        }
    }
}

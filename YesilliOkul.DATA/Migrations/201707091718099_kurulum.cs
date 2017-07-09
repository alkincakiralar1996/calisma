namespace YesilliOkul.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        HaftalikDersSaati = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Egitmen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sinifs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        TC = c.Int(nullable: false),
                        varchar = c.String(maxLength: 50),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Siniflari_ID = c.Int(),
                    })
                .PrimaryKey(t => t.TC)
                .ForeignKey("dbo.Sinifs", t => t.Siniflari_ID)
                .Index(t => t.Siniflari_ID);
            
            CreateTable(
                "dbo.EgitmenDers",
                c => new
                    {
                        Egitmen_ID = c.Int(nullable: false),
                        Ders_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Egitmen_ID, t.Ders_ID })
                .ForeignKey("dbo.Egitmen", t => t.Egitmen_ID, cascadeDelete: true)
                .ForeignKey("dbo.Ders", t => t.Ders_ID, cascadeDelete: true)
                .Index(t => t.Egitmen_ID)
                .Index(t => t.Ders_ID);
            
            CreateTable(
                "dbo.SinifDers",
                c => new
                    {
                        Sinif_ID = c.Int(nullable: false),
                        Ders_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sinif_ID, t.Ders_ID })
                .ForeignKey("dbo.Sinifs", t => t.Sinif_ID, cascadeDelete: true)
                .ForeignKey("dbo.Ders", t => t.Ders_ID, cascadeDelete: true)
                .Index(t => t.Sinif_ID)
                .Index(t => t.Ders_ID);
            
            CreateTable(
                "dbo.SinifEgitmen",
                c => new
                    {
                        Sinif_ID = c.Int(nullable: false),
                        Egitmen_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sinif_ID, t.Egitmen_ID })
                .ForeignKey("dbo.Sinifs", t => t.Sinif_ID, cascadeDelete: true)
                .ForeignKey("dbo.Egitmen", t => t.Egitmen_ID, cascadeDelete: true)
                .Index(t => t.Sinif_ID)
                .Index(t => t.Egitmen_ID);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Ogrenci_TC = c.Int(nullable: false),
                        Ders_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_TC, t.Ders_ID })
                .ForeignKey("dbo.Students", t => t.Ogrenci_TC, cascadeDelete: true)
                .ForeignKey("dbo.Ders", t => t.Ders_ID, cascadeDelete: true)
                .Index(t => t.Ogrenci_TC)
                .Index(t => t.Ders_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Siniflari_ID", "dbo.Sinifs");
            DropForeignKey("dbo.OgrenciDers", "Ders_ID", "dbo.Ders");
            DropForeignKey("dbo.OgrenciDers", "Ogrenci_TC", "dbo.Students");
            DropForeignKey("dbo.SinifEgitmen", "Egitmen_ID", "dbo.Egitmen");
            DropForeignKey("dbo.SinifEgitmen", "Sinif_ID", "dbo.Sinifs");
            DropForeignKey("dbo.SinifDers", "Ders_ID", "dbo.Ders");
            DropForeignKey("dbo.SinifDers", "Sinif_ID", "dbo.Sinifs");
            DropForeignKey("dbo.EgitmenDers", "Ders_ID", "dbo.Ders");
            DropForeignKey("dbo.EgitmenDers", "Egitmen_ID", "dbo.Egitmen");
            DropIndex("dbo.OgrenciDers", new[] { "Ders_ID" });
            DropIndex("dbo.OgrenciDers", new[] { "Ogrenci_TC" });
            DropIndex("dbo.SinifEgitmen", new[] { "Egitmen_ID" });
            DropIndex("dbo.SinifEgitmen", new[] { "Sinif_ID" });
            DropIndex("dbo.SinifDers", new[] { "Ders_ID" });
            DropIndex("dbo.SinifDers", new[] { "Sinif_ID" });
            DropIndex("dbo.EgitmenDers", new[] { "Ders_ID" });
            DropIndex("dbo.EgitmenDers", new[] { "Egitmen_ID" });
            DropIndex("dbo.Students", new[] { "Siniflari_ID" });
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.SinifEgitmen");
            DropTable("dbo.SinifDers");
            DropTable("dbo.EgitmenDers");
            DropTable("dbo.Students");
            DropTable("dbo.Sinifs");
            DropTable("dbo.Egitmen");
            DropTable("dbo.Ders");
        }
    }
}

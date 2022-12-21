namespace DOGAN.AmbarStokTakip.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmbarStokTakip : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alim",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AlimAdi = c.String(),
                        AlimTuru = c.String(),
                        ProgramDeleted = c.Boolean(nullable: false),
                        AlimTarihi = c.DateTime(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlimUrun",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AlimId = c.Long(nullable: false),
                        UrunId = c.Long(nullable: false),
                        BirimFiyat = c.Double(nullable: false),
                        Miktar = c.Double(nullable: false),
                        ToplamTutar = c.Double(nullable: false),
                        TedarikciFirma = c.String(),
                        MiktarKalan = c.Double(nullable: false),
                        ProgramDeleted = c.Boolean(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Depo_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alim", t => t.AlimId)
                .ForeignKey("dbo.Depo", t => t.Depo_Id)
                .ForeignKey("dbo.Urun", t => t.UrunId)
                .Index(t => t.AlimId)
                .Index(t => t.UrunId)
                .Index(t => t.Depo_Id);
            
            CreateTable(
                "dbo.Depo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DepoAdi = c.String(),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        Birim = c.String(),
                        Kalori = c.Double(nullable: false),
                        IaseOrSarf = c.Boolean(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Birim",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BirimAdi = c.String(),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CikisIase",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CikisIaseTarihi = c.DateTime(nullable: false),
                        TabelaId = c.Long(nullable: false),
                        iaseAd = c.String(),
                        KapaliHT = c.Int(nullable: false),
                        AcikHT = c.Int(nullable: false),
                        SabahPer = c.Int(nullable: false),
                        OglePer = c.Int(nullable: false),
                        AksamPer = c.Int(nullable: false),
                        Cocuk = c.Int(nullable: false),
                        Bebek = c.Int(nullable: false),
                        HamileBayan = c.Int(nullable: false),
                        AclikGrevi = c.Int(nullable: false),
                        Diyet = c.Int(nullable: false),
                        TSabah = c.Int(nullable: false),
                        TOgle = c.Int(nullable: false),
                        TAksam = c.Int(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tabela", t => t.TabelaId)
                .Index(t => t.TabelaId);
            
            CreateTable(
                "dbo.Tabela",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Sabah = c.String(),
                        Ogle = c.String(),
                        Aksam = c.String(),
                        TabelaTarihi = c.DateTime(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CikisIaseTabela",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CikisIaseId = c.Long(nullable: false),
                        UrunKayitId = c.Long(nullable: false),
                        Ogun = c.String(),
                        Miktar = c.Double(nullable: false),
                        KisiBasiKalori = c.Double(nullable: false),
                        KisiBasiFiyat = c.Double(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CikisIase", t => t.CikisIaseId)
                .ForeignKey("dbo.UrunKayit", t => t.UrunKayitId)
                .Index(t => t.CikisIaseId)
                .Index(t => t.UrunKayitId);
            
            CreateTable(
                "dbo.UrunKayit",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AlimUrunId = c.Long(nullable: false),
                        Miktar = c.Double(nullable: false),
                        ToplamTutar = c.Double(nullable: false),
                        UrunKayitTarihi = c.DateTime(nullable: false),
                        MiktarKalan = c.Double(nullable: false),
                        FaturaDurum = c.Boolean(nullable: false),
                        OdemeDurum = c.Boolean(nullable: false),
                        DepoId = c.Long(nullable: false),
                        ProgramDeleted = c.Boolean(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlimUrun", t => t.AlimUrunId)
                .Index(t => t.AlimUrunId);
            
            CreateTable(
                "dbo.CikisSarf",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UrunKayitId = c.Long(nullable: false),
                        Miktar = c.Double(nullable: false),
                        CikisSarfTarihi = c.DateTime(nullable: false),
                        APersonelId = c.Long(nullable: false),
                        BirimId = c.Long(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personel", t => t.APersonelId)
                .ForeignKey("dbo.Birim", t => t.BirimId)
                .ForeignKey("dbo.UrunKayit", t => t.UrunKayitId)
                .Index(t => t.UrunKayitId)
                .Index(t => t.APersonelId)
                .Index(t => t.BirimId);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PersonelAdi = c.String(),
                        PersonelSoyadi = c.String(),
                        PersonelSicili = c.String(),
                        PersonelUnvani = c.String(),
                        BirimId = c.Long(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Birim", t => t.BirimId)
                .Index(t => t.BirimId);
            
            CreateTable(
                "dbo.Fatura",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FaturaTarihi = c.DateTime(nullable: false),
                        UrunKayitId = c.Long(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UrunKayit", t => t.UrunKayitId)
                .Index(t => t.UrunKayitId);
            
            CreateTable(
                "dbo.Odeme",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OdemeTarihi = c.DateTime(nullable: false),
                        UrunKayitId = c.Long(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UrunKayit", t => t.UrunKayitId)
                .Index(t => t.UrunKayitId);
            
            CreateTable(
                "dbo.OtomatikCikis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        sabahCikis = c.Double(nullable: false),
                        ogleCikis = c.Double(nullable: false),
                        aksamCikis = c.Double(nullable: false),
                        secim = c.Boolean(nullable: false),
                        UrunId = c.Long(nullable: false),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urun", t => t.UrunId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.TelefonRehber",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsletmeAdi = c.String(),
                        IlgiliKisiAdSoyad = c.String(),
                        TelefonNo = c.String(),
                        Fax = c.String(),
                        EPosta = c.String(),
                        VergiTCNo = c.String(),
                        Adres = c.String(),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yemek",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        YemekAdi = c.String(),
                        UserDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OtomatikCikis", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Odeme", "UrunKayitId", "dbo.UrunKayit");
            DropForeignKey("dbo.Fatura", "UrunKayitId", "dbo.UrunKayit");
            DropForeignKey("dbo.CikisSarf", "UrunKayitId", "dbo.UrunKayit");
            DropForeignKey("dbo.CikisSarf", "BirimId", "dbo.Birim");
            DropForeignKey("dbo.CikisSarf", "APersonelId", "dbo.Personel");
            DropForeignKey("dbo.Personel", "BirimId", "dbo.Birim");
            DropForeignKey("dbo.CikisIaseTabela", "UrunKayitId", "dbo.UrunKayit");
            DropForeignKey("dbo.UrunKayit", "AlimUrunId", "dbo.AlimUrun");
            DropForeignKey("dbo.CikisIaseTabela", "CikisIaseId", "dbo.CikisIase");
            DropForeignKey("dbo.CikisIase", "TabelaId", "dbo.Tabela");
            DropForeignKey("dbo.AlimUrun", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.AlimUrun", "Depo_Id", "dbo.Depo");
            DropForeignKey("dbo.AlimUrun", "AlimId", "dbo.Alim");
            DropIndex("dbo.OtomatikCikis", new[] { "UrunId" });
            DropIndex("dbo.Odeme", new[] { "UrunKayitId" });
            DropIndex("dbo.Fatura", new[] { "UrunKayitId" });
            DropIndex("dbo.Personel", new[] { "BirimId" });
            DropIndex("dbo.CikisSarf", new[] { "BirimId" });
            DropIndex("dbo.CikisSarf", new[] { "APersonelId" });
            DropIndex("dbo.CikisSarf", new[] { "UrunKayitId" });
            DropIndex("dbo.UrunKayit", new[] { "AlimUrunId" });
            DropIndex("dbo.CikisIaseTabela", new[] { "UrunKayitId" });
            DropIndex("dbo.CikisIaseTabela", new[] { "CikisIaseId" });
            DropIndex("dbo.CikisIase", new[] { "TabelaId" });
            DropIndex("dbo.AlimUrun", new[] { "Depo_Id" });
            DropIndex("dbo.AlimUrun", new[] { "UrunId" });
            DropIndex("dbo.AlimUrun", new[] { "AlimId" });
            DropTable("dbo.Yemek");
            DropTable("dbo.TelefonRehber");
            DropTable("dbo.OtomatikCikis");
            DropTable("dbo.Odeme");
            DropTable("dbo.Fatura");
            DropTable("dbo.Personel");
            DropTable("dbo.CikisSarf");
            DropTable("dbo.UrunKayit");
            DropTable("dbo.CikisIaseTabela");
            DropTable("dbo.Tabela");
            DropTable("dbo.CikisIase");
            DropTable("dbo.Birim");
            DropTable("dbo.Urun");
            DropTable("dbo.Depo");
            DropTable("dbo.AlimUrun");
            DropTable("dbo.Alim");
        }
    }
}

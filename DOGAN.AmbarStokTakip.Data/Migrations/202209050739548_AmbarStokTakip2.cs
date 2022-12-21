namespace DOGAN.AmbarStokTakip.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AmbarStokTakip2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AlimUrun", "BirimFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.AlimUrun", "BirimFiyatKDVHaric", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.AlimUrun", "Kdv", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.AlimUrun", "Miktar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.AlimUrun", "ToplamTutar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.AlimUrun", "MiktarKalan", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.Urun", "Kalori", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.CikisIaseTabela", "Miktar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.CikisIaseTabela", "KisiBasiKalori", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.CikisIaseTabela", "KisiBasiFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.UrunKayit", "Miktar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.UrunKayit", "ToplamTutar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.UrunKayit", "MiktarKalan", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.CikisSarf", "Miktar", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.OtomatikCikis", "sabahCikis", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.OtomatikCikis", "ogleCikis", c => c.Decimal(nullable: false, precision: 18, scale: 5));
            AlterColumn("dbo.OtomatikCikis", "aksamCikis", c => c.Decimal(nullable: false, precision: 18, scale: 5));
        }

        public override void Down()
        {
            AlterColumn("dbo.OtomatikCikis", "aksamCikis", c => c.Double(nullable: false));
            AlterColumn("dbo.OtomatikCikis", "ogleCikis", c => c.Double(nullable: false));
            AlterColumn("dbo.OtomatikCikis", "sabahCikis", c => c.Double(nullable: false));
            AlterColumn("dbo.CikisSarf", "Miktar", c => c.Double(nullable: false));
            AlterColumn("dbo.UrunKayit", "MiktarKalan", c => c.Double(nullable: false));
            AlterColumn("dbo.UrunKayit", "ToplamTutar", c => c.Double(nullable: false));
            AlterColumn("dbo.UrunKayit", "Miktar", c => c.Double(nullable: false));
            AlterColumn("dbo.CikisIaseTabela", "KisiBasiFiyat", c => c.Double(nullable: false));
            AlterColumn("dbo.CikisIaseTabela", "KisiBasiKalori", c => c.Double(nullable: false));
            AlterColumn("dbo.CikisIaseTabela", "Miktar", c => c.Double(nullable: false));
            AlterColumn("dbo.Urun", "Kalori", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "MiktarKalan", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "ToplamTutar", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "Miktar", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "Kdv", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "BirimFiyatKDVHaric", c => c.Double(nullable: false));
            AlterColumn("dbo.AlimUrun", "BirimFiyat", c => c.Double(nullable: false));
        }
    }
}

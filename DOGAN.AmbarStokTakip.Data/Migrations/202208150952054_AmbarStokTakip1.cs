namespace DOGAN.AmbarStokTakip.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmbarStokTakip1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AlimUrun", "BirimFiyatKDVHaric", c => c.Double(nullable: false));
            AddColumn("dbo.AlimUrun", "Kdv", c => c.Double(nullable: false));
            AddColumn("dbo.TelefonRehber", "TelefonNo2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TelefonRehber", "TelefonNo2");
            DropColumn("dbo.AlimUrun", "Kdv");
            DropColumn("dbo.AlimUrun", "BirimFiyatKDVHaric");
        }
    }
}

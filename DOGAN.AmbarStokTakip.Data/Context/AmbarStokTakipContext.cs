using DOGAN.AmbarStokTakip.Data.Migrations;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DOGAN.AmbarStokTakip.Data.Context
{
    public class AmbarStokTakipContext : DbContext
    {
        public AmbarStokTakipContext()
            : base("name=AmbarStokTakipContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AmbarStokTakipContext, Configuration>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Entity<CikisIaseTabela>().Property(p => p.Miktar).HasPrecision(18, 5);
            modelBuilder.Entity<CikisIaseTabela>().Property(p => p.KisiBasiFiyat).HasPrecision(18, 5);
            modelBuilder.Entity<CikisIaseTabela>().Property(p => p.KisiBasiKalori).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.BirimFiyat).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.BirimFiyatKDVHaric).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.Kdv).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.Miktar).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.ToplamTutar).HasPrecision(18, 5);
            modelBuilder.Entity<AlimUrun>().Property(p => p.MiktarKalan).HasPrecision(18, 5);
            modelBuilder.Entity<CikisSarf>().Property(p => p.Miktar).HasPrecision(18, 5);
            modelBuilder.Entity<OtomatikCikis>().Property(p=>p.sabahCikis).HasPrecision(18, 5);
            modelBuilder.Entity<OtomatikCikis>().Property(p => p.ogleCikis).HasPrecision(18, 5);
            modelBuilder.Entity<OtomatikCikis>().Property(p => p.aksamCikis).HasPrecision(18, 5);
            modelBuilder.Entity<Urun>().Property(p=>p.Kalori).HasPrecision(18, 5);
            modelBuilder.Entity<UrunKayit>().Property(p => p.Miktar).HasPrecision(18, 5);
            modelBuilder.Entity<UrunKayit>().Property(p => p.ToplamTutar).HasPrecision(18, 5);
            modelBuilder.Entity<UrunKayit>().Property(p => p.MiktarKalan).HasPrecision(18, 5);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Birim> Birim { get; set; }
        public DbSet<Depo> Depo { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Tabela> Tabela { get; set; }
        public DbSet<CikisSarf> CikisSarf { get; set; }
        public DbSet<CikisIase> Cikisiase { get; set; }
        public DbSet<Alim> Alim { get; set; }
        public DbSet<UrunKayit> UrunKayit { get; set; }
        public DbSet<AlimUrun> AlimUrun { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Odeme> Odeme { get; set; }
        public DbSet<CikisIaseTabela> CikisiaseTabela { get; set; }
        public DbSet<OtomatikCikis> OtomatikCikis { get; set; }
        public DbSet<Yemek> Yemek { get; set; }
        public DbSet<TelefonRehber> TelefonRehber { get; set; }
    }
}
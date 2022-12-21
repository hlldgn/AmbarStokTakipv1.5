using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public  class AlimUrun:BaseEntity
    {
        public long AlimId { get; set; }
        public long UrunId { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal BirimFiyatKDVHaric { get; set; }
        public decimal Kdv { get; set; }
        public decimal Miktar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string TedarikciFirma { get; set; }
        public decimal MiktarKalan { get; set; }
        public bool ProgramDeleted { get; set; }

        public  Urun Urun { get; set; }
        public  Alim Alim { get; set; }
        public  Depo Depo { get; set; }
    }
}

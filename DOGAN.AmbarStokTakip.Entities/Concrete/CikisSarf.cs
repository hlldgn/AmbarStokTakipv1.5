using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class CikisSarf:BaseEntity
    {
        public long UrunKayitId { get; set; }
        public decimal Miktar { get; set; }
        public DateTime CikisSarfTarihi { get; set; }
        public long APersonelId { get; set; }
        public long BirimId { get; set; }
        public  UrunKayit UrunKayit { get; set; }
        public  Personel APersonel { get; set; }
        public  Birim Birim { get; set; }
    }
}

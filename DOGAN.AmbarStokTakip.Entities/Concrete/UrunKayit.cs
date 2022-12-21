using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class UrunKayit:BaseEntity
    {
        public long AlimUrunId { get; set; }
        public decimal Miktar { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime UrunKayitTarihi { get; set; }
        public decimal MiktarKalan { get; set; }
        public bool FaturaDurum { get; set; }
        public bool OdemeDurum { get; set; }
        public long DepoId { get; set; }
        public bool ProgramDeleted { get; set; }
        public AlimUrun AlimUrun { get; set; }
    }
}

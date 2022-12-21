using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Odeme:BaseEntity
    {
        public DateTime OdemeTarihi { get; set; }
        public long UrunKayitId { get; set; }
        public UrunKayit UrunKayit { get; set; }
    }
}

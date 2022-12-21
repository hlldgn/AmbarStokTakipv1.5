using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Fatura : BaseEntity
    {
        public DateTime FaturaTarihi { get; set; }
        public long UrunKayitId { get; set; }
        public UrunKayit UrunKayit { get; set; }
    }

}

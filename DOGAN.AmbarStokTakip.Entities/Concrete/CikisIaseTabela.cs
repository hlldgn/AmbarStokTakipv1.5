using DOGAN.AmbarStokTakip.Entities.Concrete.Base;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class CikisIaseTabela:BaseEntity
    {
        public long CikisIaseId { get; set; }
        public long UrunKayitId { get; set; }
        public string Ogun { get; set; }
        public decimal Miktar { get; set; }
        public decimal KisiBasiKalori { get; set; }
        public decimal KisiBasiFiyat { get; set; }
        public  UrunKayit UrunKayit { get; set; }
        public  CikisIase CikisIase { get; set; }
    }
}

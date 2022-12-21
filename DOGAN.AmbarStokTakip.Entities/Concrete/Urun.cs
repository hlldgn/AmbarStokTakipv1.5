using DOGAN.AmbarStokTakip.Entities.Concrete.Base;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Urun:BaseEntity
    {
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public decimal Kalori { get; set; }
        public bool IaseOrSarf { get; set; }

    }
}

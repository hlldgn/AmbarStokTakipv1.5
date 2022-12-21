using DOGAN.AmbarStokTakip.Entities.Concrete.Base;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Personel:BaseEntity
    {
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelSicili { get; set; }
        public string PersonelUnvani { get; set; }
        public long BirimId { get; set; }
        public Birim Birim { get; set; }

    }
}

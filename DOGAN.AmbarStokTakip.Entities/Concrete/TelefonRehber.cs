using DOGAN.AmbarStokTakip.Entities.Concrete.Base;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class TelefonRehber:BaseEntity
    {
        public string IsletmeAdi { get; set; }
        public string IlgiliKisiAdSoyad { get; set; }
        public string TelefonNo { get; set; }
        public string TelefonNo2 { get; set; }
        public string Fax { get; set; }
        public string EPosta { get; set; }
        public string VergiTCNo { get; set; }
        public string Adres { get; set; }

    }
}

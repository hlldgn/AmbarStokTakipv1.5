using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class TelefonRehberDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Işletme Adı")]
        public string IsletmeAdi { get; set; }
        [DisplayName("Ilgili Kişi Ad-Soyad")]
        public string IlgiliKisiAdSoyad { get; set; }
        [DisplayName("Telefon No")]
        public string TelefonNo { get; set; }
        [DisplayName("Telefon No")]
        public string TelefonNo2 { get; set; }
        [DisplayName("Fax No")]
        public string Fax { get; set; }
        [DisplayName("E-Posta")]
        public string EPosta { get; set; }
        [DisplayName("Vergi/T.C. No")]
        public string VergiTCNo { get; set; }
        [DisplayName("Adres")]
        public string Adres { get; set; }
    }
}

using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class PersonelDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Ad")]
        public string PersonelAdi { get; set; }
        [DisplayName("Soyad")]
        public string PersonelSoyadi { get; set; }
        [DisplayName("Sicil")]
        public string PersonelSicili { get; set; }
        [DisplayName("Ünvan")]
        public string PersonelUnvani { get; set; }
        [DisplayName("Birim Adı")]
        public string BirimAdi { get; set; }
        [DisplayName("Ad - Soyad")]
        public string PersonelAdPersonelSoyad { get; set; }

    }    
}

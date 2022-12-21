using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class UrunDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
    }
    public class UrunDtoSelectWitKalori:IDto
    {
        public long Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Kalori")]
        public decimal Kalori { get; set; }
    }
}

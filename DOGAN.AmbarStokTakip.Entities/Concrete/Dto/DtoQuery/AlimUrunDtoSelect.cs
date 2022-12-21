using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class AlimUrunDtoSelect:IDto
    {
        public long Id { get; set; }
        public long AlimId { get; set; }
        [DisplayName("Alım Adı")]
        public string AlimAdi { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Alınan Miktar")]
        public decimal AlinanMiktar { get; set; }
        [DisplayName("Kalan Miktar")]
        public decimal KalanMiktar { get; set; }
        [DisplayName("Tedarikçi Firma")]
        public string TedarikciFirma { get; set; }
    }
    public class AlimUrunMuayeneKabulDtoSelect:IDto
    {
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public decimal BirimFiyatKdvHaric { get; set; }
        public decimal Kdv { get; set; }
        public decimal BirimFiyat { get; set; }
        public string TedarikciFirma { get; set; }
    }
}

using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class OdemeDtoSelect:IDto
    {
        public long Id { get; set; }
        public long UrunKayitId { get; set; }
        [DisplayName("Alım Adı")]
        public string AlimAdi { get; set; }
        [DisplayName("Alım Tarihi")]
        public DateTime AlimTarihi { get; set; }
        [DisplayName("Tedarikçi Firma")]
        public string TedarikciFirma { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Miktar")]
        public decimal Miktar { get; set; }
        [DisplayName("Toplam Tutar")]
        public decimal ToplamTutar { get; set; }
        [DisplayName("Ürün Kayıt Tarihi")]
        public DateTime UrunKayitTarihi { get; set; }
        [DisplayName("Ödeme Tarihi")]
        public DateTime OdemeTarihi { get; set; }
    }
}

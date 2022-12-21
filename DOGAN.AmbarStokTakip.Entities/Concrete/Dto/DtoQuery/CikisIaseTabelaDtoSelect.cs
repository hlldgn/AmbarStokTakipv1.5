using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class CikisIaseTabelaDtoSelect:IDto
    {
        public long Id { get; set; }
        public long UrunKayitId { get; set; }
        [DisplayName("Öğün")]
        public string Ogun { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Kalori")]
        public decimal Kalori { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Miktar")]
        public decimal Miktar { get; set; }
        [DisplayName("Kişi Başı Fiyat")]
        public decimal KisiBasiFiyat { get; set; }
        [DisplayName("Kişi Başı Kalori")]
        public decimal KisiBasiKalori { get; set; }
    }
    public class CikisIaseTabelaDtoSelectForCikisHareket: IDto
    {
        public long Id { get; set; }
        public long UrunKayitId { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Kalori")]
        public decimal Kalori { get; set; }
        [DisplayName("Miktar")]
        public decimal Miktar { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Toplam Tutar")]
        public decimal ToplamTutar { get; set; }
        [DisplayName("Çıkış Tarihi")]
        public DateTime CikisTarihi { get; set; }
    }
}

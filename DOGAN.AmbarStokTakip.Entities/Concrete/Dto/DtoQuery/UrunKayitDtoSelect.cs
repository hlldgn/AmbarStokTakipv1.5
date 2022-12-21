using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class UrunKayitDtoSelect:IDto
    {
        public long Id { get; set; }
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
    }
    public class UrunKayitDtoSelectForIase:IDto
    {
        public long Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Kalori")]
        public decimal Kalori { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Kalan Miktar")]
        public decimal KalanMiktar { get; set; }
        [DisplayName("Tedarikçi Firma")]
        public string TedarikciFirma { get; set; }
        [DisplayName("Ürün Kayıt Tarihi")]
        public DateTime UrunKayitTarihi { get; set; }
    }
    public class UrunKayitDtoSelectForSarf:IDto
    {
        public long Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Kalan Miktar")]
        public decimal KalanMiktar { get; set; }
        [DisplayName("Tedarikçi Firma")]
        public string TedarikciFirma { get; set; }
        [DisplayName("Ürün Kayıt Tarihi")]
        public DateTime UrunKayitTarihi { get; set; }
    }
    public class UrunKayitDtoSelectForIaseDus:IDto
    {
        public long UrunId { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Kalan Miktar")]
        public decimal MiktarKalan { get; set; }
        [DisplayName("Kalori")]
        public decimal Kalori { get; set; }
    }
    public class UrunKayitDtoSelectForDepo:IDto
    {
        public long Id { get; set; }
        public long AlimId { get; set; }
        public long AlimUrunId { get; set; }
        public long DepoId { get; set; }
        public bool IaseOrSarf { get; set; }
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
        [DisplayName("Toplam Tutar")]
        public decimal ToplamTutar { get; set; }
        [DisplayName("Ürün Kayıt Tarihi")]
        public DateTime UrunKayitTarihi { get; set; }
        [DisplayName("Tedarikçi Firma")]
        public string TedarikciFirma { get; set; }
        [DisplayName("Fatura Durum")]
        public string Fatura { get; set; }
        [DisplayName("Ödeme Durum")]
        public string Odeme { get; set; }
        public bool ProgramDeleted { get; set; }
        public bool UserDeleted { get; set; }
    }
}

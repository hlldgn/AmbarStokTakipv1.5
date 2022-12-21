using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class CikisSarfDtoSelect:IDto
    {
        public long Id { get; set; }
        public long UrunKayitId { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        [DisplayName("Miktar")]
        public decimal Miktar { get; set; }
        [DisplayName("Toplam Tutar")]
        public decimal ToplamTutar { get ; set ; }
        [DisplayName("Teslim Edilen Kişi")]
        public string  TeslimEdilenKisi { get; set; }
        [DisplayName("Teslim Edilen Birim")]
        public string  TeslimEdilenBirim { get; set; }
        [DisplayName("Sarf Çıkış Tarihi")]
        public DateTime CikisTarihi { get; set; }
    }
}

using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.MuayeneKabul
{
    public class DtoMuayeneKabulListeDocument:IDto
    {
        public string TedarikciFirma { get; set; }
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public decimal BirimFiyatKdvHaric { get; set; }
        public decimal Kdv { get; set; }
        public decimal BirimFiyat { get; set; }
        public DateTime UrunKayitTarihi { get; set; }
    }
}

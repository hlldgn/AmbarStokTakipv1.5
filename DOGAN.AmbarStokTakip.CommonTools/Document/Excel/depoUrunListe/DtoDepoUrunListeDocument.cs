using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.depoUrunListe
{
    public class DtoDepoUrunListeDocument:IDto
    {
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public double BirimFiyat { get; set; }
        public double AlinanMiktar { get; set; }
        public double KalanMiktar { get; set; }
        public double ToplamTutar { get; set; }
        public DateTime UrunKayitTarihi { get; set; }
        public string TedarikciFirma { get; set; }
        public string Fatura { get; set; }
        public string Odeme { get; set; }
    }
}

using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.SarfCikis
{
    public class DtoSarfCikisListeDocument:IDto
    {
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public double BirimFiyat { get; set; }
        public double Miktar { get; set; }
        public double ToplamTutar { get; set; }
        public string TeslimEdilenKisi { get; set; }
        public string TeslimEdilenBirim { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}

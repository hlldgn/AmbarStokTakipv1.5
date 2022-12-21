using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.Iase
{
    public class DtoIaseTabelaSabahDocumet:IDto
    {
        public string Ogun { get; set; }
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public double DusulenMiktar { get; set; }
        public double BirimFiyat { get; set; }
        public double KBasiFiyat { get; set; }
        public double KBasiKalori { get; set; }

    }
}

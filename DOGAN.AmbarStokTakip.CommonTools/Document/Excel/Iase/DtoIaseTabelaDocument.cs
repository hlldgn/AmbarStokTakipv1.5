using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.Iase
{
    public class DtoIaseTabelaDocument:IDto
    {
        public DateTime IaseTarihi { get; set; }
        public string YemekSabah { get; set; }
        public string YemekOgle { get; set; }
        public string YemekAksam { get; set; }
        public string iaseAd { get; set; }
        public int KapaliHT { get; set; } = 0;
        public int AcikHT { get; set; } = 0;
        public int SabahPer { get; set; } = 0;
        public int OglePer { get; set; } = 0;
        public int AksamPer { get; set; } = 0;
        public int Cocuk { get; set; } = 0;
        public int Bebek { get; set; } = 0;
        public int HamileBayan { get; set; } = 0;
        public int AclikGrevi { get; set; } = 0;
        public int Diyet { get; set; } = 0;
        public int TSabah { get; set; }
        public int TOgle { get; set; }
        public int TAksam { get; set; }
        public string DateYil { get; set; }
    }
}

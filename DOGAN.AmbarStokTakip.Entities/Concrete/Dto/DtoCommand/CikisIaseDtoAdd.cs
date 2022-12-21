using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class CikisIaseDtoAdd
    {
        public DateTime CikisIaseTarihi { get; set; }
        public long TabelaId { get; set; }
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
    }
}

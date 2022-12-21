using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class CikisIaseTabelaDtoAdd : IDto
    {
        public long CikisIaseId { get; set; }
        public long UrunKayitId { get; set; }
        public string Ogun { get; set; }
        public decimal Miktar { get; set; }
        public decimal KisiBasiKalori { get; set; }
        public decimal KisiBasiFiyat { get; set; }
    }
}

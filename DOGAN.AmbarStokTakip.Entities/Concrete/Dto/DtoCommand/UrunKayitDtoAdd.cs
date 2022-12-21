using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class UrunKayitDtoAdd:IDto
    {
        public long AlimUrunId { get; set; }
        public decimal Miktar { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime UrunKayitTarihi { get; set; }
        public decimal MiktarKalan { get; set; }
        public long DepoId { get; set; }
    }
}

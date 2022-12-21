using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class CikisSarfDtoAdd:IDto
    {
        public long UrunKayitId { get; set; }
        public decimal Miktar { get; set; }
        public DateTime CikisSarfTarihi { get; set; }
        public long APersonelId { get; set; }
        public long BirimId { get; set; }
    }
}

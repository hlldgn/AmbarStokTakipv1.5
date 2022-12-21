using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class OdemeDtoAdd:IDto
    {
        public DateTime OdemeTarihi { get; set; }
        public long UrunKayitId { get; set; }
    }
}

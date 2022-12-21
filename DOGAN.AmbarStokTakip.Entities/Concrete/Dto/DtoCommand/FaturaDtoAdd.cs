using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class FaturaDtoAdd:IDto
    {
        public DateTime FaturaTarihi { get; set; }
        public long UrunKayitId { get; set; }
    }
}

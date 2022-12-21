using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class AlimDtoAdd:IDto
    {
        public string AlimAdi { get; set; }
        public string AlimTuru { get; set; }
        public DateTime AlimTarihi { get; set; }
    }
}

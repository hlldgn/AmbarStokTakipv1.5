using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class TabelaDtoAdd:IDto
    {
        public string Sabah { get; set; }
        public string Ogle { get; set; }
        public string Aksam { get; set; }
        public DateTime TabelaTarihi { get; set; }
    }
}

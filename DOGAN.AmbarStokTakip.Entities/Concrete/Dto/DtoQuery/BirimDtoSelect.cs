using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class BirimDtoSelect : IDto
    {
        public long Id { get; set; }
        [DisplayName("Birim Adı")]
        public string BirimAdi { get; set; }
    }
}

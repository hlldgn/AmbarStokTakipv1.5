using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class DepoDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Depo Adı")]
        public string DepoAdi { get; set; }
    }
}

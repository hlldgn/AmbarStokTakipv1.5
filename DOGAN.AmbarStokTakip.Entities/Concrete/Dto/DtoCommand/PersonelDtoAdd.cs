using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class PersonelDtoAdd:IDto
    {
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelSicili { get; set; }
        public string PersonelUnvani { get; set; }
        public long BirimId { get; set; }
    }
}

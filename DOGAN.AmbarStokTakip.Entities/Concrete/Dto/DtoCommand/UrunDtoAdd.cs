using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class UrunDtoAdd:IDto
    {
        public string UrunAdi { get; set; }
        public string Birim { get; set; }
        public decimal Kalori { get; set; }
        public bool IaseOrSarf { get; set; }
    }
}

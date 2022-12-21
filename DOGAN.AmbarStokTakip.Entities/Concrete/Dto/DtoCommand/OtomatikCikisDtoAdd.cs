using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class OtomatikCikisDtoAdd:IDto
    {
        public decimal sabahCikis { get; set; }
        public decimal ogleCikis { get; set; }
        public decimal aksamCikis { get; set; }
        public bool secim { get; set; }
        public long UrunId { get; set; }
    }
}

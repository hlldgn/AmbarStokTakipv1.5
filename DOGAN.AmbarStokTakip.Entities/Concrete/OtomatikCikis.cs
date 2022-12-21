using DOGAN.AmbarStokTakip.Entities.Concrete.Base;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class OtomatikCikis : BaseEntity
    {
        public decimal sabahCikis { get; set; }
        public decimal ogleCikis { get; set; }
        public decimal aksamCikis { get; set; }
        public bool secim { get; set; }
        public long UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}

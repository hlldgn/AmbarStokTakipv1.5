using DOGAN.AmbarStokTakip.Core.Entities;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand
{
    public class AlimUrunDtoAdd:IDto
    {
        public long AlimId { get; set; }
        public long UrunId { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal BirimFiyatKDVHaric { get; set; }
        public decimal Kdv { get; set; }
        public decimal Miktar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string TedarikciFirma { get; set; }
        public decimal MiktarKalan { get; set; }
    }
}

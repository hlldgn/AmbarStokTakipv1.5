using DOGAN.AmbarStokTakip.Core.Entities;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class OtomatikCikisDtoSelect : IDto
    {
        public long Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }
        [DisplayName("Birim")]
        public string Birim { get; set; }
        [DisplayName("Sabah Çıkış Çarpanı")]
        public decimal sabahCikis { get; set; }
        [DisplayName("Öğle Çıkış Çarpanı")]
        public decimal ogleCikis { get; set; }
        [DisplayName("Akşam Çıkış Çarpanı")]
        public decimal aksamCikis { get; set; }
        [DisplayName("Durum")]
        public string secim { get; set; }
    }
}

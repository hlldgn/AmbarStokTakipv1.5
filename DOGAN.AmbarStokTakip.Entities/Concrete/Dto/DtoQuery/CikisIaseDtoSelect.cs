using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class CikisIaseDtoSelect:IDto
    {
        public long Id { get; set; }//0
        [DisplayName("Iaşe Çıkış Tarihi")]
        public DateTime CikisIaseTarihi { get; set; }//1
        [DisplayName("Iaşe Adı")]
        public string iaseAd { get; set; }//2
        [DisplayName("Kapalı H/T Sayısı")]
        public int KapaliHT { get; set; } = 0;//3
        [DisplayName("Açık H/T Sayısı")]
        public int AcikHT { get; set; } = 0;//4
        [DisplayName("Sabah Personel Sayısı")]
        public int SabahPer { get; set; } = 0;//5
        [DisplayName("Öğle Personel Sayısı")]
        public int OglePer { get; set; } = 0;//6
        [DisplayName("Akşam Personel Sayısı")]
        public int AksamPer { get; set; } = 0;//7
        [DisplayName("Çocuk Sayısı")]
        public int Cocuk { get; set; } = 0;//8
        [DisplayName("Bebek Sayısı")]
        public int Bebek { get; set; } = 0;//9
        [DisplayName("Hamile Bayan Sayısı")]
        public int HamileBayan { get; set; } = 0;//10
        [DisplayName("Açlık Grevi Sayısı")]
        public int AclikGrevi { get; set; } = 0;//11
        [DisplayName("Diyet Sayısı")]
        public int Diyet { get; set; } = 0;//12
        [DisplayName("Toplam Sabah")]
        public int TSabah { get; set; }//13
        [DisplayName("Toplam Öğle")]
        public int TOgle { get; set; }//14
        [DisplayName("Toplam Akşam")]
        public int TAksam { get; set; }//15
    }
}

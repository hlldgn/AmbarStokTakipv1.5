using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.CommonTools.List
{
    public static class UrunGrubuCombobox
    {
        public static List<string> urunGrubu = new List<string>() { "İaşeye Ait Ürünler", "Sarf Malzemeler" };
        public static List<string> birim = new List<string>() { "Adet","Çift", "Gram", "Kilogram", "Litre", "Metre","Paket","Rulo","Santimetre","Takım" };
        public static List<string> ogun = new List<string>() { "Sabah", "Öğle", "Akşam" };
        public static List<string> kalanMiktarAlarmSeviyesi = new List<string>() { "10", "15", "20", "25", "30", 
            "35", "40", "45", "50", "55", "60", "65", "70", "75", "80" };
    }
}

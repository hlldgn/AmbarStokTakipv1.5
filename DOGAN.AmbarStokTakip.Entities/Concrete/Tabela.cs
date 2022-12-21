using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Tabela:BaseEntity
    {
        public string Sabah { get; set; }
        public string Ogle { get; set; }
        public string Aksam { get; set; }
        public DateTime TabelaTarihi { get; set; }
    }
}

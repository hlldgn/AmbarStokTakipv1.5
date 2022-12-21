using DOGAN.AmbarStokTakip.Entities.Concrete.Base;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete
{
    public class Alim:BaseEntity
    {
        public string AlimAdi { get; set; }
        public string AlimTuru { get; set; }
        public bool ProgramDeleted { get; set; }
        public DateTime AlimTarihi { get; set; }
    }
}

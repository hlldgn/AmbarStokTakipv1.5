using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class AlimDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Alım Adı")]
        public string AlimAdi { get; set; }
        [DisplayName("Alım Türü")]
        public string AlimTuru { get; set; }
        [DisplayName("Alım Tarihi")]
        public DateTime AlimTarihi { get; set; }
    }
    public class AlimDtoFilterSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Alım Adı")]
        public string AlimAdi { get; set; }
        [DisplayName("Alım Türü")]
        public string AlimTuru { get; set; }
        [DisplayName("Alım Tarihi")]
        public DateTime AlimTarihi { get; set; }
        public bool UserDeleted { get; set; }
        public bool ProgramDeleted { get; set; }
    }
}

using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.ComponentModel;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery
{
    public class TabelaDtoSelect:IDto
    {
        public long Id { get; set; }
        [DisplayName("Sabah Öğünü")]
        public string Sabah { get; set; }
        [DisplayName("Öğle Öğünü")]
        public string Ogle { get; set; }
        [DisplayName("Akşam Öğünü")]
        public string Aksam { get; set; }
        [DisplayName("Tabela Tarihi")]
        public DateTime TabelaTarihi { get; set; }
    }
}

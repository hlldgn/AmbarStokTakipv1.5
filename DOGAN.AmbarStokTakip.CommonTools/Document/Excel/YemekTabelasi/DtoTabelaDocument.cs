using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.YemekTabelasi
{
    public class DtoTabelaDocument:IDto
    {
        public DateTime TabelaTarihi { get; set; }
        public string Sabah { get; set; }
        public string Ogle { get; set; }
        public string Aksam { get; set; }
    }
}

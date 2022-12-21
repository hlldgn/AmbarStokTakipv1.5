using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.YemekTabelasi
{
    public static class TabelaDocumentCreate
    {
        public static void TabelaDocumentInsert(List<DtoTabelaDocument> tabelaDocuments,string area,FileInfo filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            CreateIfExists(filePath);
            using (var tabelaDocumentPackage=new ExcelPackage(filePath))
            {
                var ws = tabelaDocumentPackage.Workbook.Worksheets[1];
                ws.Name = "Tabela İnfo";
                ws.Cells.Clear();
                ws.Cells["A1:A3000"].Style.Numberformat.Format = "dd.mm.yyyy";
                var range = ws.Cells[area].LoadFromCollection(tabelaDocuments, true);
                range.AutoFitColumns();
                tabelaDocumentPackage.Save();
            }
            System.Diagnostics.Process.Start(filePath.FullName);
        }

        private static void CreateIfExists(FileInfo file)
        {
            if(!file.Exists)
            {
                file.Create();
            }
        }
    }
}

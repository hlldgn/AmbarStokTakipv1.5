using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.SarfCikis
{
    public static class SarfCikisListeDocumentCreate
    {
        public static void SarfCikisListeDocument(List<DtoSarfCikisListeDocument> sarfCikisListeDocument, FileInfo filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            CreateIfExists(filePath);
            using (var sarfCikisPackage = new ExcelPackage(filePath))
            {
                var ws = sarfCikisPackage.Workbook.Worksheets[1];
                ws.Name = "Sarf Malzeme Çıkış İnfo";
                ws.Cells.Clear();
                ws.Cells["H1:H3000"].Style.Numberformat.Format = "dd.mm.yyyy";
                var range = ws.Cells["A1"].LoadFromCollection(sarfCikisListeDocument, true);
                range.AutoFitColumns();
                sarfCikisPackage.Save();
            }
            System.Diagnostics.Process.Start(filePath.FullName);
        }

        private static void CreateIfExists(FileInfo file)
        {
            if (!file.Exists)
            {
                file.Create();
            }
        }
    }
}

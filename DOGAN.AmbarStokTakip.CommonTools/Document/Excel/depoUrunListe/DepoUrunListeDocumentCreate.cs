using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.depoUrunListe
{
    public static class DepoUrunListeDocumentCreate
    {
        public static void DepoUrunListeDocumentInsert(List<DtoDepoUrunListeDocument> depoUrunListeDocuments, string area,string title, FileInfo filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            CreateIfExists(filePath);
            using (var depoUrunListePackage = new ExcelPackage(filePath))
            {
                var ws = depoUrunListePackage.Workbook.Worksheets[0];
                ws.Name = "Depo Urun Liste";
                ws.Cells.Clear();
                ws.Cells["A1:I3"].Merge = true;
                ws.Cells["A1:I3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells["A1:I3"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells["A1:I3"].Style.Font.Bold=true;
                ws.Cells["A1:I3"].Style.Font.Size = 22;
                ws.Cells["A5:I5"].Style.Font.Bold = true;
                ws.Cells["F5:F3000"].Style.Font.Bold = true;
                ws.Cells["G6:G3000"].Style.Numberformat.Format = "dd.mm.yyyy";
                var titleRange = ws.Cells["A1"].Value = title;
                var range = ws.Cells[area].LoadFromCollection(depoUrunListeDocuments, true);
                range.AutoFitColumns();
                depoUrunListePackage.Save();
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

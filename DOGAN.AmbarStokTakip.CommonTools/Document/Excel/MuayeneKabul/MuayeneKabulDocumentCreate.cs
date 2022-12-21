using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.MuayeneKabul
{
    public class MuayeneKabulDocumentCreate
    {
        public static void MuayeneKabulDocumentInsert(List<DtoMuayeneKabulListeDocument> muayeneKabulDocuments, FileInfo filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            CreateIfExists(filePath);
            using (var muayeneKabulPackage = new ExcelPackage(filePath))
            {
                var ws = muayeneKabulPackage.Workbook.Worksheets[1];
                ws.Name = "MuayeneKabulInfo";
                ws.Cells.Clear();
                var range = ws.Cells["A1"].LoadFromCollection(muayeneKabulDocuments, true);
                ws.Cells["H2:H3000"].Style.Numberformat.Format = "dd.mm.yyyy";
                range.AutoFitColumns();
                muayeneKabulPackage.Save();
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

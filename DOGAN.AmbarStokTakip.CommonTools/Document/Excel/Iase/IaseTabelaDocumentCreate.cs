using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGAN.AmbarStokTakip.CommonTools.Document.Excel.Iase
{
    public static class IaseTabelaDocumentCreate
    {
        public static void IaseTabelaDocumentInsert(List<DtoIaseTabelaDocument> iaseTabelaDocument, string areaIaseTabelaDocument,
            List<DtoIaseTabelaSabahDocumet> iaseTabelaSabahDocument, string areaIaseTabelaSabahDocument,
            List<DtoIaseTabelaOgleDocument> iaseTabelaOgleDocument, string areaIaseTabelaOgleDocument,
            List<DtoIaseTabelaAksamDocument> iaseTabelaAksamDocument, string areaIaseTabelaAksamDocument, FileInfo filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            CreateIfExists(filePath);
            using (var tabelaDocumentPackage = new ExcelPackage(filePath))
            {
                var ws = tabelaDocumentPackage.Workbook.Worksheets[1];
                ws.Name = "İaşe İnfo";
                ws.Cells.Clear();
                var iaseTabelaDocumentRange = ws.Cells[areaIaseTabelaDocument].LoadFromCollection(iaseTabelaDocument, true);
                var iaseTabelaSabahDocumentRange = ws.Cells[areaIaseTabelaSabahDocument].LoadFromCollection(iaseTabelaSabahDocument, true);
                var iaseTabelaOgleDocumentRange = ws.Cells[areaIaseTabelaOgleDocument].LoadFromCollection(iaseTabelaOgleDocument, true);
                var iaseTabelaAksamDocumentRange = ws.Cells[areaIaseTabelaAksamDocument].LoadFromCollection(iaseTabelaAksamDocument, true);
                iaseTabelaDocumentRange.AutoFitColumns();
                iaseTabelaSabahDocumentRange.AutoFitColumns();
                iaseTabelaOgleDocumentRange.AutoFitColumns();
                iaseTabelaAksamDocumentRange.AutoFitColumns();
                tabelaDocumentPackage.Save();
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

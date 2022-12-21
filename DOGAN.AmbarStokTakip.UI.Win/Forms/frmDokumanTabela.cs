using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.CommonTools.Document.Excel.YemekTabelasi;
using DOGAN.AmbarStokTakip.UI.Win.WaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms // Check
{
    public partial class frmDokumanTabela : Form
    {
        private readonly ITabelaService _tabelaService;
        private readonly ICikisIaseService _cikisIaseService;
        WaitFormFunc waitForm = new WaitFormFunc();
        bool tumunuSecFlag = true;
        DateTime baslangic;
        DateTime bitis;
        int maxRow = 50;
        public frmDokumanTabela()
        {
            InitializeComponent();
            _tabelaService = InstanceFactory.GetInstance<ITabelaService>();
            _cikisIaseService = InstanceFactory.GetInstance<ICikisIaseService>();
            maxRow = Properties.Settings.Default.SatirSayisi;
            lblMaxRows.Text = "En Fazla " + maxRow.ToString() + " Satır Gösteriliyor.";
            bitis = DateTime.Parse(DateTime.Now.ToShortDateString());
            baslangic = bitis.AddDays(-6);
            dateilkTarih.Value = baslangic;
            dateSonTarih.Value = bitis;
            Yukle(baslangic, bitis);
        }
        #region List
        internal int Yukle(DateTime baslangic, DateTime bitis)
        {
            var result = _tabelaService.SelectTabelaDetailsNotDeleted(baslangic, bitis);
            if (result.IsSuccess)
            {
                datagridTabelaDokuman.DataSource = null;
                datagridTabelaDokuman.DataSource = result.Data.Take(maxRow).ToList();
                datagridTabelaDokuman.Columns["Id"].Visible = false;
                datagridTabelaDokuman.AutoResizeColumns();
                DataGridReadOnly();
            }
            return result.Data.Count;
        }
        #endregion
        #region Method
        private void DataGridReadOnly()
        {
            foreach (DataGridViewColumn item in datagridTabelaDokuman.Columns)
            {
                if (item.Name != "sec")
                {
                    item.ReadOnly = true;
                }
            }
        }
        private List<DtoTabelaDocument> GetTabelaDetailSetup()
        {
            datagridTabelaDokuman.CurrentCell = null;
            List<DtoTabelaDocument> document = new List<DtoTabelaDocument>();
            foreach (DataGridViewRow row in datagridTabelaDokuman.Rows)
            {
                if (Convert.ToBoolean(row.Cells["sec"].Value) == true)
                {
                    DtoTabelaDocument tabela = new DtoTabelaDocument
                    {
                        Sabah = row.Cells["Sabah"].Value.ToString(),
                        Ogle = row.Cells["Ogle"].Value.ToString(),
                        Aksam = row.Cells["Aksam"].Value.ToString(),
                        TabelaTarihi = DateTime.Parse(row.Cells["TabelaTarihi"].Value.ToString()),
                    };
                    document.Add(tabela);
                }
            }
            return document;
        }
        private void TumunuSecOptions(bool value)
        {
            datagridTabelaDokuman.CurrentCell = null;
            foreach (DataGridViewRow row in datagridTabelaDokuman.Rows)
            {
                row.Cells["sec"].Value = value;
            }
        }
        #endregion
        #region Event
        private void btnDokuman_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            try
            {
                var filePath = new FileInfo(fileName: Application.StartupPath + @"\Documents\Tabela\TabelaDefault.xlsx");
                var tabelaDocuments = GetTabelaDetailSetup();
                TabelaDocumentCreate.TabelaDocumentInsert(tabelaDocuments, "A1", filePath);
            }
            catch (Exception ex)
            {
                waitForm.Close();
                MessageBox.Show(ex.Message);
            }
            waitForm.Close();
        }
        private void btniptal_Click(object sender, EventArgs e)
        {
            try
            {
                int _selectedRow = datagridTabelaDokuman.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(datagridTabelaDokuman.Rows[_selectedRow].Cells["Id"].Value.ToString());
                DateTime tarih = DateTime.Parse(datagridTabelaDokuman.Rows[_selectedRow].Cells["TabelaTarihi"].Value.ToString());
                DeleteTabela(id, tarih);
                Yukle(baslangic, bitis);
            }
            catch
            {
            }
        }
        private void lblTumunuSec_Click(object sender, EventArgs e)
        {
            if (datagridTabelaDokuman.Rows.Count > 0)
            {
                TumunuSecOptions(tumunuSecFlag);
                if (tumunuSecFlag == true)
                {
                    lblTumunuSec.Text = "Tümünü Kaldır";
                    tumunuSecFlag = false;
                }
                else
                {
                    lblTumunuSec.Text = "Tümünü Seç";
                    tumunuSecFlag = true;
                }

            }
        }
        #endregion
        #region InsertAndUpdate
        private void DeleteTabela(int _id, DateTime tabelaTarih)
        {
            int tabelaKayitKontrol = _cikisIaseService.CikisIaseKayitKontrol(tabelaTarih);
            if (tabelaKayitKontrol <= 0)
            {
                DialogResult result = MessageBox.Show(tabelaTarih.ToShortDateString() + " tarihli tabelayı silmek istediğinize eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    var entityresult = _tabelaService.UpdateDeleteForUser(_id);
                    if (!entityresult.IsSuccess)
                    {
                        MessageBox.Show(entityresult.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(tabelaTarih.ToShortDateString() + " tarihli tabelada kayıtlı bir iaşe planı yer almaktadır bu yüzden tabela silinemiyor. Lütfen kayıtlı iaşe planını iptal edip tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnUygula_Click(object sender, EventArgs e)
        {
            baslangic = DateTime.Parse(dateilkTarih.Value.ToShortDateString());
            bitis = DateTime.Parse(dateSonTarih.Value.ToShortDateString());
            Yukle(baslangic, bitis);
        }
    }
}

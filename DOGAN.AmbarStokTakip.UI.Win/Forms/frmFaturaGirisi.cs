using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmFaturaGirisi : Form // Check
    {
        private readonly IUrunKayitService _urunKayitService;
        private readonly IFaturaService _faturaService;
        bool tumunuSecFlag = true;
        public frmFaturaGirisi()
        {
            InitializeComponent();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _faturaService = InstanceFactory.GetInstance<IFaturaService>();
            dateFaturaTarih.Value = DateTime.Now;
            Listele();
        }
        #region List
        private void Listele()
        {
            var result = _urunKayitService.GetSelectUrunKayitNotDeletedAndFaturaNotInsert();
            if (result.IsSuccess)
            {
                DataGridViewStyleAndDataSource(result);
            }
            if (result.Data.Count > 0)
            {
                ControlsVisible(true);
            }
            else
            {
                ControlsVisible(false);
            }
        }
        #endregion
        #region Method
        private void ControlsVisible(bool deger)
        {
            lblUrunler.Visible = deger;
            datagridFaturaListe.Visible = deger;
            lblTumunuSec.Visible = deger;
        }
        private void FaturaDatagridReadOnly()
        {
            foreach (DataGridViewColumn item in datagridFaturaListe.Columns)
            {
                if (item.Name != "sec")
                {
                    item.ReadOnly = true;
                }
            }
        }
        private void DataGridViewStyleAndDataSource(IDataResult<List<UrunKayitDtoSelect>> result)
        {
            datagridFaturaListe.DataSource = null;
            datagridFaturaListe.DataSource = result.Data;
            datagridFaturaListe.Columns["Id"].Visible = false;
            datagridFaturaListe.AutoResizeColumns();
            FaturaDatagridReadOnly();
        }
        private void TumunuSecOptions(bool value)
        {
            datagridFaturaListe.CurrentCell = null;
            foreach (DataGridViewRow row in datagridFaturaListe.Rows)
            {
                row.Cells["sec"].Value = value;
            }
        }
        #endregion
        #region InsertAndUpdate
        private bool AddFatura(int _id)
        {
            var fatura = new FaturaDtoAdd
            {
                FaturaTarihi = DateTime.Parse(dateFaturaTarih.Value.ToShortDateString()),
                UrunKayitId = _id,
            };
            var result = _faturaService.AddonDto(fatura);
            return result.IsSuccess;
        }
        private bool UpdateUrunKayit(int _id)
        {
            var entityresult = _urunKayitService.UpdateDeleteForProgram(_id, true, false);
            return entityresult.IsSuccess;
        }
        #endregion
        #region Event
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            var result = _urunKayitService.SearchByUrunKayitDetailsNotDeletedAndFaturaNotInsert(ara);
            if (result.IsSuccess)
            {
                DataGridViewStyleAndDataSource(result);
            }
        }
        private void lblTumunuSec_Click(object sender, EventArgs e)
        {
            if (datagridFaturaListe.Rows.Count > 0)
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
        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope=new TransactionScope())
            {
                try
                {
                    datagridFaturaListe.CurrentCell = null;
                    DateTime _tarih = DateTime.Parse(dateFaturaTarih.Value.ToShortDateString());
                    bool secimKontrol = false;
                    for (int i = 0; i < datagridFaturaListe.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(datagridFaturaListe.Rows[i].Cells["sec"].Value) == true)
                        {
                            int urunKayitId = Convert.ToInt32(datagridFaturaListe.Rows[i].Cells["Id"].Value.ToString());
                            DateTime dt = DateTime.Parse(datagridFaturaListe.Rows[i].Cells["UrunKayitTarihi"].Value.ToString());
                            secimKontrol = true;
                            if (_tarih >= dt)
                            {
                                AddFatura(urunKayitId);
                                UpdateUrunKayit(urunKayitId);
                            }
                            else
                            {
                                MessageBox.Show(datagridFaturaListe.Rows[i].Cells["UrunAdi"].Value.ToString() + " Adlı ürünün; Ürün kayıt tarihinden önce fatura tarihi olamaz. Bu yüzden bu ürüne ait fatura girişi yapılamamıştır. Lütfen fatura tarihini düzenleyip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    if (secimKontrol == false)
                    {
                        MessageBox.Show("Lütfen En az bir ürün seçiniz ve tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Listele();
                    transactionScope.Complete();
                }
                catch
                {
                    MessageBox.Show("Fatura bilgileri kaydedilirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transactionScope.Dispose();
                }
            }
        }
        #endregion
    }

}

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
    public partial class frmOdeme : Form // Check
    {
        private readonly IUrunKayitService _urunKayitService;
        private readonly IOdemeService _odemeService;
        private readonly IFaturaService _faturaService;
        bool tumunuSecFlag = true;
        public frmOdeme()
        {
            InitializeComponent();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            _odemeService = InstanceFactory.GetInstance<IOdemeService>();
            _faturaService = InstanceFactory.GetInstance<IFaturaService>();
            dateOdemeTarih.Value = DateTime.Now;
            Listele();
        }
        #region List
        private void Listele()
        {
            var result = _urunKayitService.GetSelectUrunKayitNotDeletedAndOdemeNotInsertAndFaturaInsert();
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
            datagridOdemeListe.Visible = deger;
            lblTumunuSec.Visible = deger;
        }
        private void DataGridViewStyleAndDataSource(IDataResult<List<UrunKayitDtoSelect>> urunKayits)
        {
            datagridOdemeListe.DataSource = null;
            datagridOdemeListe.DataSource = urunKayits.Data;
            datagridOdemeListe.Columns["Id"].Visible = false;
            datagridOdemeListe.AutoResizeColumns();
            OdemeDatagridReadOnly();
        }
        private void OdemeDatagridReadOnly()
        {
            foreach (DataGridViewColumn item in datagridOdemeListe.Columns)
            {
                if (item.Name != "sec")
                {
                    item.ReadOnly = true;
                }
            }
        }
        private void TumunuSecOptions(bool value)
        {
            datagridOdemeListe.CurrentCell = null;
            foreach (DataGridViewRow row in datagridOdemeListe.Rows)
            {
                row.Cells["sec"].Value = value;
            }
        }
        #endregion
        #region InsertAndUpdate
        private bool AddOdeme(int _id)
        {
            var fatura = new OdemeDtoAdd
            {
                OdemeTarihi = DateTime.Parse(dateOdemeTarih.Value.ToShortDateString()),
                UrunKayitId = _id,
            };
            var result = _odemeService.AddonDto(fatura);
            return result.IsSuccess;
        }
        private bool UpdateUrunKayit(int _id)
        {
            var entityresult = _urunKayitService.UpdateDeleteForProgram(_id, true, true);
            return entityresult.IsSuccess;
        }
        #endregion
        #region Event
        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            var result = _urunKayitService.SearchByUrunKayitDetailsNotDeletedAndOdemeNotInsertAndFaturaInsert(ara);
            if (result.IsSuccess)
            {
                DataGridViewStyleAndDataSource(result);
            }
        }
        private void lblTumunuSec_Click(object sender, EventArgs e)
        {
            if (datagridOdemeListe.Rows.Count > 0)
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    datagridOdemeListe.CurrentCell = null;
                    DateTime _tarih = DateTime.Parse(dateOdemeTarih.Value.ToShortDateString());
                    bool secimKontrol = false;
                    for (int i = 0; i < datagridOdemeListe.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(datagridOdemeListe.Rows[i].Cells["sec"].Value) == true)
                        {
                            int urunKayitId = Convert.ToInt32(datagridOdemeListe.Rows[i].Cells["Id"].Value.ToString());
                            var faturaResult = _faturaService.GetFaturaUrunKayitId(urunKayitId);
                            secimKontrol = true;
                            if (_tarih >= faturaResult.Data.FaturaTarihi)
                            {
                                AddOdeme(urunKayitId);
                                UpdateUrunKayit(urunKayitId);
                            }
                            else
                            {
                                MessageBox.Show(datagridOdemeListe.Rows[i].Cells["UrunAdi"].Value.ToString() + " Adlı ürünün; Fatura tarihinden önce ödeme tarihi olamaz. Bu yüzden bu ürüne ait ödeme girişi yapılamamıştır. Lütfen ödeme tarihini düzenleyip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Ödeme bilgileri kaydedilirken bir sorunla karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transactionScope.Dispose();
                }
            }
        }
        #endregion

    }
}

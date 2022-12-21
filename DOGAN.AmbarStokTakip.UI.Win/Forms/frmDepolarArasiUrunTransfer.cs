using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.Forms
{
    public partial class frmDepolarArasiUrunTransfer : Form //Check
    {
        private readonly IDepoService _depoService;
        private readonly IUrunKayitService _urunKayitService;
        public frmDepolarArasiUrunTransfer()
        {
            InitializeComponent();
            _depoService = InstanceFactory.GetInstance<IDepoService>();
            _urunKayitService = InstanceFactory.GetInstance<IUrunKayitService>();
            ComboBoxDoldur();
        }
        #region Method
        internal int ComboBoxDoldur()
        {
            var result = _depoService.GetDepoDetailsNotDeleted();
            cmbKaynakDepo.DataSource = result.Data;
            cmbKaynakDepo.DisplayMember = "DepoAdi";
            cmbKaynakDepo.ValueMember = "Id";
            cmbHedefDepo.DataSource = _depoService.GetDepoDetailsNotDeleted().Data;
            cmbHedefDepo.DisplayMember = "DepoAdi";
            cmbHedefDepo.ValueMember = "Id";
            return result.Data.Count;
        }
        private void DatagridDepoListeReadOnly()
        {
            foreach (DataGridViewColumn item in datagridDepoListe.Columns)
            {
                if (item.HeaderText != "Seç")
                {
                    item.ReadOnly = true;
                }
            }
        }
        #endregion
        #region InsertAndUpdate
        private void UrunKayitDepoUpdate(int urunKayitId, int hedefDepoId)
        {
            _urunKayitService.UpdateDepoTransfer(urunKayitId, hedefDepoId);
        }
        #endregion
        #region List
        private void Listele()
        {
            if (cmbKaynakDepo.Items.Count > 0)
            {
                int _id = Convert.ToInt32(cmbKaynakDepo.SelectedValue);
                var result = _urunKayitService.GetUrunKayitDetailsNotDeletedForDepoDepoId(_id);
                datagridDepoListe.DataSource = null;
                datagridDepoListe.DataSource = result.Data;
                datagridDepoListe.Columns["Id"].Visible = false;
                datagridDepoListe.Columns["AlimId"].Visible = false;
                datagridDepoListe.Columns["AlimUrunId"].Visible = false;
                datagridDepoListe.Columns["DepoId"].Visible = false;
                datagridDepoListe.Columns["ProgramDeleted"].Visible = false;
                datagridDepoListe.Columns["UserDeleted"].Visible = false;
                datagridDepoListe.Columns["IaseOrSarf"].Visible = false;
                datagridDepoListe.AutoResizeColumns();
                DatagridDepoListeReadOnly();
                if (result.Data.Count > 0)
                {
                    lblDepoListesi.Visible = true;
                    datagridDepoListe.Visible = true;
                    btnDokuman.Visible = true;
                }
                else
                {
                    lblDepoListesi.Visible = false;
                    datagridDepoListe.Visible = false;
                    btnDokuman.Visible = false;
                }
            }
        }
        #endregion
        #region Event
        private void frmDepolarArasiUrunTransfer_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDokuman_Click(object sender, EventArgs e)
        {
            if (datagridDepoListe.Rows.Count > 0)
            {
                datagridDepoListe.CurrentCell = null;
                bool secimFlag = false;
                if (cmbKaynakDepo.SelectedValue.ToString() != cmbHedefDepo.SelectedValue.ToString())
                {
                    int hedefDepoId = Convert.ToInt32(cmbHedefDepo.SelectedValue.ToString());
                    foreach (DataGridViewRow row in datagridDepoListe.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["sec"].Value) == true)
                        {
                            secimFlag = true;
                            int urunKayitId = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                            UrunKayitDepoUpdate(urunKayitId, hedefDepoId);
                        }
                    }
                    if (secimFlag == true)
                    {
                        MessageBox.Show("Depolar arası transfer başarıyla gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen transfer edilecek en az bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aynı Depolar arası ürün transferi gerçekleştirilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbKaynakDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKaynakDepo.ValueMember == "Id")
            {
                Listele();

            }
        }
        #endregion
    }
}

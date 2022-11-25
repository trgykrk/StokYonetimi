using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using StokYonetimi.Class;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Formlar
{
    public partial class frmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaListesi()
        {
            InitializeComponent();
            Fatura_Islemleri.ds.Relations.Clear();
            Fatura_Islemleri.ds.Tables.Clear();
            Fatura_Islemleri.dtUst.Columns.Clear();
            Fatura_Islemleri.dtUst.Columns.Add("ID", typeof(int));
            Fatura_Islemleri.dtUst.Columns.Add("CariKodu", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("CariAdiSoyadi", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("FaturaNo", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("FaturaTarihi", typeof(DateTime));
            Fatura_Islemleri.dtUst.Columns.Add("Mail", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("Telefon", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("Adres", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("KullaniciAdi", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("KdvToplam", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("ToplamTutar", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("AraToplam", typeof(string));
            Fatura_Islemleri.dtUst.Columns.Add("FaturaTipi", typeof(string));
            Fatura_Islemleri.dtKalem.Columns.Clear();
            Fatura_Islemleri.dtKalem.Columns.Add("BaslikRef", typeof(int)).Caption = "Fatura Ref";
            Fatura_Islemleri.dtKalem.Columns.Add("StokAdi", typeof(string)).Caption = "Stok Adı";
            Fatura_Islemleri.dtKalem.Columns.Add("StokBirimFiyat", typeof(string)).Caption = "Stok Birim Fiyatı";
            Fatura_Islemleri.dtKalem.Columns.Add("Miktar", typeof(string)).Caption = "Miktar";
            Fatura_Islemleri.dtKalem.Columns.Add("StokBirim", typeof(string)).Caption = "Stok Birimi";
            Fatura_Islemleri.dtKalem.Columns.Add("KdvOran", typeof(string)).Caption = "Kdv Oranı %";
            Fatura_Islemleri.dtKalem.Columns.Add("KdvTutar", typeof(string)).Caption = "Kdv Tutarı";
            Fatura_Islemleri.dtKalem.Columns.Add("KalemAraToplam", typeof(string)).Caption = "Ara Toplam";
            Fatura_Islemleri.dtKalem.Columns.Add("KalemToplamTutar", typeof(string)).Caption = "Toplam Tutar";
            Fatura_Islemleri.ds.Tables.Add(Fatura_Islemleri.dtUst);
            Fatura_Islemleri.ds.Tables.Add(Fatura_Islemleri.dtKalem);
            Fatura_Islemleri.dtKalem.Columns.Add("StokKodu", typeof(string)).Caption = "Stok Kodu"; ;
            DataRelation rel = new DataRelation("Kalem Kayıtları", Fatura_Islemleri.dtUst.Columns["ID"], Fatura_Islemleri.dtKalem.Columns["BaslikRef"], false);
            Fatura_Islemleri.ds.Relations.Add(rel);
        }
        private void frmFaturaListesi_Load(object sender, EventArgs e)
        {
            try
            {
                cbxFaturaTipi.EditValue = "";
                txtCariKodu.EditValue = "";
                txtFaturaNo.EditValue = "";
                dteFatBasTar.EditValue = "01.01." + DateTime.Now.Year;
                dteFatBitTar.EditValue = DateTime.Now.AddDays(+1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnKayitlariGetir_Click(object sender, EventArgs e)
        {
            try
            {
                using (new clsWAIT<frmWaitBar>("İşleminiz gerçekleştiriliyor..."))
                {
                    Genel_Cikti_Islemleri.GorunumuYukle(gvFaturaListesi, this);
                    grdFaturaListesi.DataSource = Fatura_Islemleri.FaturaList(Convert.ToDateTime(dteFatBasTar.EditValue.ToString()), Convert.ToDateTime(dteFatBitTar.EditValue.ToString()), cbxFaturaTipi.EditValue.ToString(), txtFaturaNo.Text, txtCariKodu.Text).Tables[0];
                    grdFaturaListesi.Refresh();
                    gvFaturaListesi.BestFitColumns();
                }
                //grdFaturaListesi.DataSource = Fatura_Islemleri.FaturaListesiGetir(Convert.ToDateTime(dteFatBasTar.EditValue),Convert.ToDateTime(dteFatBitTar.EditValue),cbxFaturaTipi.EditValue.ToString(),txtFaturaNo.EditValue.ToString(),txtCariKodu.EditValue.ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbxFaturaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFaturaTipi.SelectedItem = "Tümü";
        }
        private void grdFaturaListesi_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvFaturaListesi.DataRowCount > 1)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        popMenu.ShowPopup(Control.MousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.ExceleGonder("Fatura Listesi", gvFaturaListesi);
        }
        private void btnGorunumuSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.GorunumuSakla(gvFaturaListesi, this);
        }
        private void gvFaturaListesi_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    e.Appearance.BackColor = Color.FromArgb(170, 255, 170);
                    if (gvFaturaListesi.GetRowCellValue(e.RowHandle, "KullaniciAdi").ToString() != Settings.Default.AktifKullaniciAdi)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 160, 140);
                    }                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
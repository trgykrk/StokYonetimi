using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokYonetimi.Class;
using StokYonetimi.Formlar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using NLog;
using System.IO;
using PusherServer;

namespace StokYonetimi.Formlar
{
    public partial class frmFatura : DevExpress.XtraEditors.XtraForm
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        Logger logger = LogManager.GetCurrentClassLogger();
        frmStokRehber rhbr = new frmStokRehber();
        frmCariRehber CrRehber = new frmCariRehber();

        static bool FaturaNoKullanildiMi;
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            try
            {
                CrRehber.Modul = 0;
                CrRehber.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnStokSeciniz_Click(object sender, EventArgs e)
        {
            try
            {
                rhbr.Modul = 1;
                rhbr.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmFatura_Load(object sender, EventArgs e)
        {
            try
            {
                txtFaturaNo.Text = Fatura_Islemleri.FaturaNoHesapla();
                dteFaturaTarihi.EditValue = DateTime.Now;
                btnHesapla.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvKalemBilgileri_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (gvKalemBilgileri.RowCount > 0)
                    {
                        gvKalemBilgileri.DeleteSelectedRows();
                        btnHesapla_Click(sender, e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Silinecek Kalem Bilgisi Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvKalemBilgileri_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        private void gvKalemBilgileri_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GridColumn Kdv_Oran = view.Columns["Kdv_Oran"];
                GridColumn Miktar = view.Columns["Miktar"];
                string kdv = view.GetRowCellValue(e.RowHandle, "Kdv_Oran").ToString();
                string miktar = view.GetRowCellValue(e.RowHandle, "Miktar").ToString();
                if (miktar == "")
                {
                    e.Valid = false;
                    view.SetColumnError(Miktar, "Miktar Alanı Boş Bırakılamaz");
                }
                if (kdv == "")
                {
                    e.Valid = false;
                    view.SetColumnError(Kdv_Oran, "Kdv Oran Boş Bırakılamaz");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (new clsWAIT<frmWaitBar>("Fatura Oluşturuluyor..."))
                {
                    if (ValKontrol.Validate())
                    {
                        if (txtFaturaNo.Text.Length == 16)
                        {
                            FaturaNoKullanildiMi = Fatura_Islemleri.FaturaNumarasiKontrol(txtFaturaNo.Text);
                            if (FaturaNoKullanildiMi == true)
                            {
                                if (gvKalemBilgileri.RowCount > 0)
                                {
                                    if (XtraMessageBox.Show(txtFaturaNo.Text + " Numaralı Faturanız Oluşturulacak. Onaylıyor Musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        int CariRef = Fatura_Islemleri.CariRefBul(btnCariSec.EditValue.ToString());
                                        Fatura_Islemleri.FaturaOlustur(txtFaturaNo.Text, cbxFaturaTipi.EditValue.ToString(), Convert.ToDateTime(dteFaturaTarihi.EditValue), btnCariSec.EditValue.ToString(), txtCariAdiSoyadi.Text, txtTelefon.Text, txtAdresBilgisi.Text, txtMailAdresi.Text, Convert.ToDouble(txtAraToplam.Text), Convert.ToDouble(txtKDV.Text), Convert.ToDouble(txtToplamTutar.Text), CariRef);
                                        int FaturaRef = Fatura_Islemleri.FaturaRefBul(txtFaturaNo.Text);
                                        Fatura_Islemleri.KalemOlustur(gvKalemBilgileri, FaturaRef);
                                        // XtraMessageBox.Show(txtFaturaNo.Text + " Numaralı Faturanız Başarılı Bir Şekilde Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Notification_Islemleri.Alert(DateTime.Now + "'da " + txtFaturaNo.Text + " Numaralı " + cbxFaturaTipi.EditValue + "  Başarılı Bir Şekilde Oluşturuldu", frmNotification.enmType.Info);
                                        frmNotification.FaturaNumarasi = txtFaturaNo.Text;
                                        frmNotification.FatTarih = Convert.ToDateTime(dteFaturaTarihi.EditValue);
                                        Genel_Cikti_Islemleri.Notification_(DateTime.Now + "'da " + txtFaturaNo.Text + " Numaralı " + cbxFaturaTipi.EditValue + "  Başarılı Bir Şekilde Oluşturuldu");
                                    }
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Kalem Bilgisi Girmeden Fatura Kesemezsiniz..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Bu Fatura Numarası Sistemde Kayıtlı.Lütfen Kullanılmamış Fatura Numarası Kullanın..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Fatura No Alanı 16 Hane olacak Şekilde Girilmelidir..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValKontrol.Validate() == true || ValKontrol.Validate() == false)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                KalemTutarHesapla();
                FaturaToplamTutarHesapla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KalemTutarHesapla()
        {
            try
            {
                if (gvKalemBilgileri.RowCount > 0)
                {
                    for (int i = 0; i < gvKalemBilgileri.RowCount; i++)
                    {
                        if (gvKalemBilgileri.GetRowCellValue(i, "Miktar").ToString() != "" || gvKalemBilgileri.GetRowCellValue(i, "Kdv_Oran").ToString() != "")
                        {
                            //int StokMiktar = StokIslemleri.StokSayisiBul(gvKalemBilgileri.GetRowCellValue(i, "Stok_Kodu").ToString());
                            //if (Convert.ToInt32(gvKalemBilgileri.GetRowCellValue(i, "Miktar")) <= StokMiktar)
                            //{
                                decimal sonuc = Fatura_Islemleri.KdvHesapla(Convert.ToDecimal(gvKalemBilgileri.GetRowCellValue(i, "Stok_SatisFiyat").ToString()), Convert.ToInt32(gvKalemBilgileri.GetRowCellValue(i, "Miktar").ToString()), Convert.ToInt32(gvKalemBilgileri.GetRowCellValue(i, "Kdv_Oran").ToString()));
                                gvKalemBilgileri.SetRowCellValue(i, "Kdv_Tutari", sonuc);
                            //}
                            //else
                            //{
                            //    XtraMessageBox.Show("Yeterli Stoğunuz Bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                        }
                        else
                        {
                            XtraMessageBox.Show("Lütfen Boş Alanları Doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FaturaToplamTutarHesapla()
        {
            decimal KdvToplamTutar = 0;
            decimal AraToplam = 0;
            decimal ToplamTutar = 0;
            decimal BirimFiyat = 0;
            int Miktar = 0;
            txtKDV.Text = "";
            txtAraToplam.Text = "";
            txtToplamTutar.Text = "";
            if (txtKDV.Text == "")
            {
                for (int i = 0; i < gvKalemBilgileri.RowCount; i++)
                {
                    BirimFiyat = Convert.ToDecimal(gvKalemBilgileri.GetRowCellValue(i, "Stok_SatisFiyat").ToString());
                    Miktar = Convert.ToInt32(gvKalemBilgileri.GetRowCellValue(i, "Miktar").ToString());
                    KdvToplamTutar += Convert.ToDecimal(gvKalemBilgileri.GetRowCellValue(i, "Kdv_Tutari").ToString());
                    AraToplam += Fatura_Islemleri.AraToplamHesapla(BirimFiyat, Miktar);
                }
                ToplamTutar += Fatura_Islemleri.ToplamTutarHesapla(AraToplam, KdvToplamTutar);
            }
            txtKDV.Text = KdvToplamTutar.ToString();
            txtAraToplam.Text = AraToplam.ToString();
            txtToplamTutar.Text = ToplamTutar.ToString();
        }
        private void gvKalemBilgileri_Click(object sender, EventArgs e)
        {
            btnHesapla_Click(sender, e);
        }
        private void gvKalemBilgileri_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int StokMiktar = 0;
                if (gvKalemBilgileri.RowCount > 0)
                {
                    if (cbxFaturaTipi.EditValue == "Satış Faturası")
                    {
                        for (int i = 0; i < gvKalemBilgileri.RowCount; i++)
                        {
                            StokMiktar = StokIslemleri.StokSayisiBul(gvKalemBilgileri.GetRowCellValue(e.RowHandle, "Stok_Kodu").ToString());
                            if (Convert.ToInt32(gvKalemBilgileri.GetRowCellValue(i, "Miktar")) > StokMiktar)
                            {
                                XtraMessageBox.Show("Yeterli Stoğunuz Bulunmamaktadır.En Fazla " + StokMiktar + " Adet Stok Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                gvKalemBilgileri.SetRowCellValue(e.RowHandle, "Miktar", StokMiktar);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
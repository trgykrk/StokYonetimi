using DevExpress.Customization;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NLog;
using StokYonetimi.Class;
using StokYonetimi.Migrations;
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
    public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string AktifKullanici = "";
        public static string Version = "";
        public frmAnaForm()
        {
            InitializeComponent();
            lblAktifKullaniciAdi.Caption = "Aktik Kullanici : " + AktifKullanici;
            this.Text += " " + Version;
            if (Settings.Default.AktifKullaniciAdi != "ADMIN")
            {
                rpProgramTanimlamalari.Visible = false;
            }
        }
       
        Methods mtd = new Methods();
        Logger logger = LogManager.GetCurrentClassLogger();
        private void btn_Anasayfa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmAnaSayfa());
        }
        private void btnStokList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmStokListesi());
        }
        private void btnStokEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmStokKayıt().ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error("Stok Listesi Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmCariListesi());
        }
        private void btnCariEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmCariKayit().ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error("Cari Ekleme Formu Yüklenirken  Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSatisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmSatisListesi());
        }
        private void btnSatisYap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmSatisYap().ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error("Satış Yap Formu  Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmAlislar());
        }
        private void btnAlisYap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmAlisYap().ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error("Alış İşlemleri Formu Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnLogListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmLoglar());
        }
        private void btnFaturaOlustur_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmFatura().ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error("Fatura Oluşturma Ekranı Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFaturaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Genel_Form_Islemleri.formAc(new frmFaturaListesi());
        }
        private void btnVersionYukselt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ExecuteMigration.VersionYukselt();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVersionDusur_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ExecuteMigration.VersionDusur(2);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void btnKullaniciDegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            AktifKullanici = "";
            new frmGIRIS().ShowDialog();
            if (frmGIRIS.girisOK)
            {
                lblAktifKullaniciAdi.Caption = "Aktik Kullanici : " + AktifKullanici;
            }
        }        
        private void btnProgramTanimlamalari_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                new frmYetkiliLoginEkranı().ShowDialog();               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(e.Item.Caption.ToString()))
                {
                    Settings.Default.Gorunum = e.Item.Caption.ToString();
                }
                else
                {
                    Settings.Default.Gorunum = "DevExpress Style";
                }
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
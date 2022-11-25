using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokYonetimi.Properties;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.Drawing.Drawing2D;
using StokYonetimi.Class;
using StokYonetimi.ObserverPattern;
using static StokYonetimi.Model.Faturalar;
using StokYonetimi.Formlar;

namespace StokYonetimi
{
    public partial class frmGIRIS : XtraForm
    {
        public static bool Goruldu = false;
        public static int imgSayac = 1;
        public static bool girisOK = false;
        public static string AktifKullanici = "";        
        
        public frmGIRIS()
        {
            InitializeComponent();
            Formlar.frmAnaForm.AktifKullanici = "";
            if (!string.IsNullOrEmpty(Settings.Default.AktifKullaniciAdi))
            {
                txtKullaniciAdi.Text = Settings.Default.AktifKullaniciAdi;
                txtSifre.Text = Settings.Default.AktifKullaniciSifresi;
                chkBeniHatirla.Checked = true;
            }
        }

        private void girisYap()
        {
            string sonuc = Kullanici_Islemleri.GirisKontrol(txtKullaniciAdi.Text, txtSifre.Text, chkBeniHatirla.Checked);
            if (sonuc == "TAMAM")
            {              
                girisOK = true;
                DateTime GününTarihi = Lisans_Islemleri.getTarihSaat();
                string lisansKontrol = Lisans_Islemleri.Lisans_Kontrol(GününTarihi, Settings.Default.LisansSahibi,Settings.Default.LisansKey);
                if (lisansKontrol == "Başarılı")
                {
                    Formlar.frmAnaForm.AktifKullanici = Settings.Default.AktifKullaniciAdi; ;
                    Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(lisansKontrol, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show(sonuc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (valKontrol.Validate())
            {
                girisYap();
                //Notification_Islemleri.Alert(AktifKullanici + " Kullanıcısı Sisteme Başarılı Bir Şekilde Giriş Sağladı.", frmNotification.enmType.Info);
            }
        }
        private void frmGIRIS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (valKontrol.Validate())
                {
                    girisYap();
                }
            }
        }
        
        private void frmGIRIS_Load(object sender, EventArgs e)
        {
            tmrImage.Start();
        }

        Formlar.frmYetkiliLoginEkranı frmYetkili;
        private void btnAyarlar_Click(object sender, EventArgs e)
        {          
            if (frmYetkili == null || frmYetkili.IsDisposed)
            {
                frmYetkili = new Formlar.frmYetkiliLoginEkranı();
                frmYetkili.ShowDialog();
            }
        }    
    }
}
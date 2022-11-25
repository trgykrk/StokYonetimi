using DevExpress.XtraEditors;
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
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        public frmAyarlar()
        {
            InitializeComponent();
            txtSunucu.Text = Settings.Default.Sunucu;
            txtDatabase.Text = Settings.Default.Database;
            txtSqlKullaniciAdi.Text = Settings.Default.SqlKullaniciAdi;
            txtSqlSifre.Text = Settings.Default.SqlSifresi;
            txtLisansSahibi.Text = Settings.Default.LisansSahibi;
            txtLisansAnahtarı.Text = Settings.Default.LisansKey;
            dteLisansBasTarih.EditValue = Settings.Default.LisansBasTar;
            dteLisansBitTarih.EditValue = Settings.Default.LisansBitTar;
        }

        public static string LisansDogrulama = "";
        private void btnCikis_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTanımla_Click(object sender, EventArgs e)
        {
            try
            {
                string sonuc = Lisans_Islemleri.setLisans(txtLisansSahibi.Text, Convert.ToDateTime(dteLisansBasTarih.EditValue), Convert.ToDateTime(dteLisansBitTarih.EditValue), txtLisansAnahtarı.Text);
                if (sonuc == "Başarılı")
                {
                    Settings.Default.Sunucu = txtSunucu.Text;
                    Settings.Default.Database = txtDatabase.Text;
                    Settings.Default.SqlKullaniciAdi = txtSqlKullaniciAdi.Text;
                    Settings.Default.SqlSifresi = txtSqlSifre.Text;
                    Settings.Default.LisansSahibi = txtLisansSahibi.Text;
                    Settings.Default.LisansKey = txtLisansAnahtarı.Text;
                    Settings.Default.LisansBasTar = Convert.ToDateTime(dteLisansBasTarih.EditValue.ToString());
                    Settings.Default.LisansBitTar = Convert.ToDateTime(dteLisansBitTarih.EditValue.ToString());
                    if (XtraMessageBox.Show("Tanımlamalar Kaydedilecektir.Onaylıyor Musunuz ? ", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Settings.Default.Save();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lisans Bilgileri Kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDogrulama_Click(object sender, EventArgs e)
        {
            try
            {
                string sonuc = Lisans_Islemleri.Lisans_Anahtarı_Dogrulama(txtLisansAnahtarı.Text);
                if (sonuc == "Doğrulandı")
                {
                    Lisans_Islemleri.setLisansKey(txtLisansAnahtarı.Text);
                    dteLisansBasTarih.Enabled = true;
                    dteLisansBitTarih.Enabled = true;
                    btnTanımla.Enabled = true;
                    //XtraMessageBox.Show("Lisans Doğrulama Başarılı!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dteLisansBasTarih.Enabled = false;
                    dteLisansBitTarih.Enabled = false;
                }
                XtraMessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            try
            {
                btnTanımla.Enabled = false;
                txtSunucu.Text = Settings.Default.Sunucu;
                txtDatabase.Text = Settings.Default.Database;
                txtSqlKullaniciAdi.Text = Settings.Default.SqlKullaniciAdi;
                txtSqlSifre.Text = Settings.Default.SqlSifresi;
                txtLisansSahibi.Text = Settings.Default.LisansSahibi;
                txtLisansAnahtarı.Text = Settings.Default.LisansKey;
                dteLisansBasTarih.EditValue = Settings.Default.LisansBasTar;
                dteLisansBitTarih.EditValue = Settings.Default.LisansBitTar;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
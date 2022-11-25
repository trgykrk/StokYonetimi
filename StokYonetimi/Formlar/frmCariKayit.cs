using DevExpress.XtraEditors;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokYonetimi.Class;

namespace StokYonetimi.Formlar
{
    public partial class frmCariKayit : DevExpress.XtraEditors.XtraForm
    {
        public frmCariKayit()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        bool CariDurumu;
        public void Temizle()
        {
            try
            {
                txtCariKodu.Text = "";
                txtAdi.Text = "";
                txtSoyadi.Text = "";
                txtTCKimlikNo.Text = "";
                txtTelefonNumarasi.Text = "";
                txtMailAdresi.Text = "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                CariDurumu = CariIslemleri.MukerrerCari(txtCariKodu.Text);
                if (CariDurumu == false)
                {
                    XtraMessageBox.Show("Cari Zaten Kayıtlı Durumda!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTCKimlikNo.Text == "" || txtMailAdresi.Text == "" || txtTelefonNumarasi.Text == "" || txtAdresBilgisi.Text == "" || txtCariKodu.Text == "")
                    {
                        XtraMessageBox.Show("Lütfen Alanları Boş Geçmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (XtraMessageBox.Show("Müşteri  " + txtCariKodu.Text + " Cari Kodu İle Sisteme  Eklenecektir.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CariIslemleri.CariKayit(txtCariKodu.Text, txtAdi.Text, txtSoyadi.Text, txtTCKimlikNo.Text, txtMailAdresi.Text, txtTelefonNumarasi.Text, txtAdresBilgisi.Text);
                            Temizle();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                logger.Error("Cari Eklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVazgec_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error("Form Kapatılırken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
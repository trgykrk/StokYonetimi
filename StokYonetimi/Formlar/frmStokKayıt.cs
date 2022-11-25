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
    public partial class frmStokKayıt : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKayıt()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();      
        Logger logger = LogManager.GetCurrentClassLogger();
        bool StokDurumu;
        public void Temizle()
        {
            try
            {
                txtStokAdi.Text = "";
                txtStokKodu.Text = "";
                txtStokBirimi.Text = "";
                txtAlisFiyati.Text = "";
                txtSatisFiyati.Text = "";
                nudMiktar.Value = 0;
                txtAciklama.Text = "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
                StokDurumu=StokIslemleri.MukerrerStok(txtStokKodu.Text);
                if (StokDurumu == false)
                {
                    XtraMessageBox.Show("" + txtStokKodu.Text + " Kodlu Ürün  Sistemde Mevcut.  ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtStokKodu.Text == "" || txtStokAdi.Text == "" || txtStokBirimi.Text == "" || txtAlisFiyati.Text == "" || txtSatisFiyati.Text == "" || nudMiktar.Text == "")
                    {
                        logger.Info("Stok Kaydedilirken Hata Oluştu..");
                        XtraMessageBox.Show("Lütfen Alanları Boş Geçmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if ((XtraMessageBox.Show("Ürün  " + txtStokKodu.Text + " Stok Kodu İle Sisteme  Eklenecektir.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            StokIslemleri.StokKayit(txtStokKodu.Text, txtStokAdi.Text, txtStokBirimi.Text, Convert.ToDecimal(txtAlisFiyati.EditValue), Convert.ToDecimal(txtSatisFiyati.EditValue), nudMiktar.Text, txtAciklama.Text);
                            Temizle();
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                logger.Error("Stok Kaydedilirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
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
    public partial class frmAlisYap : DevExpress.XtraEditors.XtraForm
    {
        public frmAlisYap()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        HareketIslemleri hrk = new HareketIslemleri();

        private void btnVazgec_Click(object sender, EventArgs e)
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

        private void btnAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (lueStokKodu.Text == "" || txtStokAdi.Text == "" || txtBirim.Text == "" || txtAlisFiyati.Text == "" || nudMiktari.Text == "" || lueCariKodu.Text == "" || txtCariAdi.Text == "" || txtCariSoyadi.Text == "" || txtIslemTarihi.Text == "")
                {
                    logger.Info("Alış İşlemi Yapılırken Boş Kayıt Eklenmeye çalışıldı.");
                    XtraMessageBox.Show("Lütfen Alanları Boş Geçmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {                 
                    txtToplamTutar.Text=Convert.ToString(hrk.TutarHesapla(Convert.ToDouble(nudMiktari.Text), Convert.ToDouble(txtAlisFiyati.Text)));

                    if (XtraMessageBox.Show("Alış Faturanız " + txtToplamTutar.Text + "TL tutarında oluşturulacak.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {                    
                        hrk.AlisYap(Convert.ToDateTime(txtIslemTarihi.Text),Convert.ToDouble(nudMiktari.Text),Convert.ToDecimal(txtAlisFiyati.Text),Convert.ToDecimal(txtToplamTutar.Text),Convert.ToString(lueCariKodu.ItemIndex + 1), Convert.ToString(lueStokKodu.ItemIndex + 1));
                        this.Close();
                    }                 
                }
            }
            catch (Exception ex)
            {
                logger.Error("Kaydetme Esnasında Hata Alındı");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAlisYap_Load(object sender, EventArgs e)
        {
            try
            {
                hrk.StokGetir(lueStokKodu.Text);
                lueStokKodu.Properties.ValueMember = "ID";
                lueStokKodu.Properties.DisplayMember = "Stok_Kodu";
                lueStokKodu.EditValue = lueStokKodu.Properties.GetKeyValueByDisplayText(lueStokKodu.Text);
                lueStokKodu.Properties.DataSource = hrk.StokGetir(lueStokKodu.Text);

                hrk.CariGetir(lueCariKodu.Text);
                lueCariKodu.Properties.ValueMember = "ID";
                lueCariKodu.Properties.DisplayMember = "Cari_Kodu";
                lueCariKodu.Properties.DataSource = hrk.CariGetir(lueCariKodu.Text);
            }
            catch (Exception ex)
            {
                logger.Error("Form Yüklenirken  Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lueStokKodu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {             
                 hrk.StokKoduEditValueChanged(Convert.ToString(lueStokKodu.ItemIndex + 1));
                 txtStokAdi.Text = hrk.StokAdi;
                 txtBirim.Text = hrk.StokBirimi;
                 txtAlisFiyati.Text = Convert.ToString(hrk.AlisFiyati);
            }
            catch (Exception ex)
            {
                logger.Error("Stok Kodu Seçilirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lueCariKodu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {               
                hrk.CariKoduEditValueChanged(Convert.ToString(lueCariKodu.ItemIndex + 1));
                txtCariAdi.Text = hrk.CariAdi;
                txtCariSoyadi.Text = hrk.CariSoyadi;
            }

            catch (Exception ex)
            {
                logger.Error("Cari Kodu Seçilirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
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

namespace StokYonetimi.Formlar
{
    public partial class frmYetkiliLoginEkranı : DevExpress.XtraEditors.XtraForm
    {
        public frmYetkiliLoginEkranı()
        {
            InitializeComponent();
        }
        static int sayac = 3;

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Formlar.frmAyarlar frm1;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac > 0)
                {
                    if (txtKullaniciAdi.Text == "a" && txtSifre.Text == "b")
                    {
                        string Giris = "Basarılı";
                        if(Giris == "Basarılı")
                        {                            
                            if (frm1 == null || frm1.IsDisposed)
                            {
                                frm1 = new Formlar.frmAyarlar();
                                frm1.ShowDialog();
                                this.Close();
                            }
                        }                      
                    }
                    else
                    {
                        XtraMessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır.Tekrar Deneyin." + sayac + " Deneme  Hakkınız Kalmıştır!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        sayac--;
                    }
                }
                else
                {
                    XtraMessageBox.Show("3 Deneme  Hakkınız Sona Ermiştir.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
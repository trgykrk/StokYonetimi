using DevExpress.XtraEditors;
using StokYonetimi.Class;
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
    public partial class frmCariRehber : DevExpress.XtraEditors.XtraForm
    {
        public frmCariRehber()
        {
            InitializeComponent();
            
        }
 
        public int Modul = 0;
        private void SecimYap()
        {
            if (gvCariRehber.RowCount > 0)
            {
                if (Modul == 0)
                {
                    frmFatura ftr = (frmFatura)Application.OpenForms["frmFatura"];
                    ftr.btnCariSec.Text = gvCariRehber.GetFocusedRowCellValue("Cari_Kodu").ToString();
                    ftr.txtCariAdiSoyadi.Text = (gvCariRehber.GetFocusedRowCellValue("Cari_Adi").ToString()) + " " + (gvCariRehber.GetFocusedRowCellValue("Cari_Soyadi").ToString());
                    ftr.txtAdresBilgisi.Text = gvCariRehber.GetFocusedRowCellValue("Cari_Adres").ToString();
                    ftr.txtMailAdresi.Text = gvCariRehber.GetFocusedRowCellValue("Cari_Mail").ToString();
                    ftr.txtTelefon.Text = gvCariRehber.GetFocusedRowCellValue("Cari_Telefon").ToString();
                    this.Close();
                }               
            }
            else
            {
                XtraMessageBox.Show("Kayıt Yokken Seçim Yapamazsınız..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCariRehber_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modul == 0)
                {
                   // CariIslemleri.CariListesiGetir();
                    grdCariRehber.DataSource = CariIslemleri.CariListesiGetir();
                }               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvCariRehber_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SecimYap();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
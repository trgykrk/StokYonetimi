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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace StokYonetimi.Formlar
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCariListesi()
        {
            InitializeComponent();
            Genel_Cikti_Islemleri.GorunumuYukle(gvCariListesi, this);
        }
        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            try

            {
                // CariIslemleri.CariListesiGetir();
                grdCariListesi.DataSource = CariIslemleri.CariListesiGetir();
            }
            catch (Exception ex)
            {
                logger.Error("Cari Listesi Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvCariListesi.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Seçili Cari Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dr = gvCariListesi.GetDataRow(gvCariListesi.FocusedRowHandle);
                    string p1, p2;
                    p1 = dr[0].ToString();
                    p2 = dr[1].ToString();
                    CariIslemleri.CariSil(p1, p2);
                    grdCariListesi.DataSource = CariIslemleri.CariListesiGetir();
                    //CariIslemleri.CariListesiGetir();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvCariListesi.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Seçili Cari Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String CariKodu, CariAdi, CariSoyadi, TCKimlikNo, MailAdresi, Telefon, AdresBilgisi;
                    int ID;
                    CariKodu = gvCariListesi.GetFocusedRowCellValue("Cari_Kodu").ToString();
                    CariAdi = gvCariListesi.GetFocusedRowCellValue("Cari_Adi").ToString();
                    CariSoyadi = gvCariListesi.GetFocusedRowCellValue("Cari_Soyadi").ToString();
                    TCKimlikNo = gvCariListesi.GetFocusedRowCellValue("TC_KimlikNo").ToString();
                    MailAdresi = gvCariListesi.GetFocusedRowCellValue("Cari_Mail").ToString();
                    Telefon = gvCariListesi.GetFocusedRowCellValue("Cari_Telefon").ToString();
                    AdresBilgisi = gvCariListesi.GetFocusedRowCellValue("Cari_Adres").ToString();
                    ID = Convert.ToInt32(gvCariListesi.GetFocusedRowCellValue("ID").ToString());
                    CariIslemleri.CariGuncelle(CariKodu, CariAdi, CariSoyadi, TCKimlikNo, MailAdresi, Telefon, AdresBilgisi, ID);
                    CariIslemleri.CariListesiGetir();
                    //CariIslemleri.CariListesiGetir();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.ExceleGonder("Cari Listesi", gvCariListesi);
        }
        private void btnGorunumuSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.GorunumuSakla(gvCariListesi, this);
        }
        private void grdCariListesi_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvCariListesi.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = gvCariListesi.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            ppmCariListesi.ShowPopup(Control.MousePosition);
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
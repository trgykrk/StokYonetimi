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
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmStokListesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            try
            {
                grdStokListesi.DataSource=StokIslemleri.StokListesiGetir();
                Genel_Cikti_Islemleri.GorunumuYukle(gvStokListesi,this);
            }
            catch (Exception ex)
            {
                logger.Error("Stok Listesi Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvStokListesi.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Seçili Stok Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    DataRow dr = gvStokListesi.GetDataRow(gvStokListesi.FocusedRowHandle);
                    string p1,p2;                 
                    p1 = dr[0].ToString();
                    p2 = dr[1].ToString();
                    StokIslemleri.StokSil(p1,p2);
                    grdStokListesi.DataSource = StokIslemleri.StokListesiGetir();                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvStokListesi_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvStokListesi.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = gvStokListesi.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            ppmStokListesi.ShowPopup(Control.MousePosition);
                        }
                    }
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
                if (gvStokListesi.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Seçili Stok Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String StokKodu, StokAdi, StokBirim, StokAciklama, StokImage;
                    int ID, StokMiktar;
                    decimal StokAlisfiyat, StokSatisFiyat;
                    StokKodu = gvStokListesi.GetFocusedRowCellValue("Stok_Kodu").ToString();
                    StokAdi = gvStokListesi.GetFocusedRowCellValue("Stok_Adi").ToString();
                    StokBirim = gvStokListesi.GetFocusedRowCellValue("Stok_Birim").ToString();
                    StokAlisfiyat = Convert.ToDecimal(gvStokListesi.GetFocusedRowCellValue("Stok_AlisFiyat").ToString());
                    StokSatisFiyat = Convert.ToDecimal(gvStokListesi.GetFocusedRowCellValue("Stok_SatisFiyat").ToString());
                    StokMiktar = Convert.ToInt32(gvStokListesi.GetFocusedRowCellValue("Stok_Miktari").ToString());
                    StokAciklama = gvStokListesi.GetFocusedRowCellValue("Stok_Aciklamasi").ToString();
                    StokImage = gvStokListesi.GetFocusedRowCellValue("Stok_Image").ToString();
                    ID = Convert.ToInt32(gvStokListesi.GetFocusedRowCellValue("ID").ToString());                   
                    StokIslemleri.StokGuncelle(StokKodu, StokAdi, StokBirim, StokAlisfiyat, StokSatisFiyat, StokMiktar, StokAciklama, StokImage, ID);
                    StokIslemleri.StokListesiGetir();                   
                }             
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Genel_Cikti_Islemleri.ExceleGonder("Stok Listesi",gvStokListesi);
        }
        private void btnGorunumuSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.GorunumuSakla(gvStokListesi, this);
        }
        private void gvStokListesi_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvStokListesi.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = gvStokListesi.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            ppmStokListesi.ShowPopup(Control.MousePosition);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

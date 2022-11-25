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
using StokYonetimi.Class;
using StokYonetimi.Formlar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DataAccess.Native.Data;
using DataTable = System.Data.DataTable;
using DataColumn = System.Data.DataColumn;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace StokYonetimi.Formlar
{
    public partial class frmStokRehber : DevExpress.XtraEditors.XtraForm
    {
        public frmStokRehber()
        {
            InitializeComponent();
        }

        public static string StokKodlari = "";
        public int Modul = 0;

        private void SecimYap()
        {
            try
            {
                if (gvStokRehber.RowCount > 0)
                {
                    if (Modul == 1)
                    {
                        frmFatura ftr = (frmFatura)Application.OpenForms["frmFatura"];
                        ftr.BtnStokSeciniz.Text = gvStokRehber.GetFocusedRowCellValue("Stok_Kodu").ToString();
                        this.Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Kayıt Yokken Seçim Yapamazsınız..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmStokRehber_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modul == 1)
                {
                    grdStokRehber.DataSource = StokIslemleri.StokListesiGetir();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvStokRehber_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(gvStokRehber.GetFocusedRowCellValue("Stok_Miktari")) <= 0)
                {
                    XtraMessageBox.Show("Stok Sayınız Yetersiz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Genel_Grid_Islemleri.gridDoubleClick(gvStokRehber);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                frmFatura ftr = (frmFatura)Application.OpenForms["frmFatura"];
                //for (int i = 0; i < ftr.gvKalemBilgileri.RowCount; i++)
                //{
                //    ftr.gvKalemBilgileri.AddNewRow();
                //    ftr.grdKalemBilgileri.DataSource = Fatura_Islemleri.KalemEkle(gvStokRehber);
                //}
                int a = ftr.gvKalemBilgileri.RowCount;
                ftr.grdKalemBilgileri.DataSource = Fatura_Islemleri.KalemEkle(gvStokRehber);
                ftr.btnHesapla_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvStokRehber_MouseUp(object sender, MouseEventArgs e)
        {
            gridPopMenu(gvStokRehber, e);
        }
        private void gridPopMenu(GridView grid, MouseEventArgs e)
        {
            try
            {
                if (grid.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = grid.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            popMenu.ShowPopup(Control.MousePosition);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTumunuSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Grid_Islemleri.gridTumunuSec(gvStokRehber);
        }
        private void btnSecimleriKaldir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Grid_Islemleri.gridTumunuKaldir(gvStokRehber);
        }
    }
}
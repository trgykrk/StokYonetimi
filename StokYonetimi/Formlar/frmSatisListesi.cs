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
    public partial class frmSatisListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmSatisListesi()
        {
            InitializeComponent();
            Genel_Cikti_Islemleri.GorunumuYukle(gvSatisListesi, this);
        }
        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        HareketIslemleri hrk = new HareketIslemleri();
        private void frmSatisListesi_Load(object sender, EventArgs e)
        {
            try
            {
                grdSatisListesi.DataSource = hrk.SatisHareketleriGetir();
                gvSatisListesi.BestFitColumns();
            }
            catch (Exception ex)
            {
                logger.Error("Satış Listesi Yüklenirken  Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.ExceleGonder("Satış Hareket Listesi", gvSatisListesi);
        }
        private void btnGorunumuSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.GorunumuSakla(gvSatisListesi, this);
        }
        private void gvSatisListesi_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvSatisListesi.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = gvSatisListesi.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            ppMenu.ShowPopup(Control.MousePosition);
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
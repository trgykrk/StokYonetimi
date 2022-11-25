using DevExpress.DataAccess.Native.Data;
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
using System.Windows.Threading;
using System.Windows;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace StokYonetimi.Formlar
{
    public partial class frmAlislar : DevExpress.XtraEditors.XtraForm
    {
        public frmAlislar()
        {
            InitializeComponent();
            Genel_Cikti_Islemleri.GorunumuYukle(gvAlislar,this);
        }

        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        HareketIslemleri hrk = new HareketIslemleri();
        private void frmAlislar_Load(object sender, EventArgs e)
        {
            try
            {
                grdAlislar.DataSource = hrk.AlisHareketGetir();
            }
            catch (Exception ex)
            {
                logger.Error("Alış Listesi Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvAlislar_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (gvAlislar.DataRowCount > 0)
                {
                    GridHitInfo hitInfo = gvAlislar.CalcHitInfo(e.Location);
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
        private void btnExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.ExceleGonder("Alış Hareket Listesi", gvAlislar);
        }
        private void btnGorunumuSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Genel_Cikti_Islemleri.GorunumuSakla(gvAlislar,this);
        }
    }
}
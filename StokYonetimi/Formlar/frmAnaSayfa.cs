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

namespace StokYonetimi.Formlar
{
    public partial class frmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        Methods mtd = new Methods();
    
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {             
                grdKritikSeviyedekiStoklar.DataSource = mtd.KritikSeviyeStoklar(15);
                grdMusteriAlisHareketleri.DataSource = mtd.MusteriHareket();
            }
            catch (Exception ex)
            {
                logger.Error("Anasayfa Yüklenirken Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
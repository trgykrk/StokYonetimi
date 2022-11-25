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
    public partial class frmLoglar : DevExpress.XtraEditors.XtraForm
    {
        public frmLoglar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        Logger logger = LogManager.GetCurrentClassLogger();
        LogIslemlerı lg = new LogIslemlerı();


        private void frmLoglar_Load(object sender, EventArgs e)
        {
            try
            {
                grdLoglar.DataSource = lg.LogKayitlariniGetir();
                logger.Info("Log Listesi Yükleme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                logger.Error("Log Listesi Yüklenirken  Hata Oluştu.");
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

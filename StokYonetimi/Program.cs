using FluentMigrator.Runner;
using FluentMigrator;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokYonetimi.Class;
using StokYonetimi.Properties;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using Microsoft.Data.ConnectionUI;

namespace StokYonetimi
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(!string.IsNullOrEmpty(Settings.Default.Gorunum) ? Settings.Default.Gorunum : "Devexpress Style");
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            WindowsFormsSettings.AllowRoundedWindowCorners = DevExpress.Utils.DefaultBoolean.True;
            if (!string.IsNullOrEmpty(Settings.Default.CS))
            {
                Application.Run(new frmGIRIS());
                if (frmGIRIS.girisOK)
                {
                    Application.Run(new Formlar.frmAnaForm());
                }
            }
            else
            {
                DataConnectionDialog dc = new DataConnectionDialog();
                DataSource.AddStandardDataSources(dc);
                if (DataConnectionDialog.Show(dc) == DialogResult.OK)
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                    {
                        ConnectionString = dc.ConnectionString
                    };
                    Settings.Default.CS = dc.ConnectionString;
                    Settings.Default.Database = builder.InitialCatalog.ToString();
                    Settings.Default.Save();
                    XtraMessageBox.Show("Bağlantı bilgileri kaydedildi.Ayarların aktif olması için programı yeniden başlatınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}

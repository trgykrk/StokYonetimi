using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using PusherServer;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
    public class Genel_Cikti_Islemleri
    {
        public static void ExceleGonder(string raporAdi, GridView gv)
        {
            try
            {
                if (gv.DataRowCount > 0)
                {
                    var svDialog = new SaveFileDialog
                    {
                        FileName = raporAdi + " (" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")",
                        Filter = "XLS Dosyaları (*.xls)|*.xls",
                        InitialDirectory = "c:"
                    };
                    if (svDialog.ShowDialog() == DialogResult.OK)
                    {
                        var _Options = new XlsExportOptions
                        {
                            SheetName = raporAdi + " (" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ")"
                        };
                        gv.ExportToXls(svDialog.FileName, _Options);
                        if (XtraMessageBox.Show("Kaydedilen Dosyayı Şimdi Görmek İster misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(svDialog.FileName);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Ekranda Veri Olmadan Excel'e Gönderme İşlemi Yapamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void YaziciListesiGetir(ImageComboBoxEdit cbx)
        {
            cbx.Properties.Items.Clear();
            string str = null;
            foreach (string str_loopVariable in PrinterSettings.InstalledPrinters)
            {
                str = str_loopVariable;
                ImageComboBoxItem item = new ImageComboBoxItem
                {
                    Description = str.ToString(),
                    ImageIndex = 0,
                    Value = str.ToString()
                };
                cbx.Properties.Items.Add(item);
            }
        }
        public static void GorunumuSakla(GridView layout, Form frm)
        {
            try
            {
                layout.SaveLayoutToXml(Application.StartupPath + "\\Views\\" + Settings.Default.AktifKullaniciAdi + "_" + frm.Name + "_" + layout.Name + ".xml");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void GorunumuYukle(GridView layout, Form frm)
        {
            try
            {
                layout.RestoreLayoutFromXml(Application.StartupPath + "\\Views\\" + Settings.Default.AktifKullaniciAdi + "_" + frm.Name + "_" + layout.Name + ".xml");
            }
            catch (Exception) { }
        }

        [HttpPost]
        public static async Task<ActionResult> Notification_(string message)
        {
            var options = new PusherOptions();
            options.Cluster = "eu";

            var pusher = new Pusher("1351571", "030410c7a51118a593e7", "7a832e8970a45fdb6e55", options);
            var result = await pusher.TriggerAsync("my-channel", "my-event", new { message = message });
            return new HttpStatusCodeResult((int)HttpStatusCode.OK);
           
        }
    }
}

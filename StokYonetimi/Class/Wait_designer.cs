using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
    public sealed class clsWAIT<TSplash> : IDisposable where TSplash : WaitForm
    {
        public clsWAIT(string baslik)
        {
            Show(baslik);
        }
        public void Show(string baslik)
        {
            foreach (var openForm in Application.OpenForms)
                if (openForm is TSplash)
                    return;
            SplashScreenManager.ShowForm(typeof(TSplash));
            SplashScreenManager.Default.SetWaitFormDescription(baslik);
          
        }
        public void Dispose()
        {
            SplashScreenManager.CloseForm(false);
            Cursor.Current = Cursors.Default;
        }
    }
}

using StokYonetimi.Formlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi.Class
{
    public class Notification_Islemleri
    {
        public static void Alert(string msg, frmNotification.enmType type)
        {
            frmNotification frm = new frmNotification();
            frm.showAlert(msg, type);
        }
    }
}

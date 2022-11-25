using DevExpress.XtraEditors;
using StokYonetimi.Formlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StokYonetimi.Class
{
    public class Genel_Form_Islemleri
    {
        public static void formAc(XtraForm formName)
        {
            try
            {
                using (new clsWAIT<frmWaitBar>("İşleminiz gerçekleştiriliyor..."))
                {
                    formName.MdiParent = Application.OpenForms["frmAnaForm"];
                    formName.TopLevel = false;
                    formName.Dock = DockStyle.Fill;
                    formName.Show();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bu modülü kullanma izniniz bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

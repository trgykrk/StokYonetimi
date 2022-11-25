using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
    public class FileLogger : IObserver<Object>
    {
        TraffickHandler thandler = null;
        StringBuilder stringbuilder;

        public FileLogger(TraffickHandler thandler)
        {
            this.thandler = thandler;
            this.thandler.Subscribe(this);
            stringbuilder=new StringBuilder();
        }
        public void OnCompleted()
        {
            //throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            //throw new NotImplementedException();
        }

        public void OnNext(object value)
        {
            //throw new NotImplementedException();
            XtraMessageBox.Show("Log Dosyasına  Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            stringbuilder.Append((String)value);
            System.IO.File.AppendAllText("templog.txt", stringbuilder.ToString());
            stringbuilder.Clear();
        }
    }
}

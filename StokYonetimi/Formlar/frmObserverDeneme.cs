using DevExpress.XtraEditors;
using StokYonetimi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Formlar
{
    public partial class frmObserverDeneme : DevExpress.XtraEditors.XtraForm,IObserver<Object>
    {
        TraffickHandler thandler = null;
        public frmObserverDeneme()
        {
            InitializeComponent();
        }
        public frmObserverDeneme(TraffickHandler obj)
        {
            thandler = obj;
            InitializeComponent();
            thandler.Subscribe(this);
        }

        //static TraffickHandler thandler;
        //static EmailNatification email;
        //static FileLogger logger;

        //public static void StartGUI()
        //{
        //    thandler = new TraffickHandler();
        //    thandler.InitializationComplete();
        //    email = new EmailNatification(thandler);
        //    logger = new FileLogger(thandler);


        //}
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String data = textEdit1.Text;
            thandler.AddToQueue(data);
        }

        public void OnNext(object value)
        {
            //throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
           // throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            //throw new NotImplementedException();
        }
    }
}
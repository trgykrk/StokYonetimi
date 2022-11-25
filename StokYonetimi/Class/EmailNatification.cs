using DevExpress.XtraEditors;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
    public class EmailNatification : IObserver<Object>
    {
        TraffickHandler thandler = null;

        public EmailNatification(TraffickHandler thandler)
        {
            this.thandler = thandler;
            this.thandler.Subscribe(this);
        }
        void IObserver<object>.OnCompleted()
        {
            // throw new NotImplementedException();
        }

        void IObserver<object>.OnError(Exception error)
        {
            //throw new NotImplementedException();
        }

        void IObserver<object>.OnNext(object value)
        {
            //throw new NotImplementedException();
            if (Settings.Default.AktifKullaniciAdi == "Turgay")
            {
                XtraMessageBox.Show("E-mail Kaydı oluşturuldu.");
                String data = (String)value;
            }

            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    SmtpClient smtpServer = new SmtpClient("turgay_gs_58@hotmail.com");
            //    mail.From = new MailAddress("trgkarakoc@gmail.com");
            //    mail.To.Add("intentedRecipient@whateverEmail.com");
            //    mail.Subject = "testing data";
            //    mail.Body = data;

            //    smtpServer.Port = 134;
            //    smtpServer.Credentials = new System.Net.NetworkCredential("userName", "userPassword");
            //    smtpServer.EnableSsl = true;
            //    smtpServer.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            //}
        }
    }
}

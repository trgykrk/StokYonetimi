using DevExpress.XtraEditors;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP.Server;

namespace StokYonetimi.Formlar
{
    public partial class frmClient : DevExpress.XtraEditors.XtraForm
    {
        public frmClient()
        {
            InitializeComponent();
        }
        
        SimpleTcpClient client;
        SimpleTcpServer server;

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            
            memAciklama.Invoke((MethodInvoker)delegate ()
            {
                memAciklama.Text += e.MessageString;
                //e.ReplyLine(string.Format("Açıklama: {0}", e.MessageString));
            });
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            memAciklama.Invoke((MethodInvoker)delegate ()
            {
                memAciklama.Text += e.MessageString;
               // e.ReplyLine(string.Format("Açıklama: {0}", e.MessageString));
            });
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
           try
            {
                server = new SimpleTcpServer();
                client = new SimpleTcpClient();
                client.StringEncoder = Encoding.UTF8;
                //client.DataReceived += Client_DataReceived;
                //server.DataReceived += Server_DataReceived;
                client.DataReceived += Server_DataReceived;


                client.Delimiter = 0x13;//enter
                client.StringEncoder = Encoding.UTF8;
                client.DataReceived += Server_DataReceived;
                //client.DataReceived += Client_DataReceived;


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
           try
            {   
                btnBaglan.Enabled = false;
                client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
                
            }
            catch (Exception ex)
            {              
                XtraMessageBox.Show("Bağlantı Sağlanamadı."+ ex.Message + "", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBaglan.Enabled = true;               
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {               
                client.WriteLineAndGetReply(memMesaj.Text, TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
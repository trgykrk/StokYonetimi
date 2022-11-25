using DevExpress.XtraEditors;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SimpleTCP.Server;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Message = SimpleTCP.Message;
using System.Net.Sockets;
using System.Globalization;
using System.Security;
using System.Net;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Runtime.InteropServices;
using DevExpress.XtraPrinting;

namespace Server
{
    public partial class frmServer : DevExpress.XtraEditors.XtraForm
    {
        public frmServer()
        {
            InitializeComponent();
            //StringEncoder = Encoding.UTF8;
           // Delimiter = 19;
        }
        SimpleTcpServer server;
        SimpleTcpClient Client = new SimpleTcpClient();
        public event EventHandler<Message> DataReceived;
        private NetworkStream m_DataStream;
        private Socket m_ServerSocket;
        public Socket Server
        {
            get
            {
                return m_ServerSocket;
            }
            set
            {
                m_ServerSocket = value;
            }
        }


        private SimpleTcpServer _server = null;
        private bool m_CleanedUp;

        public Encoding StringEncoder
        {
            get;
            set;
        }

        public NetworkStream GetStream()
        {
           

            if (m_CleanedUp)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

           

            if (m_DataStream == null)
            {
                m_DataStream = new NetworkStream(Server, ownsSocket: true);
            }

            return m_DataStream;
        }

        public byte Delimiter
        {
            get;
            set;
        }



        private void frmServer_Load(object sender, EventArgs e)
        {
            try
            {
                server = new SimpleTcpServer();
                server.Delimiter = 0x13;//enter
                server.StringEncoder = Encoding.UTF8;
                //server.DataReceived += Server_DataReceived;
                server.DataReceived += Client_DataReceived;
                Client = new SimpleTcpClient();

               
                _server = new SimpleTcpServer();
                _server.Delimiter = 0x13;//enter
                _server.StringEncoder = Encoding.UTF8;
                _server.DataReceived += Server_DataReceived;
                //_server.DataReceived += Client_DataReceived;
                //Client = new SimpleTcpClient();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {

            memAciklama.Invoke((MethodInvoker)delegate ()
            {
                memAciklama.Text += e.MessageString;
                e.ReplyLine(string.Format("Açıklama: {0}", e.MessageString));
            });
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            memAciklama.Invoke((MethodInvoker)delegate ()
            {
                memAciklama.Text += e.MessageString;
                e.ReplyLine(string.Format("Açıklama: {0}", e.MessageString));
            });
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
           try
            {
               
                memAciklama.Text += "Server başlatıldı...";
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
                server.Start(ip, Convert.ToInt32(txtPort.Text));
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            try
            {
                if (server.IsStarted)
                {
                    server.Stop();
                    memAciklama.Text += "Server durduruldu...";                   
                }                  
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                Client.WriteLineAndGetReply(txtClienteGonder.Text, TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SimpleTCP.Message WriteLineAndGetReply(string data, TimeSpan timeout)
        {
            Message mReply = null;
            DataReceived += delegate (object s, Message e)
            {
                mReply = e;
            };
            WriteLine(data);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (mReply == null && stopwatch.Elapsed < timeout)
            {
                Thread.Sleep(10);
            }

            return mReply;
        }
        public void Yaz(byte[] data)
        {
            if (_server == null)
            {
                throw new Exception("Cannot send data to a null TcpClient (check to see if Connect was called)");
            }

            GetStream().Write(data, 0, data.Length);
        }

        public void Write(string data)
        {
            if (data != null)
            {
               
                if (server.StringEncoder.GetBytes(data) == null)
                {
                    string a = "Message";
                    StringEncoder.GetBytes(a);
                }
                byte[] b = server.StringEncoder.GetBytes(data);
                Yaz(b);
            }
        }

        public void WriteLine(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                if (data.LastOrDefault() != Delimiter)
                {
                    Write(data);                   
                }
                else
                {
                    Write(data);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        internal class Logging
        {
            private class NclTraceSource : TraceSource
            {
                internal NclTraceSource(string name)
                    : base(name)
                {
                }              
            }

            private static volatile bool s_LoggingEnabled = true;

            private static volatile bool s_LoggingInitialized;

            private static volatile bool s_AppDomainShutdown;

            private const int DefaultMaxDumpSize = 1024;

            private const bool DefaultUseProtocolTextOnly = false;

            private const string AttributeNameMaxSize = "maxdatasize";

            private const string AttributeNameTraceMode = "tracemode";

            private static readonly string[] SupportedAttributes = new string[2]
            {
            "maxdatasize",
            "tracemode"
            };

            private const string AttributeValueProtocolOnly = "protocolonly";

            private const string TraceSourceWebName = "System.Net";

            private const string TraceSourceHttpListenerName = "System.Net.HttpListener";

            private const string TraceSourceSocketsName = "System.Net.Sockets";

            private const string TraceSourceWebSocketsName = "System.Net.WebSockets";

            private const string TraceSourceCacheName = "System.Net.Cache";

            private const string TraceSourceHttpName = "System.Net.Http";

            private static TraceSource s_WebTraceSource;

            private static TraceSource s_HttpListenerTraceSource;

            private static TraceSource s_SocketsTraceSource;

            private static TraceSource s_WebSocketsTraceSource;

            private static TraceSource s_CacheTraceSource;

            private static TraceSource s_TraceSourceHttpName;

            private static object s_InternalSyncObject;

            private static object InternalSyncObject
            {
                get
                {
                    if (s_InternalSyncObject == null)
                    {
                        object value = new object();
                        Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
                    }

                    return s_InternalSyncObject;
                }
            }

        
            internal static bool On
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    return s_LoggingEnabled;
                }
            }

            internal static TraceSource Web
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_WebTraceSource;
                }
            }

            
            internal static TraceSource Http
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_TraceSourceHttpName;
                }
            }

            internal static TraceSource HttpListener
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_HttpListenerTraceSource;
                }
            }

            internal static TraceSource Sockets
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_SocketsTraceSource;
                }
            }

            internal static TraceSource RequestCache
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_CacheTraceSource;
                }
            }

            internal static TraceSource WebSockets
            {
                get
                {
                    if (!s_LoggingInitialized)
                    {
                        InitializeLogging();
                    }

                    if (!s_LoggingEnabled)
                    {
                        return null;
                    }

                    return s_WebSocketsTraceSource;
                }
            }

            

            internal static bool IsVerbose(TraceSource traceSource)
            {
                return ValidateSettings(traceSource, TraceEventType.Verbose);
            }

            private static bool GetUseProtocolTextSetting(TraceSource traceSource)
            {
                bool result = false;
                if (traceSource.Attributes["tracemode"] == "protocolonly")
                {
                    result = true;
                }

                return result;
            }

            private static int GetMaxDumpSizeSetting(TraceSource traceSource)
            {
                int result = 1024;
                if (traceSource.Attributes.ContainsKey("maxdatasize"))
                {
                    try
                    {
                        result = int.Parse(traceSource.Attributes["maxdatasize"], NumberFormatInfo.InvariantInfo);
                        return result;
                    }
                    catch (Exception ex)
                    {
                        if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
                        {
                            throw;
                        }

                        traceSource.Attributes["maxdatasize"] = result.ToString(NumberFormatInfo.InvariantInfo);
                        return result;
                    }
                }

                return result;
            }

            private static void InitializeLogging()
            {
                lock (InternalSyncObject)
                {
                    if (!s_LoggingInitialized)
                    {
                        bool flag = false;
                        s_WebTraceSource = new NclTraceSource("System.Net");
                        s_HttpListenerTraceSource = new NclTraceSource("System.Net.HttpListener");
                        s_SocketsTraceSource = new NclTraceSource("System.Net.Sockets");
                        s_WebSocketsTraceSource = new NclTraceSource("System.Net.WebSockets");
                        s_CacheTraceSource = new NclTraceSource("System.Net.Cache");
                        s_TraceSourceHttpName = new NclTraceSource("System.Net.Http");
                        try
                        {
                            flag = (s_WebTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || s_HttpListenerTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || s_SocketsTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || s_WebSocketsTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || s_CacheTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || s_TraceSourceHttpName.Switch.ShouldTrace(TraceEventType.Critical));
                        }
                        catch (SecurityException)
                        {
                            Close();
                            flag = false;
                        }

                        if (flag)
                        {
                            AppDomain currentDomain = AppDomain.CurrentDomain;
                            
                            currentDomain.DomainUnload += AppDomainUnloadEvent;
                            currentDomain.ProcessExit += ProcessExitEvent;
                        }

                        s_LoggingEnabled = flag;
                        s_LoggingInitialized = true;
                    }
                }
            }

            private static void Close()
            {
                if (s_WebTraceSource != null)
                {
                    s_WebTraceSource.Close();
                }

                if (s_HttpListenerTraceSource != null)
                {
                    s_HttpListenerTraceSource.Close();
                }

                if (s_SocketsTraceSource != null)
                {
                    s_SocketsTraceSource.Close();
                }

                if (s_WebSocketsTraceSource != null)
                {
                    s_WebSocketsTraceSource.Close();
                }

                if (s_CacheTraceSource != null)
                {
                    s_CacheTraceSource.Close();
                }

                if (s_TraceSourceHttpName != null)
                {
                    s_TraceSourceHttpName.Close();
                }
            }

            private static void ProcessExitEvent(object sender, EventArgs e)
            {
                Close();
                s_AppDomainShutdown = true;
            }

            private static void AppDomainUnloadEvent(object sender, EventArgs e)
            {
                Close();
                s_AppDomainShutdown = true;
            }

            private static bool ValidateSettings(TraceSource traceSource, TraceEventType traceLevel)
            {
                if (!s_LoggingEnabled)
                {
                    return false;
                }

                if (!s_LoggingInitialized)
                {
                    InitializeLogging();
                }

                if (traceSource == null || !traceSource.Switch.ShouldTrace(traceLevel))
                {
                    return false;
                }

                if (s_AppDomainShutdown)
                {
                    return false;
                }

                return true;
            }

            private static string GetObjectName(object obj)
            {
                if (obj is Uri || obj is IPAddress || obj is IPEndPoint)
                {
                    return obj.ToString();
                }

                return obj.GetType().Name;
            }           

                

            
            

           
           

            internal static void Dump(TraceSource traceSource, object obj, string method, IntPtr bufferPtr, int length)
            {
                if (ValidateSettings(traceSource, TraceEventType.Verbose) && !(bufferPtr == IntPtr.Zero) && length >= 0)
                {
                    byte[] array = new byte[length];
                    Marshal.Copy(bufferPtr, array, 0, length);
                    Dump(traceSource, obj, method, array, 0, length);
                }
            }

            internal static void Dump(TraceSource traceSource, object obj, string method, byte[] buffer, int offset, int length)
            {
                if (!ValidateSettings(traceSource, TraceEventType.Verbose))
                {
                    return;
                }

                

                

                

                if (length < 0 || length > buffer.Length - offset)
                {
                    length = buffer.Length - offset;
                }

                do
                {
                    int num = Math.Min(length, 16);
                    string str = string.Format(CultureInfo.CurrentCulture, "{0:X8} : ", new object[1]
                    {
                    offset
                    });
                    for (int i = 0; i < num; i++)
                    {
                        str = str + string.Format(CultureInfo.CurrentCulture, "{0:X2}", new object[1]
                        {
                        buffer[offset + i]
                        }) + ((i == 7) ? '-' : ' ');
                    }

                    for (int j = num; j < 16; j++)
                    {
                        str += "   ";
                    }

                    str += ": ";
                    for (int k = 0; k < num; k++)
                    {
                        str += (char)((buffer[offset + k] < 32 || buffer[offset + k] > 126) ? 46 : buffer[offset + k]);
                    }

                   
                    offset += num;
                    length -= num;
                }
                while (length > 0);
            }
        }
        private Encoding _encoder = null;

        private byte _writeLineDelimiter;

        private bool _autoTrim = false;

        public byte[] Data
        {
            get;
            private set;
        }

        public string MessageString
        {
            get
            {
                if (_autoTrim)
                {
                    return _encoder.GetString(Data).Trim();
                }

                return _encoder.GetString(Data);
            }
        }

    }


}


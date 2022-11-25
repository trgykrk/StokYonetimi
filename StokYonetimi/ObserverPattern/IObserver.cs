using DevExpress.XtraEditors;
using StokYonetimi.Class;
using StokYonetimi.Formlar;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.ObserverPattern
{
    interface ISubject
    {
        void AddMember(IObserver observer);
        void AddFatura();
        void Notify();
    }
    class Fatura : ISubject
    {
        private List<IObserver> _observers;
        public void AddFatura()
        {
            Notify();
        }
        public string FaturaNo
        {
            get
            {
                _faturaNo = Fatura_Islemleri.FaturaListesiGetir();
                return _faturaNo;
            }
            set
            {
                _faturaNo = value;
                Notify();
            }
        }
        private string _faturaNo;

        public Fatura()
        {
            _observers = new List<IObserver>();
        }
        public void AddMember(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveMember(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Add(this);
            });
        }
    }
    interface IObserver
    {
        void Add(ISubject subject);
    }

    public class FaturaBilgisi : IObserver
    {
        public string FaturaNumarasi { get; set; }
        public bool GorulduMu { get; set; }
        public FaturaBilgisi(string name, bool GorulduMu)
        {
            FaturaNumarasi = name;
            this.GorulduMu = GorulduMu;
        }
        void IObserver.Add(ISubject subject)
        {
            if (subject is Fatura fatura)
            {
                if (Settings.Default.AktifKullaniciAdi == "Turgay")
                {
                    if (frmGIRIS.Goruldu == false)
                    {
                        if (XtraMessageBox.Show(String.Format("{2} fatura numarası ile yeni fatura kesilmiştir.", FaturaNumarasi, GorulduMu, fatura.FaturaNo), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            frmGIRIS.Goruldu = true;                           
                        }
                    }
                }
            }
        }

        //class NewAgency : IObserver
        //{
        //    public string FaturaNumarasi { get; set; }
        //    public NewAgency(string name)
        //    {
        //        FaturaNumarasi = name;
        //    }
        //public void Add(ISubject subject)
        //{
        //    if (subject is Fatura fatura)
        //    {
        //        if (fatura.FaturaTutar > 0)
        //        {
        //            if (Settings.Default.AktifKullaniciAdi == "Turgay" )
        //            {
        //                XtraMessageBox.Show(String.Format("{0} fatura numarası ile {1} tutarında fatura kesilmiştir.", FaturaNumarasi, fatura.FaturaTutar), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //}
        //}
    }
}

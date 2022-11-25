using DevExpress.XtraEditors;
using StokYonetimi.ObserverPattern;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Model
{
    public class Faturalar 
    {        
        public class FaturaBilgileri
        {
            public int ID { get; set; }
            public string FaturaNo { get; set; }
            public DateTime FaturaTarihi { get; set; }
            public string FaturaTipi { get; set; }
            public string CariKodu { get; set; }
            public string CariAdiSoyadi { get; set; }
            public string Telefon { get; set; }
            public string Adres { get; set; }
            public string Mail { get; set; }
            public double AraToplam { get; set; }
            public double KdvToplam { get; set; }
            public double ToplamTutar { get; set; }
            public string KullaniciAdi { get; set; }
            public int BaslikRef { get; set; }
            public string StokKodu { get; set; }
            public string StokAdi { get; set; }
            public int StokMiktar { get; set; }
            public string StokBirim { get; set; }
            public double StokBirimFiyat { get; set; }
            public int KdvOran { get; set; }
            public double KdvTutar { get; set; }
            public double KalemAraToplam { get; set; }
            public double KalemToplamTutar { get; set; }
            
            //void IObserver.Add(ISubject subject)
            //{
            //    if (subject is Fatura fatura)
            //    {
            //        if (Settings.Default.AktifKullaniciAdi == "Turgay")
            //        {
            //             if (XtraMessageBox.Show(String.Format("{1} fatura numarası ile yeni fatura kesilmiştir.",FaturaNo, fatura.FaturaNo), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            //             {
            //                 fatura.Notify();
            //             }        
            //        }
            //    }
            //}
        }   
    }    
}

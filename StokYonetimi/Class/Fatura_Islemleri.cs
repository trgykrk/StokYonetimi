using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using StokYonetimi.Formlar;
using StokYonetimi.Model;
using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokYonetimi.Model.Faturalar;
using DataTable = System.Data.DataTable;

namespace StokYonetimi.Class
{
    public static class Fatura_Islemleri
    {
        static SqlBaglanti bgl = new SqlBaglanti();
        static string sqlText = "";
        static int kalemSay = 0;
        static bool Durum;
        static string FaturaSira = "";
        static string FaturaSeri = "";
        static string FaturaNo = "";
        public static DataTable dtUst = new DataTable("Baslik");
        public static DataTable dtKalem = new DataTable("Kalem");
        public static DataSet ds = new DataSet();

        public static decimal KdvHesapla(decimal BirimFiyat, int Miktar, int KdvOran)
        {
            decimal sonuc = (BirimFiyat * Miktar) * KdvOran / 100;
            return sonuc;
        }
        public static decimal AraToplamHesapla(decimal BirimFiyat, int Miktar)
        {
            decimal sonuc = (BirimFiyat * Miktar);
            return sonuc;
        }
        public static decimal ToplamTutarHesapla(decimal AraToplam, decimal KdvToplam)
        {
            decimal sonuc = (AraToplam + KdvToplam);
            return sonuc;
        }
        public static DataTable KalemEkle(GridView gv)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Stok_Adi");
            dt.Columns.Add("Stok_Kodu");
            dt.Columns.Add("Stok_SatisFiyat");
            dt.Columns.Add("Stok_Birim");
            dt.Columns.Add("Miktar");
            dt.Columns.Add("Kdv_Oran");
            dt.Columns.Add("Kdv_Tutari");
            dt.Columns["Miktar"].DefaultValue = "1";
            dt.Columns["Kdv_Oran"].DefaultValue = "18";

            if (Genel_Grid_Islemleri.gridSeciliSayisi(gv) > 0)
            {
                if (XtraMessageBox.Show("Seçili Stok Bilgileri Kaleme Eklenecek.Onaylıyormusunuz?", "Turgay Karakoç-Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = kalemSay; i < gv.RowCount; i++)
                    {
                        if (Convert.ToBoolean(gv.GetRowCellValue(i, "Sec")) == true)
                        {
                            DataRow dr = dt.NewRow();
                            dr["Stok_Adi"] = gv.GetRowCellValue(i, "Stok_Adi").ToString();
                            dr["Stok_Kodu"] = gv.GetRowCellValue(i, "Stok_Kodu").ToString();
                            dr["Stok_SatisFiyat"] = gv.GetRowCellValue(i, "Stok_SatisFiyat").ToString();
                            dr["Stok_Birim"] = gv.GetRowCellValue(i, "Stok_Birim").ToString();
                            dt.Rows.Add(dr);
                            dr["Kdv_Tutari"] = KdvHesapla(Convert.ToDecimal(gv.GetRowCellValue(i, "Stok_SatisFiyat").ToString()), 1, 18);
                            kalemSay++;
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Seçili Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }
        public static int CariRefBul(string CariKodu)
        {

            int sonuc = 0;
            sqlText = "SELECT ID FROM Cariler Where Cari_Kodu = '" + CariKodu + "'";
            SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            return sonuc;
        }
        public static int FaturaRefBul(string FaturaNo)
        {
            int sonuc = 0;
            sqlText = "SELECT ID FROM FaturaBaslik Where FaturaNo = '" + FaturaNo + "'";
            SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            return sonuc;
        }
        public static int StokRefBul(string StokKodu)
        {
            int sonuc = 0;
            sqlText = "SELECT ID FROM Stoklar Where Stok_Kodu = '" + StokKodu + "'";
            SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            return sonuc;
        }
        public static bool FaturaNumarasiKontrol(string FaturaNo)
        {
            SqlCommand komut = new SqlCommand("Select * From FaturaBaslik Where FaturaNo=@FaturaNo", bgl.baglanti());
            komut.Parameters.AddWithValue("@FaturaNo", FaturaNo);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Durum = false;
            }
            else
            {
                Durum = true;
            }
            bgl.baglanti().Close();
            return Durum;
        }
        public static string FaturaNoHesapla()
        {
            sqlText = "SELECT TOP(1)RIGHT(FaturaNo,13) FROM FaturaBaslik ORDER BY ID DESC";
            SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
            FaturaSira = Convert.ToString(cmd.ExecuteScalar());
            FaturaSira = (Convert.ToInt64(FaturaSira) + 1).ToString();
            sqlText = "SELECT TOP(1)LEFT(FaturaNo,3) FROM FaturaBaslik ORDER BY ID DESC";
            SqlCommand cmd1 = new SqlCommand(sqlText, bgl.baglanti());
            FaturaSeri = Convert.ToString(cmd1.ExecuteScalar());
            FaturaNo = FaturaSeri + FaturaSira;
            return FaturaNo;
        }
        public static void KalemOlustur(GridView grid, int faturaRef)
        {
            int stokRef = 0;
            string stokKodu = "";
            string stokAdi = "";
            int Miktar = 0;
            string Birim = "";
            decimal birimFiyat;
            int KdvOran = 18;
            decimal KdvTutar;
            decimal araToplam;
            decimal ToplamTutar;

            if (grid.RowCount > 0)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    stokRef = StokRefBul(grid.GetRowCellValue(i, "Stok_Kodu").ToString());
                    stokKodu = grid.GetRowCellValue(i, "Stok_Kodu").ToString();
                    stokAdi = grid.GetRowCellValue(i, "Stok_Adi").ToString();
                    Miktar = Convert.ToInt32(grid.GetRowCellValue(i, "Miktar").ToString());
                    Birim = grid.GetRowCellValue(i, "Stok_Birim").ToString();
                    birimFiyat = Convert.ToDecimal(grid.GetRowCellValue(i, "Stok_SatisFiyat").ToString());
                    KdvOran = Convert.ToInt32(grid.GetRowCellValue(i, "Kdv_Oran").ToString());
                    KdvTutar = Convert.ToDecimal(grid.GetRowCellValue(i, "Kdv_Tutari").ToString());
                    araToplam = Convert.ToDecimal(AraToplamHesapla(birimFiyat, Miktar));
                    ToplamTutar = ToplamTutarHesapla(araToplam, KdvTutar);
                    KalemKaydet(faturaRef, stokRef, stokKodu, stokAdi, Miktar, Birim, birimFiyat, KdvOran, KdvTutar, araToplam, ToplamTutar);
                }
            }
            else
            {
                XtraMessageBox.Show("Kalem Bilgisi Girmeden Fatura Kesemezsiniz..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void FaturaOlustur(string FaturaNumasi, string FaturaTipi, DateTime FaturaTarihi, string CariKodu, string AdiSoyadi, string Telefon, string Adres, string Mail, double AraToplam, double KdvToplam, double ToplamTutar, int CariRef)
        {
            SqlCommand komut_insert = new SqlCommand("insert into FaturaBaslik(FaturaNo,FaturaTipi,FaturaTarihi,CariKodu,CariAdiSoyadi,Telefon" +
            ",Adres,Mail,AraToplam,KdvToplam,ToplamTutar,CariRef,KullaniciRef,KullaniciAdi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11," +
            "@p12,@p13,@p14)", bgl.baglanti());
            komut_insert.Parameters.AddWithValue("@p1", FaturaNumasi);
            komut_insert.Parameters.AddWithValue("@p2", FaturaTipi);
            komut_insert.Parameters.AddWithValue("@p3", FaturaTarihi);
            komut_insert.Parameters.AddWithValue("@p4", CariKodu);
            komut_insert.Parameters.AddWithValue("@p5", AdiSoyadi);
            komut_insert.Parameters.AddWithValue("@p6", Telefon);
            komut_insert.Parameters.AddWithValue("@p7", Adres);
            komut_insert.Parameters.AddWithValue("@p8", Mail);
            komut_insert.Parameters.AddWithValue("@p9", AraToplam);
            komut_insert.Parameters.AddWithValue("@p10", KdvToplam);
            komut_insert.Parameters.AddWithValue("@p11", ToplamTutar);
            komut_insert.Parameters.AddWithValue("@p12", CariRef);
            komut_insert.Parameters.AddWithValue("@p13", Settings.Default.AktifKullaniciId);
            komut_insert.Parameters.AddWithValue("@p14", Settings.Default.AktifKullaniciAdi);
            komut_insert.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public static void KalemKaydet(int FaturaRef, int StokRef, string stokKodu, string stokAdi, int Miktar, string Birim, decimal birimFiyat, int KdvOran, decimal KdvTutar, decimal araToplam, decimal ToplamTutar)
        {
            SqlCommand komut_insert = new SqlCommand("insert into FaturaKalem(BaslikRef,StokRef,StokKodu,StokAdi,StokMiktar,StokBirim" +
                ",StokBirimFiyat,KdvOran,KdvTutar,AraToplam,ToplamTutar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut_insert.Parameters.AddWithValue("@p1", FaturaRef);
            komut_insert.Parameters.AddWithValue("@p2", StokRef);
            komut_insert.Parameters.AddWithValue("@p3", stokKodu);
            komut_insert.Parameters.AddWithValue("@p4", stokAdi);
            komut_insert.Parameters.AddWithValue("@p5", Miktar);
            komut_insert.Parameters.AddWithValue("@p6", Birim);
            komut_insert.Parameters.AddWithValue("@p7", birimFiyat);
            komut_insert.Parameters.AddWithValue("@p8", KdvOran);
            komut_insert.Parameters.AddWithValue("@p9", KdvTutar);
            komut_insert.Parameters.AddWithValue("@p10", araToplam);
            komut_insert.Parameters.AddWithValue("@p11", ToplamTutar);
            komut_insert.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        //public static DataTable FaturaListesiGetir(DateTime BasTar,DateTime BitTar,string FaturaTipi,string FaturaNo,string CariKodu)
        //{
        //    DataTable dt = new DataTable();
        //    sqlText = "SET DATEFORMAT DMY";
        //    sqlText += " SELECT * FROM FaturaBaslik FT ";
        //    sqlText += " LEFT JOIN FaturaKalem KL ON FT.ID=KL.FaturaRef";
        //    sqlText += " WHERE FaturaTarihi BETWEEN '" + BasTar.ToShortDateString() + "' AND '" + BitTar.ToShortDateString() + "'";
        //    if(FaturaTipi != "" && FaturaTipi != "Tümü")
        //    {
        //        if (FaturaTipi  == "SatisFaturasi")
        //        {
        //            FaturaTipi = "Satış Faturası";
        //        }
        //        else if(FaturaTipi == "AlisFaturasi")
        //        {
        //            FaturaTipi = "Alış Faturası";
        //        }
        //        sqlText += "AND  FaturaTipi = '" + FaturaTipi + "'";
        //    }
        //    if(FaturaNo != "")
        //    {
        //        sqlText += "AND  FaturaNo = '" + FaturaNo + "'";
        //    }
        //    if (CariKodu !="")
        //    {
        //        sqlText += "AND  CariKodu = '" + CariKodu + "'";
        //    }
        //    SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
        //    SqlDataAdapter da =new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    return dt;          
        //}
        public static string FaturaListesiGetir()
        {
            DataTable dt = new DataTable();
            sqlText = "SET DATEFORMAT DMY";
            sqlText += " SELECT FaturaNo FROM FaturaBaslik ";
            sqlText += " WHERE FaturaTipi = 'Alış Faturası' AND KullaniciAdi='Emar' Order By FaturaNo Desc";
            SqlCommand cmd = new SqlCommand(sqlText, bgl.baglanti());
            string a = Convert.ToString(cmd.ExecuteScalar());
            return a;
        }
        public static DataSet FaturaList(DateTime BasTar, DateTime BitTar, string FaturaTürü, string FaturaNo, string CariKodu)
        {
            dtKalem.Rows.Clear();
            dtUst.Rows.Clear();
            var compiler = new SqlServerCompiler();
            var dbKaynak = new QueryFactory(bgl.baglanti(), compiler);
            var sqlKaynak = dbKaynak.Query("FaturaBaslik AS FT")
                .SelectRaw("FT.ID,FT.FaturaNo,FT.FaturaTarihi,FT.FaturaTipi,FT.CariKodu,FT.CariAdiSoyadi AS 'CariAdiSoyadi',FT.Telefon,FT.Adres AS 'Adres',FT.Mail,FT.AraToplam,FT.KdvToplam,FT.ToplamTutar,FT.KullaniciAdi," +
                "FK.BaslikRef,FK.StokKodu,FK.StokAdi,FK.StokMiktar,FK.StokBirim,FK.StokBirimFiyat,FK.KdvOran,FK.KdvTutar,FK.AraToplam AS 'KalemAraToplam',FK.ToplamTutar AS 'KalemToplamTutar'")
                .LeftJoin("FaturaKalem AS FK", j => j.On("FT.ID", "FK.BaslikRef"))
                .WhereRaw("FaturaTarihi BETWEEN '" + BasTar.ToString("yyyy-MM-dd") + "' AND '" + BitTar.ToString("yyyy-MM-dd") + "'");
            if (FaturaTürü == "SatisFaturasi")
            {
                sqlKaynak = sqlKaynak.CombineRaw("AND FaturaTipi = 'Satış Faturası'");
            }
            else if (FaturaTürü == "AlisFaturasi")
            {
                sqlKaynak = sqlKaynak.CombineRaw("AND FaturaTipi = 'Alış Faturası'");
            }
            if (FaturaNo != "")
            {
                sqlKaynak = sqlKaynak.CombineRaw("AND FaturaNo = '" + FaturaNo + "'");
            }
            if (CariKodu != "")
            {
                sqlKaynak = sqlKaynak.CombineRaw("AND CariKodu = '" + CariKodu + "'");
            }
            SqlResult result = compiler.Compile(sqlKaynak);
            List<FaturaBilgileri> FaturaListesi = sqlKaynak.Get<FaturaBilgileri>().ToList();
            foreach (FaturaBilgileri item in FaturaListesi)
            {
                bool invoiceIdUstTablosundaVarMi = false;
                int invoiceID = Convert.ToInt32(item.ID);
                for (int i = 0; i < dtUst.Rows.Count; i++)
                {
                    if (invoiceID == Convert.ToInt32(dtUst.Rows[i]["ID"]))
                    {
                        invoiceIdUstTablosundaVarMi = true;
                        break;
                    }
                }
                if (invoiceIdUstTablosundaVarMi == false)
                {
                    DataRow dr = dtUst.NewRow();
                    dr["ID"] = item.ID;
                    dr["CariKodu"] = item.CariKodu;
                    dr["CariAdiSoyadi"] = item.CariAdiSoyadi;
                    dr["FaturaNo"] = item.FaturaNo;
                    dr["FaturaTarihi"] = item.FaturaTarihi;
                    dr["Mail"] = item.Mail;
                    dr["Telefon"] = item.Telefon;
                    dr["Adres"] = item.Adres;
                    dr["KullaniciAdi"] = item.KullaniciAdi;
                    dr["KdvToplam"] = item.KdvToplam;
                    dr["ToplamTutar"] = item.ToplamTutar;
                    dr["AraToplam"] = item.AraToplam;
                    dr["FaturaTipi"] = item.FaturaTipi;
                    dtUst.Rows.Add(dr);
                }
                DataRow drk = dtKalem.NewRow();
                drk["BaslikRef"] = item.BaslikRef;
                drk["StokKodu"] = item.StokKodu;
                drk["StokAdi"] = item.StokAdi;
                drk["StokBirimFiyat"] = item.StokBirimFiyat;
                drk["Miktar"] = item.StokMiktar;
                drk["StokBirim"] = item.StokBirim;
                drk["KdvOran"] = item.KdvOran;
                drk["KdvTutar"] = item.KdvTutar;
                drk["KalemAraToplam"] = item.KalemAraToplam;
                drk["KalemToplamTutar"] = item.KalemToplamTutar;
                dtKalem.Rows.Add(drk);
            }
            return ds;
        }
    }
}

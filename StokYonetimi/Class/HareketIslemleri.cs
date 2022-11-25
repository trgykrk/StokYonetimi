 using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokYonetimi.Formlar;

namespace StokYonetimi.Class
{
    class HareketIslemleri
    {
        SqlBaglanti bgl = new SqlBaglanti();
        DataTable dt = new DataTable();
        public  String StokAdi, StokBirimi,CariAdi,CariSoyadi;
        public decimal AlisFiyati,SatisFiyati;
        public int Miktar;

        public DataTable SatisHareketleriGetir()
        {            
            SqlDataAdapter da = new SqlDataAdapter("Select * From SatisHareket SH Inner Join Cariler CR On SH.Cari_Ref=CR.ID Inner Join Stoklar ST On  SH.Stok_Ref=ST.ID ", bgl.baglanti());
            da.Fill(dt);
            return dt;
        }

        public DataTable AlisHareketGetir()
        {                       
            SqlDataAdapter da = new SqlDataAdapter("Select * From AlisHareket AH Left Join Stoklar ST On AH.Stok_Ref=ST.ID ", bgl.baglanti());
            da.Fill(dt);
            return dt;
        }

        public DataTable StokGetir(String StokKodu)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Stok_Kodu,Stok_Adi From Stoklar Where Stok_Miktari>0", bgl.baglanti());           
            da.Fill(dt);
            return dt;
        }

        public DataTable CariGetir(String CariKodu)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Cari_Kodu,Cari_Adi,Cari_Soyadi From Cariler", bgl.baglanti());
            DataTable dt1 = new DataTable();
            da.Fill(dt1);         
            return dt1;
        }

        public void SatisYap(DateTime IslemTarihi,double Miktar,decimal SatisFiyati,decimal ToplamTutar,String CariKodu,string StokKodu)
        {
            SqlCommand komut_insert = new SqlCommand("insert into SatisHareket (Tarih,Adet,Fiyat,ToplamTutar,Cari_Ref,Stok_Ref) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut_insert.Parameters.AddWithValue("@p1", IslemTarihi);
            komut_insert.Parameters.AddWithValue("@p2", Miktar);
            komut_insert.Parameters.AddWithValue("@p3", SatisFiyati);
            komut_insert.Parameters.AddWithValue("@p4", ToplamTutar);
            komut_insert.Parameters.AddWithValue("@p5", CariKodu);
            komut_insert.Parameters.AddWithValue("@p6", StokKodu);
            komut_insert.ExecuteNonQuery();
            XtraMessageBox.Show("Faturanız Başarılı Bir Şekilde Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bgl.baglanti().Close();
        }

        public decimal TutarHesapla(double SatisMiktari,double SatisFiyati)
        {
            double Miktar, Tutar, BirimFiyat;
            decimal ToplamTutari;
            Miktar = Convert.ToDouble(SatisMiktari);
            BirimFiyat = Convert.ToDouble(SatisFiyati);
            Tutar = Miktar * BirimFiyat;
            ToplamTutari = Convert.ToDecimal(Tutar);
            return ToplamTutari;
        }

        public void AlisYap(DateTime IslemTarihi,double Miktari,decimal AlisFiyati,decimal ToplamTutar,string CariKodu,String StokKodu)
        {
            SqlCommand komut_insert = new SqlCommand("insert into AlisHareket (Tarih,Adet,Fiyat,ToplamTutar,Stok_Ref) values (@p1,@p2,@p3,@p4,@p6)", bgl.baglanti());
            komut_insert.Parameters.AddWithValue("@p1", IslemTarihi);
            komut_insert.Parameters.AddWithValue("@p2", Miktari);
            komut_insert.Parameters.AddWithValue("@p3", AlisFiyati);
            komut_insert.Parameters.AddWithValue("@p4", ToplamTutar);
            komut_insert.Parameters.AddWithValue("@p5", CariKodu);
            komut_insert.Parameters.AddWithValue("@p6", StokKodu);
            komut_insert.ExecuteNonQuery();
            XtraMessageBox.Show("Ürün Alışı Başarılı Bir Şekilde Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bgl.baglanti().Close();
        }

        public void StokKoduEditValueChanged (string StokKodu)
        {
            
            SqlCommand komut = new SqlCommand("Select Stok_Adi,Stok_Miktari,Stok_Birim,Stok_AlisFiyat,Stok_SatisFiyat From Stoklar Where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", StokKodu);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                StokAdi  = dr["Stok_Adi"].ToString();
                StokBirimi = dr["Stok_Birim"].ToString();
                AlisFiyati = Convert.ToDecimal(dr["Stok_AlisFiyat"].ToString());
                SatisFiyati= Convert.ToDecimal(dr["Stok_SatisFiyat"].ToString());
                Miktar = Convert.ToInt32(dr["Stok_Miktari"].ToString());
            }
            bgl.baglanti().Close();           
        }

        public void CariKoduEditValueChanged(String CariKodu)
        {
            SqlCommand komut = new SqlCommand("Select Cari_Adi,Cari_Soyadi From Cariler Where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", CariKodu);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CariAdi = dr["Cari_Adi"].ToString();
                CariSoyadi = dr["Cari_Soyadi"].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}

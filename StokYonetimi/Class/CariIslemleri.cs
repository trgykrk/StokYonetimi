using DevExpress.XtraEditors;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
     public  static class CariIslemleri
    {
        static SqlBaglanti bgl = new SqlBaglanti();

        static bool Durum;


        public  static DataTable CariListesiGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cariler", bgl.baglanti());           
            da.Fill(dt);
            return dt;           
        }

        public static bool MukerrerCari(string CariKodu)
        {
            SqlCommand komut = new SqlCommand("Select * From Cariler Where Cari_Kodu=@c1", bgl.baglanti());
            komut.Parameters.AddWithValue("@c1",CariKodu);
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

        public static void CariKayit(string CariKodu,string CariAdi,string CariSoyadi,String TCKimlikNo,String MailAdresi,string TelefonNumarasi,string AdresBilgisi)
        {

            SqlCommand komut = new SqlCommand("insert into Cariler(cari_Kodu,Cari_Adi,Cari_Soyadi,TC_KimlikNo,Cari_Mail,Cari_Telefon,Cari_Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CariKodu);
            komut.Parameters.AddWithValue("@p2", CariAdi);
            komut.Parameters.AddWithValue("@p3", CariSoyadi);
            komut.Parameters.AddWithValue("@p4", TCKimlikNo);
            komut.Parameters.AddWithValue("@p5", MailAdresi);
            komut.Parameters.AddWithValue("@p6", TelefonNumarasi);
            komut.Parameters.AddWithValue("@p7", AdresBilgisi);
            komut.ExecuteNonQuery();
            XtraMessageBox.Show("Cari Başarılı Bir Şekilde Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bgl.baglanti().Close();
        }       

        public static void CariSil(string id,string CariKodu)
        {
            if (XtraMessageBox.Show("" + CariKodu + " Koduna Sahip Cari Silinecek.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut_sil = new SqlCommand("Delete From Cariler where ID=@p1", bgl.baglanti());
                komut_sil.Parameters.AddWithValue("@p1", id);
                komut_sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Cari Başarılı Bir Şekilde Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                          
        }

        public static void CariGuncelle(String CariKodu,string CariAdi,string CariSoyadi,string TCKimlikNo,String MailAdresi,string Telefon,String AdresBilgisi,int ID)
        {
            if (XtraMessageBox.Show(""+CariKodu+" Kodlu Cari Bilgileri Güncellenecek.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut_update = new SqlCommand("Update Cariler Set Cari_Kodu=@p1,Cari_Adi=@p2,Cari_Soyadi=@p3,TC_KimlikNo=@p4,Cari_Mail=@p5,Cari_Telefon=@p6,Cari_Adres=@p7 where ID=@p8", bgl.baglanti());
                komut_update.Parameters.AddWithValue("@p1", CariKodu);
                komut_update.Parameters.AddWithValue("@p2", CariAdi);
                komut_update.Parameters.AddWithValue("@p3", CariSoyadi);
                komut_update.Parameters.AddWithValue("@p4", TCKimlikNo);
                komut_update.Parameters.AddWithValue("@p5", MailAdresi);
                komut_update.Parameters.AddWithValue("@p6", Telefon);
                komut_update.Parameters.AddWithValue("@p7", AdresBilgisi);
                komut_update.Parameters.AddWithValue("@p8", ID);
                komut_update.ExecuteNonQuery();
                XtraMessageBox.Show("Cari Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bgl.baglanti().Close();
            }           
        }
    }
 }


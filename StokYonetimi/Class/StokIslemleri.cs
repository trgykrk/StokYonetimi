using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StokYonetimi.Formlar;
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
    public static class StokIslemleri
    {
        static SqlBaglanti bgl = new SqlBaglanti();
        public static DataTable dt = new DataTable();
        public static string SqlText = "";
        public static DataTable StokListesiGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Stoklar", bgl.baglanti());
            DataColumn col = new DataColumn()
            {
                DefaultValue = false,
                DataType = typeof(bool),
                ColumnName = "Sec"
            };
            dt.Columns.Add(col);
            da.Fill(dt);
            return dt;
        }
        public static DataTable StokBilgiGetir(string StokKodu)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Stoklar Where Stok_Kodu='" + StokKodu + "'", bgl.baglanti());
            dt.Columns.Add("Miktar1", typeof(string));
            dt.Columns["Miktar1"].DefaultValue = "1";
            dt.Columns.Add("Kdv", typeof(string));
            dt.Columns["Kdv"].DefaultValue = "18";
            dt.Columns.Add("KdvTutar", typeof(string));
            da.Fill(dt);
            return dt;
        }
        public static bool MukerrerStok(string StokKodu)
        {
            bool Durum;
            SqlCommand komut = new SqlCommand("Select * From Stoklar Where Stok_Kodu=@m1", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", StokKodu);
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
        public static void StokKayit(string StokKodu, string StokAdi, string StokBirimi, decimal AlisFiyat, decimal SatisFiyat, string Miktar, String Aciklama)
        {
            SqlCommand komut_insert = new SqlCommand("insert into Stoklar(Stok_Kodu,Stok_Adi,Stok_Birim,Stok_AlisFiyat,Stok_SatisFiyat,Stok_Miktari,Stok_Aciklamasi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut_insert.Parameters.AddWithValue("@p1", StokKodu);
            komut_insert.Parameters.AddWithValue("@p2", StokAdi);
            komut_insert.Parameters.AddWithValue("@p3", StokBirimi);
            komut_insert.Parameters.AddWithValue("@p4", AlisFiyat);
            komut_insert.Parameters.AddWithValue("@p5", SatisFiyat);
            komut_insert.Parameters.AddWithValue("@p6", Miktar);
            komut_insert.Parameters.AddWithValue("@p7", Aciklama);
            komut_insert.ExecuteNonQuery();
            XtraMessageBox.Show("Stok Başarılı Bir Şekilde Eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bgl.baglanti().Close();
        }
        public static void StokSil(string id, string Stokkodu)
        {
            if (XtraMessageBox.Show("" + Stokkodu + " Stok Koduna Sahip Ürün Silinecek.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut_sil = new SqlCommand("Delete From Stoklar where ID=@p1", bgl.baglanti());
                komut_sil.Parameters.AddWithValue("@p1", id);
                komut_sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Stok Başarılı Bir Şekilde Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void StokGuncelle(String StokKodu, String StokAdi, String StokBirimi, decimal StokAlisFiyati, decimal StokSatisFiyati, int Miktar, String StokAciklama, String StokImage, int ID)
        {
            if (XtraMessageBox.Show("" + StokKodu + " Stok Koduna Sahip Ürün Bilgileri Güncellenecek.Onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut_update = new SqlCommand("Update Stoklar Set Stok_Kodu=@p1,Stok_Adi=@p2,Stok_Birim=@p3,Stok_AlisFiyat=@p4,Stok_SatisFiyat=@p5,Stok_Miktari=@p6,Stok_Aciklamasi=@p7,Stok_Image=@p9 where ID=@p8", bgl.baglanti());
                komut_update.Parameters.AddWithValue("@p1", StokKodu);
                komut_update.Parameters.AddWithValue("@p2", StokAdi);
                komut_update.Parameters.AddWithValue("@p3", StokBirimi);
                komut_update.Parameters.AddWithValue("@p4", StokAlisFiyati);
                komut_update.Parameters.AddWithValue("@p5", StokSatisFiyati);
                komut_update.Parameters.AddWithValue("@p6", Miktar);
                komut_update.Parameters.AddWithValue("@p7", StokAciklama);
                komut_update.Parameters.AddWithValue("@p9", StokImage);
                komut_update.Parameters.AddWithValue("@p8", ID);
                komut_update.ExecuteNonQuery();
                XtraMessageBox.Show("Stok Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bgl.baglanti().Close();
            }
        }
        public static int StokSayisiBul(string stokKodu)
        {
            int sonuc = 0;
            try
            {
                SqlText = "SELECT Stok_Miktari FROM Stoklar Where Stok_Kodu = '" + stokKodu + "'";
                SqlCommand cmd = new SqlCommand(SqlText, bgl.baglanti());
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sonuc;
        }
    }
}

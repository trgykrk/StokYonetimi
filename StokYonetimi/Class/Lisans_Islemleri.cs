using DevExpress.XtraEditors;
using StokYonetimi.Properties;
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
    public static class Lisans_Islemleri
    {
        static SqlBaglanti bgl = new SqlBaglanti();
        static string sql = "";
        public static DateTime getTarihSaat()
        {
            DateTime tarih;
            try
            {
                sql = "SELECT GETDATE()";
                SqlConnection conn = new SqlConnection(Settings.Default.CS);
                DataTable dt = new DataTable();
                conn.Open();
                tarih = Convert.ToDateTime(new SqlCommand(sql, conn).ExecuteScalar());
                conn.Close();
                conn.Dispose();
                return tarih;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.Now;
            }
        }
        public static string Lisans_Kontrol(DateTime Tarih, string Lisans_Sahibi, string lisansKey)
        {
            string sonuc = "";
            string sql1 = "";
            SqlConnection conn = new SqlConnection(Settings.Default.CS);
            conn.Open();
            try
            {
                DataTable dt1 = new DataTable();
                sql1 = "SELECT * FROM Keys WHERE L_Key = '" + Settings.Default.LisansKey + "'";
                new SqlDataAdapter(sql1, conn).Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    DataTable dt = new DataTable();
                    sql = "SET DATEFORMAT DMY";
                    sql += " SELECT * FROM Lisans  WHERE  Lisans_Sahibi = '" + Lisans_Sahibi + "' AND Lisans_Key = '" + Settings.Default.LisansKey + "'";
                    sql += " AND (SELECT GETDATE()) BETWEEN '" + Settings.Default.LisansBasTar + "' AND '" + Settings.Default.LisansBitTar + "'";
                    new SqlDataAdapter(sql, conn).Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        sonuc = "Başarılı";
                    }
                    else
                    {
                        sonuc = "Lisansınızın Kullanım Tarihi Sona Ermiştir.Lütfen Sistem Yetkiliniz İle İletişime Geçin.";
                    }
                }
                else
                {
                    sonuc = "Lisansınız Bulunmamaktadır.Lütfen Sistem Yetkiliniz İle İletişime Geçin.";
                }
                return sonuc;
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public static string setLisans(string Lisans_Sahibi, DateTime Lisans_BasTar, DateTime Lisans_BitTar, string Lisans_Key)
        {
            var sonuc = "";
            var conn = new SqlConnection(Settings.Default.CS);
            conn.Open();
            var tran = conn.BeginTransaction();
            try
            {
                sql = "SET DATEFORMAT DMY";
                sql += " INSERT INTO Lisans (Lisans_Sahibi,Lisans_BasTar,Lisans_BitTar,Lisans_Key) VALUES (@Lisans_Sahibi, @Lisans_BasTar, @Lisans_BitTar, @Lisans_Key)";
                SqlCommand cmd = new SqlCommand(sql, conn, tran);
                cmd.Parameters.AddWithValue("@Lisans_Sahibi", Lisans_Sahibi);
                cmd.Parameters.AddWithValue("@Lisans_BasTar", Lisans_BasTar);
                cmd.Parameters.AddWithValue("@Lisans_BitTar", Lisans_BitTar);
                cmd.Parameters.AddWithValue("@Lisans_Key", Lisans_Key);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                tran.Commit();
                sonuc = "Başarılı";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                sonuc = ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return sonuc;
        }
        public static string Lisans_Anahtarı_Dogrulama(string Lisans_Key)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.CS);
            conn.Open();
            try
            {
                string sonuc = "";
                DataTable dt = new DataTable();
                sql = "SELECT Durum FROM Keys  Where L_Key = '" + Lisans_Key + "'";
                new SqlDataAdapter(sql, conn).Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dt.Rows[0]["Durum"]) == 0)
                    {
                        sonuc = "Doğrulandı";
                    }
                    else
                    {
                        sonuc = "Lisans Anahtarı Kullanılmıştır.";
                    }
                }
                else
                {
                    sonuc = "Lisans Anahtarı Geçersizdir.Lütfen Sistem Yetkilisi İle iletişime Geçiniz...";
                }
                return sonuc;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public static void setLisansKey(string Lisans_Key)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.CS);
            conn.Open();
            try
            {
                DataTable dt = new DataTable();
                sql = "UPDATE Keys SET Durum = 1  Where L_Key = '" + Lisans_Key + "'";
                new SqlCommand(sql, conn).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.StackTrace + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}

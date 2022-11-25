using StokYonetimi.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi.Class
{
    public class Kullanici_Islemleri
    {
        static string sql = "";
        public static string GirisKontrol(string kullaniciAdi, string parola, bool beniHatirla)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.StokYonetimiConnectionString);
            conn.Open();
            try
            {
                DataTable dt = new DataTable();
                sql = "SELECT";
                sql += " ID,Kullanici_Adi,Sifre FROM Kullanicilar ";             
                sql += " WHERE Kullanici_Adi = '" + kullaniciAdi + "' AND Sifre = '" + parola + "'";
                new SqlDataAdapter(sql, conn).Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Settings.Default.AktifKullaniciId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    Settings.Default.AktifKullaniciAdi = Convert.ToString(dt.Rows[0]["Kullanici_Adi"]);
                    if (beniHatirla)
                    {
                        Settings.Default.AktifKullaniciAdi = kullaniciAdi;
                        Settings.Default.AktifKullaniciSifresi = parola;
                    }
                    Settings.Default.Save();
                    return "TAMAM";                   
                }
                else
                {
                    return "Kullanıcı adı veya parola hatalı!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}

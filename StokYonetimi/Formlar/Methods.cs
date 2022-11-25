using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;



namespace StokYonetimi.Formlar
{
    public class Methods      
    {
        SqlBaglanti bgl = new SqlBaglanti();

        public DataTable KritikSeviyeStoklar(int deger)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Stok_Miktari AS KalanStokMiktarı,Stok_Birim AS Birim,Stok_Adi AS StokAdı,Stok_Kodu AS StokKodu From Stoklar Where Stok_Miktari<'"+deger+"'", bgl.baglanti());
            da.Fill(dt);
            return dt;
        }
        public DataTable MusteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select CR.Cari_Kodu,CR.Cari_Adi,CR.Cari_Soyadi, Count(Cari_Ref) AS ToplamSatıs  From SatisHareket SH Left Join Cariler CR On SH.Cari_Ref=CR.ID Group By Cari_Kodu,Cari_Adi,Cari_Soyadi ORDER BY ToplamSatıs Desc", bgl.baglanti());
            da.Fill(dt);
            return dt;
        }
    }
}

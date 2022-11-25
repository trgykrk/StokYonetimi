using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi.Class
{
    class LogIslemlerı
    {
        SqlBaglanti bgl = new SqlBaglanti();
        DataTable dt = new DataTable();

        public DataTable LogKayitlariniGetir()
        {           
            SqlDataAdapter da = new SqlDataAdapter("Select * from Log", bgl.baglanti());
            da.Fill(dt);
            return dt;
        }
    }
}

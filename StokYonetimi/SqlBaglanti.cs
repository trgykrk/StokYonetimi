﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokYonetimi
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = TURGAY; Initial Catalog = StokYonetimi; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}

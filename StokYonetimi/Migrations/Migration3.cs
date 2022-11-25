using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace StokYonetimi.Migrations
{
    [Migration(3, "v1.0.3")]
    public class Migration3 : Migration
    {
        public override void Down()
        {
            Execute.Script("C:\\Users\\emars\\Desktop\\yedek\\StokYonetimAzure1\\StokYonetimi\\Scripts\\Sp_Cariler_Drop.sql");
           // Execute.EmbeddedScript("Sp_Cariler_Drop.sql");
        }

        public override void Up()
        {
            //Execute.EmbeddedScript("Sp_Cariler_Create.sql");
            Execute.Script("C:\\Users\\emars\\Desktop\\yedek\\StokYonetimAzure1\\StokYonetimi\\Scripts\\Sp_Cariler_Create.sql");
        }
    }
}

using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi.Migrations
{
    [Migration(2, "v1.0.1")]
    public class Migration2: Migration
    {      
         public override void Up()
        {
            Create.Table("Deneme")
                .WithColumn("a").AsInt32().PrimaryKey().Identity()
                .WithColumn("b").AsString(50)
                .WithColumn("c").AsString()
                .WithColumn("d").AsString(10);
        }

        public override void Down()
        {
            Delete.Table("Deneme");
        }
    }
}

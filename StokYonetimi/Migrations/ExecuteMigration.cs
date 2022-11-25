using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using FluentMigrator;
using StructureMap;
using DevExpress.XtraEditors;
using System.Windows.Forms;


namespace StokYonetimi.Migrations
{
    public static class ExecuteMigration
    {
        public static void VersionYukselt()
        {
            var services = new ServiceCollection()
                .AddFluentMigratorCore()

                .ConfigureRunner(
                builder => builder

                .AddSqlServer2012()

                .WithGlobalConnectionString("Server=EMARSOFT2;Database=StokYonetimi;Trusted_Connection=True;MultipleActiveResultSets=true")

                .WithMigrationsIn(typeof(Program).Assembly))
                .BuildServiceProvider();

            var container = new Container();
            container.Configure(config =>
            {

                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                    _.AssemblyContainingType<IMigrationRunnerBuilder>();
                });

            });

            try
            {
                using (var scope = services.CreateScope())
                {

                    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                    runner.MigrateUp();

                    XtraMessageBox.Show("Version yükseltme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void VersionDusur(long versiyon)
        {
            var services = new ServiceCollection()
                .AddFluentMigratorCore()

                .ConfigureRunner(
                builder => builder

                .AddSqlServer2012()

                .WithGlobalConnectionString("Server=EMARSOFT2;Database=StokYonetimi;Trusted_Connection=True;MultipleActiveResultSets=true")

                .WithMigrationsIn(typeof(Program).Assembly))
                .BuildServiceProvider();

            var container = new Container();
            container.Configure(config =>
            {

                    config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                    _.AssemblyContainingType<IMigrationRunnerBuilder>();
                });

            });

            try
            {
                using (var scope = services.CreateScope())
                {

                    
                    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
                    runner.RollbackToVersion(versiyon);

                    XtraMessageBox.Show("Bir önceki sürüme geçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

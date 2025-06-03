using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using OWL.Data;
using OWL.Seeders;

namespace OWL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            using (var context = new OwlDbContext())
            {
                context.Database.EnsureCreated();
            }

            try
            {
                Seeder.Seed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"B³¹d podczas seedowania bazy: {ex.Message}",
                    "Seed Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            Application.Run(new LoginPanel());
        }
    }
}

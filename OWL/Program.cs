using Microsoft.Extensions.Configuration;
using OWL.Models;

namespace OWL
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            //MessageBox.Show($"Szukam pliku w: {Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName}");

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            using (var context = new OwlDbContext())
            {
                context.Database.EnsureCreated();
            }

            Application.Run(new LoginPanel());
        }
    }
}
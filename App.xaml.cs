using System;
using RenanIkedaFernandes_d7_avaliacao.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace RenanIkedaFernandes_d7_avaliacao
{
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new();

            char sep = Path.DirectorySeparatorChar;
            string database_path = $"DB{sep}LoginDB.db";

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite($"Data source = {database_path}");
            });

            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
        }
    }
}

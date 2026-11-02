using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mod7ProductDBApp.Data;
using Mod7ProductDBApp.Services;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Mod7ProductDBApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // the service provider will register all our service classes and dbcontext, provide
        // instances wherever we inject the service variable mostly in the constructor throughout 
        // the app
        private ServiceProvider provider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseSqlite("Data Source=products.db");
            }
            );
            services.AddSingleton<ICRUD, CRUD>();//interface,implementor
            services.AddSingleton<MainWindow>();
            provider = services.BuildServiceProvider();
        }
        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = provider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }

}

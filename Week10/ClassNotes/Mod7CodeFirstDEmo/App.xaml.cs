using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDEmo.Data;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Mod7CodeFirstDEmo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Records.context = new EmployeeContext();
            Records.context.Database.EnsureCreated();
            Records.context.Employees.Load();
            Records.context.Departments.Load();
        }
    }

}

using System.Configuration;
using System.Data;
using System.Windows;
using System.IO;
namespace proga;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // Получаем путь к папке с приложением
        Methods.way = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BdOne.db");

    }
}
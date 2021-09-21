using JsonPlaceholderWpf.TestTask.ViewModels.Helper;
using System.Windows;

namespace JsonPlaceholderWpf.TestTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();

            window.DataContext = new ModelHub();
            window.Show();
        }
    }
}

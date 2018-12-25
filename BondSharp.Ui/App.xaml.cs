using System.Windows;

namespace BondSharp.Ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow
            {
            };
            
            window.Show();
        }
    }
}
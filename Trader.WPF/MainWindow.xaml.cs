using System.Windows;
using Trader.WPF.ViewModels;


namespace Trader.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MainViewModel();

            InitializeComponent();
        }
    }
}

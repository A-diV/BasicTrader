using BasicTrader.Domain.Models.RealtimePrice;
using BasicTrader.FinancialModelingPrepAPI.Services;
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

            //new AutoCompleteService<AutoComplete>().GetAutoCompleteResults(BasicTrader.Domain.Models.Enum.IndexType.TSLA).ContinueWith((task) =>
            //{
            //    var index = task.Result;
            //});

            //new RealtimePriceService<RealtimeData>().GetRealTimePrices(BasicTrader.Domain.Models.Enum.IndexType.TSLA).ContinueWith(task =>
            //{
            //    var realTimePrices = task.Result;
            //});

            InitializeComponent();
        }
    }
}

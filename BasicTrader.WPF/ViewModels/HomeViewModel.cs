using BasicTrader.WPF.ViewModels;

namespace Trader.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public IndexViewModel IndexViewModel { get; set; }
        public HomeViewModel(IndexViewModel indexViewModel)
        {
            IndexViewModel = indexViewModel;
        }
    }
}

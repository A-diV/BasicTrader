using BasicTrader.WPF.ViewModels;

namespace Trader.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public IndexListingViewModel IndexListingViewModel { get; set; }
        public HomeViewModel(IndexListingViewModel indexViewModel)
        {
            IndexListingViewModel = indexViewModel;
        }
    }
}

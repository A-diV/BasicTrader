using BasicTrader.Domain.Models.Enum;
using BasicTrader.Domain.Models.RealtimePrice;
using BasicTrader.Domain.Services;
using BasicTrader.WPF.Controls;
using Trader.WPF.ViewModels;

namespace BasicTrader.WPF.ViewModels
{
    public class IndexListingViewModel : ViewModelBase
    {
        private readonly IRealtimeData _realtimeData;

        private DataItem _msft;
        public DataItem? MSFT
        {
            get
            {
                return _msft;
            }
            set
            {
                _msft = value;
                OnPropertyChanged(nameof(MSFT));
            }
        }

        private DataItem _aapl;
        public DataItem AAPL
        {
            get
            {
                return _aapl;
            }
            set
            {
                _aapl = value;
                OnPropertyChanged(nameof(AAPL));
            }
        }

        private DataItem _amzn;
        public DataItem? AMZN
        {
            get
            {
                return _amzn;
            }
            set
            {
                _amzn = value;
                OnPropertyChanged(nameof(AMZN));
            }
        }

        private DataItem _ups;
        public DataItem? UPS
        {
            get
            {
                return _ups;
            }
            set
            {
                _ups = value;
                OnPropertyChanged(nameof(UPS));
            }
        }

        public IndexListingViewModel(IRealtimeData realtimeData)
        {
            _realtimeData = realtimeData;
        }

        public static IndexListingViewModel LoadIndexViewModel(IRealtimeData realtimeData)
        {
            IndexListingViewModel indexViewModel = new IndexListingViewModel(realtimeData);
            indexViewModel.LoadIndexes();
            return indexViewModel;
        }
         
        private void LoadIndexes()
        {
            _realtimeData.GetRealTimePrices(IndexType.MSFT).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    MSFT = task.Result.Data[0];
                }
            });

            _realtimeData.GetRealTimePrices(IndexType.AAPL).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    AAPL = task.Result.Data[0];
                }
            });
            
            _realtimeData.GetRealTimePrices(IndexType.AMZN).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    AMZN = task.Result.Data[0];
                }
            });
            
            _realtimeData.GetRealTimePrices(IndexType.UPS).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    UPS = task.Result.Data[0];
                }
            });
        }
    }
}

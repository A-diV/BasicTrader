using BasicTrader.Domain.Models.Enum;
using BasicTrader.Domain.Services;
using Trader.WPF.ViewModels;

namespace BasicTrader.WPF.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        private readonly IRealtimeData _realtimeData;

        private IndexType _msft;
        public IndexType MSFT
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

        private IndexType _aapl;
        public IndexType AAPL
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

        public IndexViewModel(IRealtimeData realtimeData)
        {
            _realtimeData = realtimeData;
        }

        public static IndexViewModel LoadIndexViewModel(IRealtimeData realtimeData)
        {
            IndexViewModel indexViewModel = new IndexViewModel(realtimeData);
            indexViewModel.LoadIndexes();
            return indexViewModel;
        }

        private void LoadIndexes()
        {
            _realtimeData.GetRealTimePrices(IndexType.MSFT).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    var t = task.Result;
                    MSFT = IndexType.MSFT;
                }
            });

            _realtimeData.GetRealTimePrices(IndexType.AAPL).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    var t = task.Result;
                    AAPL = IndexType.AAPL;

                }
            }); ;
        }
    }
}

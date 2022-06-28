using BasicTrader.Domain.Models.Enum;
using BasicTrader.Domain.Models.RealtimePrice;
using BasicTrader.Domain.Services;
using BasicTrader.WPF.Controls;
using Trader.WPF.ViewModels;

namespace BasicTrader.WPF.ViewModels
{
    public class IndexViewModel : ViewModelBase
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

        //private IndexType _aapl;
        //public IndexType AAPL
        //{
        //    get
        //    {
        //        return _aapl;
        //    }
        //    set
        //    {
        //        _aapl = value;
        //        OnPropertyChanged(nameof(AAPL));
        //    }
        //}

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
                    MSFT = task.Result.Data[0];
                }
            });

            //_realtimeData.GetRealTimePrices(IndexType.AAPL).ContinueWith(task =>
            //{
            //    if (task.Exception == null)
            //    {
            //        var t = task.Result;
            //        AAPL = IndexType.AAPL;

            //    }
            //}); 
        }
    }
}

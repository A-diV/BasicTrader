using BasicTrader.Domain.Models.RealtimePrice;
using BasicTrader.FinancialModelingPrepAPI.Services;
using BasicTrader.WPF.ViewModels;
using System;
using System.Windows.Input;
using Trader.WPF.State.Navigators;
using Trader.WPF.ViewModels;

namespace Trader.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel(IndexViewModel.LoadIndexViewModel(new RealtimePriceService<RealtimeData>()));
                        break;
                    case ViewType.Portfolio:
                        _navigator.CurrentViewModel = new PortfolioViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

using System.Windows.Input;
using Trader.WPF.Commands;
using Trader.WPF.Models;
using Trader.WPF.ViewModels;

namespace Trader.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {

            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }
        public ICommand UpdateCurrentViewModelICommand => new UpdateCurrentViewModelCommand(this);

    }
}

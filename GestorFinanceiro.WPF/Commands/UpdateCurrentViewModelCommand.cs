using GestorFinanceiro.WPF.State.Navigators;
using GestorFinanceiro.WPF.ViewModels.Factories;
using System;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        private readonly IGestorFinanceiroViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IGestorFinanceiroViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                _navigator.CurrentViewModel = _viewModelFactory.CriarViewModel(viewType);
            }
        }
    }
}

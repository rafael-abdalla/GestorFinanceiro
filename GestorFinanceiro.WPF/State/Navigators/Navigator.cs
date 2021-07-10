using GestorFinanceiro.WPF.ViewModels;
using System;

namespace GestorFinanceiro.WPF.State.Navigators
{
    public class Navigator : INavigator
    {
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}

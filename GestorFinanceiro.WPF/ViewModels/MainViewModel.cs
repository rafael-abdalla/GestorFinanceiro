using GestorFinanceiro.WPF.Commands;
using GestorFinanceiro.WPF.State.Authenticators;
using GestorFinanceiro.WPF.State.Navigators;
using GestorFinanceiro.WPF.ViewModels.Factories;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IGestorFinanceiroViewModelFactory _viewModelFactory;
        private readonly INavigator _navigator;
        private readonly IAuthenticator _authenticator;

        public bool EstaLogado => _authenticator.EstaLogado;

        public string NomeUsuario => _authenticator.LoginCache.Funcionario.Pessoa.Nome;

        public BaseViewModel CurrentViewModel => _navigator.CurrentViewModel;

        public ICommand UpdateCurrentViewModelCommand { get; }

        public MainViewModel(INavigator navigator, IGestorFinanceiroViewModelFactory viewModelFactory, IAuthenticator authenticator)
        {
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
            _authenticator = authenticator;

            _navigator.StateChanged += Navigator_StateChanged;
            _authenticator.StateChanged += Authenticator_StateChanged;

            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(_navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }

        private void Authenticator_StateChanged()
        {
            OnPropertyChanged(nameof(EstaLogado));
        }

        private void Navigator_StateChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}

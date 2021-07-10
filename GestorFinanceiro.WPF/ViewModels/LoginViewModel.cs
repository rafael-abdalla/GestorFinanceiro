using GestorFinanceiro.Domain.Services.Autenticacao;
using GestorFinanceiro.WPF.Commands;
using GestorFinanceiro.WPF.State.Authenticators;
using GestorFinanceiro.WPF.State.Navigators;
using System.Security;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }

        public MensagemViewModel MensagemErroViewModel { get; }

        public LoginViewModel(IAuthenticator authenticator, IRenavigator renavigator)
        {
            LoginCommand = new LoginCommand(this, authenticator, renavigator);
            MensagemErroViewModel = new MensagemViewModel();
        }

        private string _login;
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private SecureString _senha;
        public SecureString Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
                OnPropertyChanged(nameof(Senha));
            }
        }

        public string MensagemErro
        {
            set => MensagemErroViewModel.Mensagem = value;
        }
    }
}

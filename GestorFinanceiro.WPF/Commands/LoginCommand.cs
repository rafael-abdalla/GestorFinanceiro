using GestorFinanceiro.Domain.Exceptions;
using GestorFinanceiro.Domain.Services.Autenticacao;
using GestorFinanceiro.WPF.State.Authenticators;
using GestorFinanceiro.WPF.State.Navigators;
using GestorFinanceiro.WPF.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GestorFinanceiro.WPF.Commands
{
    public class LoginCommand : BaseAsyncCommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IAuthenticator _authenticator;
        private readonly IRenavigator _renavigator;

        public LoginCommand(LoginViewModel loginViewModel, IAuthenticator authenticator, IRenavigator renavigator)
        {
            _loginViewModel = loginViewModel;
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _loginViewModel.MensagemErro = string.Empty;

            try
            {
                await _authenticator.Login(_loginViewModel.Login, parameter.ToString());

                _renavigator.Renavigate();
            }
            catch (UsuarioNaoEncontradoException)
            {
                _loginViewModel.MensagemErro = "Login não encontrado";
            }
            catch (SenhaInvalidaException)
            {
                _loginViewModel.MensagemErro = "Login ou senha incorreto(s)";
            }
            catch (Exception)
            {
                _loginViewModel.MensagemErro = "Falha ao realizar login";
            }
        }
    }
}

using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.Domain.Services.Autenticacao;
using GestorFinanceiro.WPF.State.Accounts;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;

namespace GestorFinanceiro.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IAutenticacaoService _autenticacaoService;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAutenticacaoStore _autenticacaoStore;
        public Authenticator(IUsuarioService usuarioService, IAutenticacaoService autenticacaoService, IPasswordHasher passwordHasher, IAutenticacaoStore autenticacaoStore)
        {
            _usuarioService = usuarioService;
            _autenticacaoService = autenticacaoService;
            _passwordHasher = passwordHasher;
            _autenticacaoStore = autenticacaoStore;
        }
        
        public Usuario LoginCache
        {
            get
            {
                return _autenticacaoStore.LoginCache;
            }
            private set
            {
                _autenticacaoStore.LoginCache = value;
                StateChanged?.Invoke();
            }
        }

        public bool EstaLogado => LoginCache != null;

        public event Action StateChanged;

        public void Deslogar()
        {
            LoginCache = null;
        }

        public void Inserir(Usuario usuario)
        {
            _usuarioService.Inserir(usuario);
        }

        public async Task Login(string login, string senha)
        {
            LoginCache = await _autenticacaoService.Login(login, senha);
        }
    }
}

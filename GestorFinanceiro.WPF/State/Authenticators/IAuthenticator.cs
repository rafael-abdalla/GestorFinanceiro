using GestorFinanceiro.Domain.Models;
using System;
using System.Threading.Tasks;

namespace GestorFinanceiro.WPF.State.Authenticators
{
    public interface IAuthenticator
    {
        Usuario LoginCache { get; }
        bool EstaLogado { get; }

        public event Action StateChanged;

        void Inserir(Usuario usuario);
        Task Login(string login, string senha);
        void Deslogar();
    }
}

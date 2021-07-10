using GestorFinanceiro.Domain.Models;
using System.Threading.Tasks;

namespace GestorFinanceiro.Domain.Services.Autenticacao
{
    public interface IAutenticacaoService
    {
        Task<Usuario> Login(string login, string senha);
        void Inserir(Usuario usuario);
    }
}

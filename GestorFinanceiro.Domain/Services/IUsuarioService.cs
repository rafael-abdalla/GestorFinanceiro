using GestorFinanceiro.Domain.Models;
using System.Threading.Tasks;

namespace GestorFinanceiro.Domain.Services
{
    public interface IUsuarioService : IDataService<Usuario>
    {
        public Task<Usuario> ObterPorLogin(string login);
        Task<Usuario> Login(string login, string senha);
    }
}

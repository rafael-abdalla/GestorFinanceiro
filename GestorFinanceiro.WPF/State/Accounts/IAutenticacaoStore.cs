using GestorFinanceiro.Domain.Models;

namespace GestorFinanceiro.WPF.State.Accounts
{
    public interface IAutenticacaoStore
    {
        Usuario LoginCache { get; set; }
    }
}

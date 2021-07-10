using GestorFinanceiro.Domain.Models;

namespace GestorFinanceiro.WPF.State.Accounts
{
    public class AutenticacaoStore : IAutenticacaoStore
    {
        public Usuario LoginCache { get; set; }
    }
}

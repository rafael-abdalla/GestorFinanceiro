using GestorFinanceiro.Domain.Models;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Services
{
    public interface ITabelaPrecoService : IDataService<TabelaPreco>
    {
        IEnumerable<TabelaPreco> ProcurarPorDescricao(string descricao);
    }
}

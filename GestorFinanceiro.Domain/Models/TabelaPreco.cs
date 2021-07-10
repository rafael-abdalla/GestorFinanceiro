using System;

namespace GestorFinanceiro.Domain.Models
{
    public class TabelaPreco : Entity
    {
        public TabelaPreco(Guid id, string descricao, decimal preco, Guid lancamentoId)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            LancamentoId = lancamentoId;
        }

        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public Guid LancamentoId { get; private set; }

        public virtual Lancamento Lancamento { get; set; }
    }
}

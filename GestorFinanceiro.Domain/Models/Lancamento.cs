using System;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Models
{
    public class Lancamento : Entity
    {
        public Lancamento(Guid id, Guid usuarioId, DateTime dataLancamento)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataLancamento = dataLancamento;
        }

        public Guid UsuarioId { get; private set; }
        public DateTime DataLancamento { get; private set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<TabelaPreco> TabelasPrecos { get; set; }
    }
}

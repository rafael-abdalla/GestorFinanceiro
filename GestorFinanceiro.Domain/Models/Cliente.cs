using System;

namespace GestorFinanceiro.Domain.Models
{
    public class Cliente : Entity
    {
        public Guid PessoaId { get; private set; }
        public decimal LimiteCredito { get; private set; }
        public bool Eliminado { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}

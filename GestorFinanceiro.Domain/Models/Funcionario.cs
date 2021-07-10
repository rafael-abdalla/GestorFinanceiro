using System;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Models
{
    public class Funcionario : Entity
    {
        public Funcionario(Guid id, Guid pessoaId, decimal salario)
        {
            Id = id;
            PessoaId = pessoaId;
            Salario = salario;
        }

        public Guid PessoaId { get; private set; }
        public decimal Salario { get; private set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}

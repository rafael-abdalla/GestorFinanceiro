using System;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Models
{
    public class Usuario : Entity
    {
        public Usuario() { }

        public Usuario(Guid id, Guid funcionarioId, string login, string senha)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            Login = login;
            Senha = senha;
        }

        public Guid FuncionarioId { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}

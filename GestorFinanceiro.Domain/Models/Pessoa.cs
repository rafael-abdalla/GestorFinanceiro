using System;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Models
{
    public class Pessoa : Entity
    {
        public Pessoa(Guid id, string nome, string apelido, string telefone, string celular, string email)
        {
            Id = id;
            Nome = nome;
            Apelido = apelido;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}

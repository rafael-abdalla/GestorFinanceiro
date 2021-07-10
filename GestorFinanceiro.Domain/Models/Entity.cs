using System;

namespace GestorFinanceiro.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}

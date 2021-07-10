using System;
using System.Collections.Generic;

namespace GestorFinanceiro.Domain.Services
{
    public interface IDataService<T>
    {
        IEnumerable<T> ObterTodos();
        T ObterPorId(Guid id);
        void Inserir(T objeto);
        void Atualizar(T objeto);
        void Eliminar(T objeto);
    }
}

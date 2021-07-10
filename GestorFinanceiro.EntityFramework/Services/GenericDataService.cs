using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.EntityFramework.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorFinanceiro.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : Entity
    {
        private GestorFinanceiroContext _context;
        public GenericDataService(GestorFinanceiroContext context)
        {
            _context = context;
        }

        public void Atualizar(T objeto)
        {
            _context.Entry<T>(objeto).State = EntityState.Modified;
        }

        public void Eliminar(T objeto)
        {
            _context.Set<T>().Remove(objeto);
        }

        public void Inserir(T objeto)
        {
            _context.Set<T>().Add(objeto);
        }

        public T ObterPorId(Guid id)
        {
            return _context.Set<T>().AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<T> ObterTodos()
        {
            return _context.Set<T>().ToList();
        }
    }
}

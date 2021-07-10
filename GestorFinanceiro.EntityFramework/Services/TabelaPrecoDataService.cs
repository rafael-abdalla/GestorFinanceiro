using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.EntityFramework.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorFinanceiro.EntityFramework.Services
{
    public class TabelaPrecoDataService : ITabelaPrecoService
    {
        private GestorFinanceiroContext _context;
        public TabelaPrecoDataService(GestorFinanceiroContext context)
        {
            _context = context;
        }

        public void Atualizar(TabelaPreco tabela)
        {
            _context.Entry<TabelaPreco>(tabela).State = EntityState.Modified;
        }

        public void Eliminar(TabelaPreco tabela)
        {
            _context.TabelaPrecos.Remove(tabela);
        }

        public void Inserir(TabelaPreco tabela)
        {
            _context.TabelaPrecos.Add(tabela);
        }

        public TabelaPreco ObterPorId(Guid id)
        {
            return _context.TabelaPrecos.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<TabelaPreco> ObterTodos()
        {
             return _context.TabelaPrecos.AsNoTracking().ToList();
        }

        public IEnumerable<TabelaPreco> ProcurarPorDescricao(string descricao)
        {
            return _context.TabelaPrecos.AsNoTracking().Where(x => EF.Functions.Like(x.Descricao, "%" + descricao + "%")).ToList();
        }
    }
}

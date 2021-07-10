using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.Domain.Services;
using GestorFinanceiro.EntityFramework.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorFinanceiro.EntityFramework.Services
{
    public class UsuarioDataService : IUsuarioService
    {
        private GestorFinanceiroContext _context;
        public UsuarioDataService(GestorFinanceiroContext context)
        {
            _context = context;
        }

        public void Atualizar(Usuario usuario)
        {
            _context.Entry<Usuario>(usuario).State = EntityState.Modified;
        }

        public void Eliminar(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public void Inserir(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public Task<Usuario> Login(string login, string senha)
        {
            return _context.Usuarios.AsNoTracking().Include(x => x.Funcionario).ThenInclude(x => x.Pessoa).Where(x => x.Login == login && x.Senha == senha).FirstOrDefaultAsync();
        }

        public Usuario ObterPorId(Guid id)
        {
            return _context.Usuarios.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public Task<Usuario> ObterPorLogin(string login)
        {
            return _context.Usuarios.AsNoTracking().Include(x => x.Funcionario).ThenInclude(x => x.Pessoa).Where(x => x.Login == login).FirstOrDefaultAsync();
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _context.Usuarios.AsNoTracking().ToList();
        }
    }
}

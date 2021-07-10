using GestorFinanceiro.Domain.Interfaces;
using GestorFinanceiro.EntityFramework.Persistence.Context;

namespace GestorFinanceiro.EntityFramework.Transaction
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly GestorFinanceiroContext _context;
        public UnityOfWork(GestorFinanceiroContext context)
        {
            _context = context;
        }

        public void BeginTransation()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context.Database.CurrentTransaction.Rollback();
        }        
    }
}

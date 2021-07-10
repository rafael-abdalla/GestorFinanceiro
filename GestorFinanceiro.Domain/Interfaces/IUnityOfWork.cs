namespace GestorFinanceiro.Domain.Interfaces
{
    public interface IUnityOfWork
    {
        void BeginTransation();
        void Commit();
        void Rollback();
    }
}

using GestorFinanceiro.Domain.Models;
using GestorFinanceiro.EntityFramework.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GestorFinanceiro.EntityFramework.Persistence.Context
{
    public class GestorFinanceiroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost; Port=5432; user id=postgres; password=Rhda260981; database=GestorFinanceiro;");
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<TabelaPreco> TabelaPrecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new LancamentoMapping());
            modelBuilder.ApplyConfiguration(new TabelaPrecoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

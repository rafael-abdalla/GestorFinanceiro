using GestorFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorFinanceiro.EntityFramework.Persistence.Mapping
{
    class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.PessoaId).IsRequired();

            builder.Property(x => x.LimiteCredito).IsRequired();
            builder.Property(x => x.Eliminado).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.DataCadastro).IsRequired();

            builder.HasOne(x => x.Pessoa).WithMany(x => x.Clientes).HasForeignKey(x => x.PessoaId);
        }
    }
}

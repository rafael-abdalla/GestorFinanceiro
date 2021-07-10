using GestorFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorFinanceiro.EntityFramework.Persistence.Mapping
{
    class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Apelido).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.Telefone).HasMaxLength(150);
            builder.Property(x => x.Celular).HasMaxLength(150);
        }
    }
}

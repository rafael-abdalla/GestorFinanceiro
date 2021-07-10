using GestorFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorFinanceiro.EntityFramework.Persistence.Mapping
{
    class TabelaPrecoMapping : IEntityTypeConfiguration<TabelaPreco>
    {
        public void Configure(EntityTypeBuilder<TabelaPreco> builder)
        {
            builder.ToTable("TabelaPreco");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.LancamentoId).IsRequired();

            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Preco).IsRequired();

            builder.HasOne(x => x.Lancamento).WithMany(x => x.TabelasPrecos).HasForeignKey(x => x.LancamentoId);
        }
    }
}

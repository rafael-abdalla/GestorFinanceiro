using GestorFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorFinanceiro.EntityFramework.Persistence.Mapping
{
    class LancamentoMapping : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.ToTable("Lancamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.UsuarioId).IsRequired();

            builder.Property(x => x.DataLancamento).IsRequired();

            builder.HasOne(x => x.Usuario).WithMany(x => x.Lancamentos).HasForeignKey(x => x.UsuarioId);
        }
    }
}

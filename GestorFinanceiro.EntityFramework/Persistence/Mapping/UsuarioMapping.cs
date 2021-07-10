using GestorFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestorFinanceiro.EntityFramework.Persistence.Mapping
{
    class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FuncionarioId).IsRequired();

            builder.Property(x => x.Login).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(1024);

            builder.HasOne(x => x.Funcionario).WithMany(x => x.Usuarios).HasForeignKey(x => x.FuncionarioId);
        }
    }
}

using GerenciadorTarefas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorTarefas.Data.EntityConfiguration
{
    public class TarefaEntityTypeConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Titulo).HasMaxLength(100).IsRequired();
            builder.Property(t => t.EStatusTarefa).HasConversion<int>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Data.Context
{
    public class GerenciadorTarefasContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefa { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GerenciadorTarefasContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var addedEntries = ChangeTracker.Entries()
                .Where(e =>
                    e.Entity is Entity
                    && e.State == EntityState.Added
                );

            foreach (var item in addedEntries)
            {
                ((Entity)item.Entity).DataCriacao = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

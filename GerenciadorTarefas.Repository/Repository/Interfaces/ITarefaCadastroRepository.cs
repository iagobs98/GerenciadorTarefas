using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Data.Repository.Interfaces
{
    public interface ITarefaCadastroRepository
    {
        public Task<int> SaveChangesAsync(Tarefa tarefa);
    }
}

using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Data.Repository.Interfaces
{
    public interface ITarefaDeletarRepository
    {
        Task<int> DeletarAsync(Tarefa tarefa);
    }
}

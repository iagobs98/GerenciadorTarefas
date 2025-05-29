using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Data.Repository.Interfaces
{
    public interface ITarefaEditarRepository
    {
        Task<int> EditarTarefa(Tarefa tarefa);
    }
}

using GerenciadorTarefas.Application.DTO;

namespace GerenciadorTarefas.Application.Services.Interfaces
{
    public interface ITarefaEditarService
    {
        Task EditarAsync(int idTarefa, TarefaEditarDTO tarefaEditarDTO);
    }
}

using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Data.Repository.Interfaces
{
    public interface ITarefaConsultaRepository
    {
        IEnumerable<Tarefa> Listar(EStatusTarefa? eStatusTarefa);
        Task<Tarefa?> ObterAsync(int idTarefa);
    }
}

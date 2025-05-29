using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Application.Services.Base;
using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Application.Services.Interfaces
{
    public interface ITarefaConsultaService : IConsultaService
    {
        IEnumerable<TarefaConsultaDTO> Listar(EStatusTarefa? eStatusTarefa);
    }
}

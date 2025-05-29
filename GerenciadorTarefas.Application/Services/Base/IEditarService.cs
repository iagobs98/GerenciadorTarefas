using GerenciadorTarefas.Application.DTO;

namespace GerenciadorTarefas.Application.Services.Base
{
    public interface IEditarService
    {
        Task EditarAsync(int id, IBaseDTO entityEdicaoDTO);
    }
}

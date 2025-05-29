using GerenciadorTarefas.Application.DTO;

namespace GerenciadorTarefas.Application.Services.Base
{
    public interface IConsultaService
    {
       Task<IConsultaBaseDTO> ObterAsync(int idEntidade);
    }
}

using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Application.Services.Base
{
    public interface ICadastroService<T> where T : Entity
    {
        Task CadastrarAsync(ICadastroBaseDTO<T> entityCadastroDTO);
    }
}

using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Application.DTO
{
    public interface ICadastroBaseDTO<TEntity> where TEntity : Entity
    {
        TEntity ToDomain();
    }
}

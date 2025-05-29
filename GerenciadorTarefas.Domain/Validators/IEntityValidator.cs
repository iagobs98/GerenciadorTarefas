using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Domain.Validators
{
    public interface IEntityValidator<TEntity> where TEntity : Entity
    {
        bool Validar(TEntity entity);
    }
}

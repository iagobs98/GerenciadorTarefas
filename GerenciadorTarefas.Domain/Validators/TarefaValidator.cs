using FluentValidation;
using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Domain.Validators
{
    public class TarefaValidator : AbstractValidator<Tarefa>
    {
        public TarefaValidator()
        {
            RuleFor(tarefa => tarefa.Titulo)
                .NotEmpty().WithMessage("O Titulo é obrigatório")
                .NotNull().WithMessage("O Titulo é obrigatório")
                .MaximumLength(100).WithMessage("O Titulo deve ter no máximo 100 caracters");
        }
    }
}

using FluentValidation;

namespace GerenciadorTarefas.Domain.Validators
{
    public class TarefaEdicaoValidator : TarefaCadastroValidator
    {
        public TarefaEdicaoValidator()
        {
            RuleFor(tarefa => tarefa.DataConclusao!.Value.Date)
                .GreaterThanOrEqualTo(tarefa => tarefa.DataCriacao.Date)
                .When(tarefa => tarefa.DataConclusao.HasValue)
                .WithMessage("A data de conclusão não pode ser anterior à data de criação");
        }
    }
}

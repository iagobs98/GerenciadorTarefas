using FluentValidation;
using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Application.Exceptions;
using GerenciadorTarefas.Application.Services.Interfaces;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Validators;

namespace GerenciadorTarefas.Application.Services
{
    public class TarefaCadastroService : ITarefaCadastroService
    {
        private readonly ITarefaCadastroRepository _tarefaCadastroRepository;

        public TarefaCadastroService(ITarefaCadastroRepository tarefaCadastroRepository)
        {
            _tarefaCadastroRepository = tarefaCadastroRepository;
        }

        public async Task CadastrarAsync(ICadastroBaseDTO<Tarefa> cadastroTarefaDTO)
        {
            Tarefa tarefa = cadastroTarefaDTO.ToDomain();

            var cadastroTarefaValidator = new TarefaCadastroValidator();
 
            var validacaoTarefa = cadastroTarefaValidator.Validate(tarefa);
            
            if (!validacaoTarefa.IsValid)
            {
                throw new EntityInvalidException(validacaoTarefa.Errors.First().ErrorMessage);
            }

            var quantidadeDelinhasAfetadas = await _tarefaCadastroRepository.SaveChangesAsync(tarefa);

            if (quantidadeDelinhasAfetadas == 0)
                throw new Exception("Não foi possível salvar a tarefa");
        }
    }
}

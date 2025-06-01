using FluentValidation;
using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Application.Exceptions;
using GerenciadorTarefas.Application.Services.Interfaces;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Validators;

namespace GerenciadorTarefas.Application.Services
{
    public class TarefaEditarService : ITarefaEditarService
    {
        private readonly ITarefaConsultaRepository _tarefaConsultaRepository;
        private readonly ITarefaEditarRepository _tarefaEditarRepository;

        public TarefaEditarService(
            ITarefaConsultaRepository tarefaConsultaRepository,
            ITarefaEditarRepository tarefaEditarRepository
        )
        {
            _tarefaConsultaRepository = tarefaConsultaRepository;
            _tarefaEditarRepository = tarefaEditarRepository;
        }

        public async Task EditarAsync(int idTarefa, IBaseDTO entityEdicaoDTO)
        {
            Tarefa tarefa = await _tarefaConsultaRepository.ObterAsync(idTarefa)
                ?? throw new EntityNotFoundException("Tarefa não encontrada");


            TarefaEditarDTO tarefaEdicaoDTO = (TarefaEditarDTO)entityEdicaoDTO; 

            tarefa.Editar(
                tarefaEdicaoDTO.Titulo, tarefaEdicaoDTO.Descricao,
                tarefaEdicaoDTO.DataConclusao, tarefaEdicaoDTO.EStatusTarefa
            );

            var tarefaValidator = new TarefaEdicaoValidator();

            var validacaoTarefa = tarefaValidator.Validate(tarefa);

            if (!validacaoTarefa.IsValid)
            {
                throw new EntityInvalidException(validacaoTarefa.Errors.First().ErrorMessage);
            }

            int quantidadeLinhasAfetadas = await _tarefaEditarRepository.EditarTarefa(tarefa);

            if (quantidadeLinhasAfetadas == 0)
                throw new Exception("Não foi possível salvar a tarefa");
        }
    }
}

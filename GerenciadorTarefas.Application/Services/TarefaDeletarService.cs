using GerenciadorTarefas.Application.Exceptions;
using GerenciadorTarefas.Application.Services.Interfaces;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;

namespace GerenciadorTarefas.Application.Services
{
    public class TarefaDeletarService : ITarefaDeletarService
    {
        private readonly ITarefaDeletarRepository _tarefaDeletarRepository;
        private readonly ITarefaConsultaRepository _tarefaConsultaRepository;


        public TarefaDeletarService(
            ITarefaConsultaRepository tarefaConsultaRepository,
            ITarefaDeletarRepository tarefaDeletarRepository
        )
        {
            _tarefaDeletarRepository = tarefaDeletarRepository;
            _tarefaConsultaRepository = tarefaConsultaRepository;   
        }

        public async Task DeletarAsync(int idTarefa)
        {
            Tarefa? tarefa = await _tarefaConsultaRepository.ObterAsync(idTarefa);

            if (tarefa == null)
                throw new EntityNotFoundException("Tarefa não encontrada");

            int quantidadeLinhasAfetadas = await _tarefaDeletarRepository.DeletarAsync(tarefa);

            if (quantidadeLinhasAfetadas == 0)
                throw new Exception("Não foi possível salvar a tarefa");
        }
    }
}

using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Application.Exceptions;
using GerenciadorTarefas.Application.Services.Interfaces;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Application.Services
{
    public class TarefaConsultaService : ITarefaConsultaService
    {

        private readonly ITarefaConsultaRepository _tarefaConsultaRepository;

        public TarefaConsultaService(
            ITarefaConsultaRepository tarefaConsultaRepository
        )
        {
            _tarefaConsultaRepository = tarefaConsultaRepository;
        }

        public IEnumerable<TarefaConsultaDTO> Listar(EStatusTarefa? eStatusTarefa)
        {
            var tarefas = _tarefaConsultaRepository.Listar(eStatusTarefa);
            return tarefas.Select(tarefa => new TarefaConsultaDTO(tarefa));
        }

        public async Task<IConsultaBaseDTO> ObterAsync(int idTarefa)
        {
            var tarefa = await _tarefaConsultaRepository.ObterAsync(idTarefa);

            if (tarefa == null)
                throw new EntityNotFoundException("Tarefa não encontrada");

            return new TarefaConsultaDTO(tarefa);
        }
    }
}

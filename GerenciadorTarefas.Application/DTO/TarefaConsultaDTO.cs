using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Application.DTO
{
    public class TarefaConsultaDTO(Tarefa tarefa) : IConsultaBaseDTO
    {
        public int Id { get; set; } = tarefa.Id;
        public string? Titulo { get; set; } = tarefa.Titulo;
        public string? Descricao { get; set; } = tarefa.Descricao;
        public DateTime DataCriacao { get; set; } = tarefa.DataCriacao;
        public DateTime? DataConclusao { get; set; } = tarefa.DataConclusao;
        public EStatusTarefa EStatusTarefa { get; set; } = tarefa.EStatusTarefa;
    }
}

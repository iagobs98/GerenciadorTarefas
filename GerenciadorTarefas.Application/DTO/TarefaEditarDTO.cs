using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Application.DTO
{
    public class TarefaEditarDTO : IBaseDTO
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public EStatusTarefa EStatusTarefa { get; set; }    
    }
}

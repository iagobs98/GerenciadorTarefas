using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Application.DTO
{
    public class CadastrarTarefaDTO : ICadastroBaseDTO<Tarefa>
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public EStatusTarefa EStatusTarefa { get; set; }

        public Tarefa ToDomain()
        {
            return new Tarefa()
            {
                Titulo = Titulo,
                Descricao = Descricao,
                EStatusTarefa = EStatusTarefa
            };
        }
    }
}

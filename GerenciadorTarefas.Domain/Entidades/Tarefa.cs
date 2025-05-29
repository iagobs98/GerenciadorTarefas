using GerenciadorTarefas.Domain.Enum;

namespace GerenciadorTarefas.Domain.Entidades
{
  
    public class Tarefa : Entity
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public EStatusTarefa EStatusTarefa { get; set; }

        public void Editar(string? titulo, string? descricao, DateTime? dataConclusao, EStatusTarefa eStatusTarefa)
        {
            this.Titulo = titulo;
            this.Descricao = descricao; 
            this.DataConclusao = dataConclusao; 
            this.EStatusTarefa = eStatusTarefa;
        }
    }
}

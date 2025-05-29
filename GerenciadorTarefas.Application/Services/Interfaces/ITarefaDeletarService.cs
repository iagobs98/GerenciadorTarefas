namespace GerenciadorTarefas.Application.Services.Interfaces
{
    public interface ITarefaDeletarService
    {
        Task DeletarAsync(int idTarefa);
    }
}

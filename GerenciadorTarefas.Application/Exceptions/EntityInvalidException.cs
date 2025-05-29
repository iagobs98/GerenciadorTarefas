namespace GerenciadorTarefas.Application.Exceptions
{
    public class EntityInvalidException(string menssagem)
        : Exception(menssagem)
    {
    }
}

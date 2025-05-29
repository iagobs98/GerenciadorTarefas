namespace GerenciadorTarefas.Data.Repository.Interfaces
{
    public interface IRepoistoryBase<T> where T : class
    {
        public void Cadastrar(T entity);
    }
}

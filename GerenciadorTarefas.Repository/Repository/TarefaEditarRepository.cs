using GerenciadorTarefas.Data.Context;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data.Repository
{
    public class TarefaEditarRepository : ITarefaEditarRepository
    {
        private readonly GerenciadorTarefasContext _context;
        private readonly DbSet<Tarefa> _dbSet;

        public TarefaEditarRepository(GerenciadorTarefasContext gerenciadorTarefasContext)
        {
            _context = gerenciadorTarefasContext;
            _dbSet = _context.Set<Tarefa>();
        }

        public async Task<int> EditarTarefa(Tarefa tarefa)
        {
            _dbSet.Update(tarefa);
            return await _context.SaveChangesAsync();
        }
    }
}

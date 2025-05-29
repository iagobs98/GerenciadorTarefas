using GerenciadorTarefas.Data.Context;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data.Repository
{
    public class TarefaDeletarRepository : ITarefaDeletarRepository
    {
        private readonly GerenciadorTarefasContext _context;
        private readonly DbSet<Tarefa> _dbSet;

        public TarefaDeletarRepository(GerenciadorTarefasContext gerenciadorTarefasContext)
        {
            _context = gerenciadorTarefasContext;
            _dbSet = _context.Set<Tarefa>();
        }

        public async Task<int> DeletarAsync(Tarefa tarefa)
        {
            _dbSet.Remove(tarefa);
            return await _context.SaveChangesAsync();
        }
    }
}

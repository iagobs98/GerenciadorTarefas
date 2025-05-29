using GerenciadorTarefas.Data.Context;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data.Repository
{
    public class TarefaCadastroRepository : ITarefaCadastroRepository
    {
        private readonly GerenciadorTarefasContext _context;
        private readonly DbSet<Tarefa> _dbSet;

        public TarefaCadastroRepository(GerenciadorTarefasContext gerenciadorTarefasContext)
        {
            _context = gerenciadorTarefasContext;
            _dbSet = _context.Set<Tarefa>();
        }

        public async Task<int> SaveChangesAsync(Tarefa tarefa)
        {
            _dbSet.Add(tarefa);
            return await _context.SaveChangesAsync();
        }
    }
}

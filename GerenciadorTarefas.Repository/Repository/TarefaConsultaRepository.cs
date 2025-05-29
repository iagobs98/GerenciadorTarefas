using GerenciadorTarefas.Data.Context;
using GerenciadorTarefas.Data.Repository.Interfaces;
using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Enum;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data.Repository
{
    public class TarefaConsultaRepository : ITarefaConsultaRepository
    {
        private readonly GerenciadorTarefasContext _context;
        private readonly DbSet<Tarefa> _dbSet;

        public TarefaConsultaRepository(GerenciadorTarefasContext gerenciadorTarefasContext)
        {
            _context = gerenciadorTarefasContext;
            _dbSet = _context.Set<Tarefa>();
        }

        public async Task<Tarefa?> ObterAsync(int idTarefa)
        {
            var tarefa = await _dbSet.FirstOrDefaultAsync(tarefa => tarefa.Id == idTarefa);
            return tarefa;
        }

        public IEnumerable<Tarefa> Listar(EStatusTarefa? eStatusTarefa)
        {
            IQueryable<Tarefa> tarefasQuery = _dbSet.AsQueryable();

            if (eStatusTarefa != null)
                tarefasQuery = tarefasQuery.Where(tarefa => tarefa.EStatusTarefa == eStatusTarefa);

            return tarefasQuery.ToList();
        }
    }
}

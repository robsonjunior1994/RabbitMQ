
using AprendendoRabbitMq.Models;
using Microsoft.EntityFrameworkCore;

namespace AprendendoRabbitMq.Reposotories
{
    public class RepositoryTarefa : IRepositoryTarefa
    {
        private readonly Context _context;
        public RepositoryTarefa(Context context) 
        { 
            _context = context;
        }
        public async Task<Tarefa> CreateAsync(Tarefa tarefa)
        {
            var retorno =  await _context.Tarefas.AddAsync(tarefa);
            return retorno.Entity;
        }

        public async Task DeleteAsync(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
        }

        public async Task<List<Tarefa>> GetAllAsync()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<Tarefa> GetByIdAsync(int id)
        {
            return await _context.Tarefas.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Tarefa> UpdateAsync(Tarefa tarefaBanco)
        {
            var tarefa = _context.Tarefas.Update(tarefaBanco);
            return tarefa.Entity;
        }
    }
}

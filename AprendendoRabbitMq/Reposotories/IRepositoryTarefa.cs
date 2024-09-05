using AprendendoRabbitMq.Models;

namespace AprendendoRabbitMq.Reposotories
{
    public interface IRepositoryTarefa
    {
        Task<Tarefa> CreateAsync(Tarefa tarefa);
        Task DeleteAsync(Tarefa tarefa);
        Task<List<Tarefa>> GetAllAsync();
        Task<Tarefa> GetByIdAsync(int id);
        Task<Tarefa> UpdateAsync(Tarefa tarefaBanco);
    }
}

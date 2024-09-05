using AprendendoRabbitMq.Models;

namespace AprendendoRabbitMq.Services
{
    public interface IServiceTarefa
    {
        Task<List<Tarefa>> GetAllAsync();
        Task<Tarefa> PutAsync(Tarefa tarefa);
        Task<Tarefa> GetByIdAsync(int id);
        Task<Tarefa> PostAsync(Tarefa tarefa);
        void DeleteAsync(int id);
    }
}

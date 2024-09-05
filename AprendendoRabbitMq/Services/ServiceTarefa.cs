
using AprendendoRabbitMq.Models;
using AprendendoRabbitMq.Reposotories;

namespace AprendendoRabbitMq.Services
{
    public class ServiceTarefa : IServiceTarefa
    {
        private readonly IRepositoryTarefa _repositoryTarefa;
        public ServiceTarefa(IRepositoryTarefa repositoryTarefa)
        {
            _repositoryTarefa = repositoryTarefa;
        }

        public async void DeleteAsync(int id)
        {
            if (id > 0)
            {
                Tarefa tarefa = await _repositoryTarefa.GetByIdAsync(id);
                if (tarefa != null) {
                   await _repositoryTarefa.DeleteAsync(tarefa);
                }
            }

        }

        public async Task<List<Tarefa>> GetAllAsync()
        {
            List<Tarefa> tarefas = await _repositoryTarefa.GetAllAsync();
            return tarefas;
        }

        public async Task<Tarefa> GetByIdAsync(int id)
        {
            Tarefa tarefa = await _repositoryTarefa.GetByIdAsync(id);
            return tarefa;
        }

        public async Task<Tarefa> PostAsync(Tarefa tarefa)
        {
            if(string.IsNullOrWhiteSpace(tarefa.Nome)){
                return null;
            }

            var retorno = await _repositoryTarefa.CreateAsync(tarefa);

            return retorno;
        }

        public async Task<Tarefa> PutAsync(Tarefa tarefa)
        {
            Tarefa tarefaBanco = await _repositoryTarefa.GetByIdAsync(tarefa.Id);
            if (tarefaBanco != null) 
            { 
                tarefaBanco.Nome = tarefa.Nome;
                Tarefa tarefaAtualizada = await _repositoryTarefa.UpdateAsync(tarefaBanco);
                return tarefaAtualizada;
            }
            return null;
        }
    }
}

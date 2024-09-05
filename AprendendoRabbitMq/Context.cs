using AprendendoRabbitMq.Models;
using Microsoft.EntityFrameworkCore;

namespace AprendendoRabbitMq
{
    public class Context : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TarefaDB;Trusted_Connection=true;");
        }
    }
}

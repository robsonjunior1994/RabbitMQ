using AprendendoRabbitMq.Models;
using AprendendoRabbitMq.Seedwork;

namespace AprendendoRabbitMq.Events
{
    public class TarefaEvent : Event
    {
        public Tarefa Tarefa { get; set; }
        private TarefaEvent(Tarefa tarefa, string type)
        {
            Tarefa = tarefa;
            Type = type;
            CreatedAt = DateTime.Now;
        }

        public const string TAREFA_CRIADA = "todo.tarefa.criada";
        public const string TAREFA_CONCLUIDA = "todo.tarefa.concluida";

        public static TarefaEvent Criada(Tarefa tarefa)
        {
            return new TarefaEvent(tarefa, TAREFA_CRIADA);
        }

        public static TarefaEvent Concluida(Tarefa tarefa)
        {
            return new TarefaEvent(tarefa, TAREFA_CONCLUIDA);
        }
    }
}

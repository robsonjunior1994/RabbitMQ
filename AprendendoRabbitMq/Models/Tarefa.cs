using AprendendoRabbitMq.Events;
using AprendendoRabbitMq.Seedwork;
using System.ComponentModel;

namespace AprendendoRabbitMq.Models
{
    public class Tarefa /*: Entity*/
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Feito { get; set; }

        public Tarefa(string nome)
        {
            Feito = false;
            //AddEvent(TarefaEvent.Criada(this));
            Nome = nome;
        }
    }
}

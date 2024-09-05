using AprendendoRabbitMq.Events;
using MediatR;

namespace AprendendoRabbitMq.Handlers
{
    public class TarefaEventHandler : INotificationHandler<TarefaEvent>
    {
        public TarefaEventHandler()
        {
            
        }
        public Task Handle(TarefaEvent tarefaEvent, CancellationToken cancellationToken)
        {
            tarefaEvent.RequestKey = Guid.NewGuid().ToString();

            return Task.CompletedTask;
        }
    }
}

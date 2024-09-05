using MediatR;

namespace AprendendoRabbitMq.Seedwork
{
    public abstract class Event : INotification
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string RequestKey { get; set; } = string.Empty;
    }
}

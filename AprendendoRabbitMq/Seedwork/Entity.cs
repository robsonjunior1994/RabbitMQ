namespace AprendendoRabbitMq.Seedwork
{
    public abstract class Entity
    {
        public int Id { get; set; }
#nullable enable
        private List<Event>? _events;
        public IReadOnlyList<Event>? Events => _events;
#nullable disable

        public DateTime? CreatedAt { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }

        public bool HasEvents() => _events?.Count > 0;
        public void ClearEvents() => _events?.Clear();
        public void AddEvent(Event @event)
        {
            _events ??= new List<Event>();
            _events.Add(@event);
        }
    }
}

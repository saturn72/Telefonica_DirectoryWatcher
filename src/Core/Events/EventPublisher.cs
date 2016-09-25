using Core.DependencyManagement;

namespace Core.Events
{
    public class EventPublisher : IEventPublisher
    {
        public void Publish<TEvent>(TEvent eventArgs) where TEvent : EventBase
        {
            var allConsumer = Ioc.ResolveMany<IConsumer<TEvent>>();
            foreach (var consumer in allConsumer)
                consumer.HandleEvent(eventArgs);
        }
    }
}
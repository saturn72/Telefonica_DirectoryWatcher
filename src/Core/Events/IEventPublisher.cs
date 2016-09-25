namespace Core.Events
{
    public interface IEventPublisher
    {
        void Publish<TEvent>(TEvent eventArgs) where TEvent : EventBase;
    }
}

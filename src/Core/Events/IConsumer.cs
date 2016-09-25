namespace Core.Events
{
    public interface IConsumer<in TEvent> where TEvent:EventBase
    {
        void HandleEvent(TEvent eventArgs);
    }
}

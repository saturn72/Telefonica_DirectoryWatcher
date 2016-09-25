using Core.DependencyManagement;
using Core.Events;
using Xunit;

namespace Core.Tests.Events
{
    public class EventPublisherTests
    {
        [Fact]
        public void Publish_TrigerHandlers()
        {
            Ioc.Register<IConsumer<TestEvent>, TestHandler>();
            var ep = new EventPublisher();

            var testEvent = new TestEvent {Index = 0};
            ep.Publish(testEvent);

            Assert.Equal(1, testEvent.Index);

        }
    }

    public class TestHandler : IConsumer<TestEvent>
    {
        public void HandleEvent(TestEvent eventArgs)
        {
            eventArgs.Index = 1;
        }
    }

    public class TestEvent : EventBase
    {
        public int Index { get; set; }
    }
}

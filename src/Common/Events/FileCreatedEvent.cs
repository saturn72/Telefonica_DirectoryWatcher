using Core.Events;

namespace Common.Events
{
    public class FileCreatedEvent:EventBase
    {
        public string FilePath { get; set; }
    }
}

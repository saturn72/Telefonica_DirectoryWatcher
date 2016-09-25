using System;

namespace Core.Events
{
    public abstract class EventBase
    {
        public DateTime FiredOn { get; set; }
    }
}
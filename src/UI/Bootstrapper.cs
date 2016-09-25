using Common.Consumers;
using Common.Events;
using Common.Services;
using Common.Watchers;
using Core.DependencyManagement;
using Core.Events;

namespace UI
{
    internal class Bootstrapper
    {
        public void Load()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            Ioc.Register<IWatchService, WatchService>();
            Ioc.Register<IEventPublisher, EventPublisher>();
            Ioc.Register<IDirectoryWatcher, FileSystemDirectoryWatcher>();
            Ioc.Register<IConsumer<FileCreatedEvent>, FileCreatedHandler>();
        }
    }
}
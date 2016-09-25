using System;
using System.IO;
using Common.Events;
using Core.DependencyManagement;
using Core.Events;

namespace Common.Watchers
{
    public class FileSystemDirectoryWatcher : IDirectoryWatcher
    {
        private static FileSystemWatcher _fileSystemWatcher;

        protected FileSystemWatcher FileSystemWatcher => _fileSystemWatcher ?? (_fileSystemWatcher = BuildWatcher());

        private FileSystemWatcher BuildWatcher()
        {
            var fsw = new FileSystemWatcher
            {
                NotifyFilter = NotifyFilters.LastAccess |
                               NotifyFilters.LastWrite |
                               NotifyFilters.FileName |
                               NotifyFilters.DirectoryName,
                IncludeSubdirectories = false,
                Filter = "*.*"
            };

            fsw.Created += OnFileCreation;
            return fsw;
        }

        private void OnFileCreation(object sender, FileSystemEventArgs e)
        {
            var fce = new FileCreatedEvent
            {
                FiredOn = DateTime.UtcNow,
                FilePath = e.FullPath
            };

            var eventPublisher = Ioc.Resolve<IEventPublisher>();
            eventPublisher.Publish(fce);
        }

        public void SetWatchPath(string directoryPath)
        {
            FileSystemWatcher.Path = directoryPath;
        }

        public void StartWatching()
        {
            FileSystemWatcher.EnableRaisingEvents = true;
        }

        public void StopWatching()
        {
            FileSystemWatcher.EnableRaisingEvents = false;
        }
    }
}
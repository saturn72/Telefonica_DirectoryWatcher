using System;
using Common.Watchers;
using Core.DependencyManagement;

namespace Common.Services
{
    public class WatchService : IWatchService
    {
        private static string _destinationDirectory;
        public void StartWatch(string watchedDirectory, string destinationDirectory)
        {
            if(string.IsNullOrEmpty(watchedDirectory) || 
            string.IsNullOrEmpty(destinationDirectory) || 
            string.IsNullOrWhiteSpace(watchedDirectory) || 
            string.IsNullOrWhiteSpace(destinationDirectory))
                throw new ArgumentException("Please specify both Watch directory and destination directory");
            
            var dirWatcher = Ioc.Resolve<IDirectoryWatcher>();
            dirWatcher.SetWatchPath(watchedDirectory);
            _destinationDirectory = destinationDirectory;
            dirWatcher.StartWatching();
        }

        public void StopWatch()
        {
            var dirWatcher = Ioc.Resolve<IDirectoryWatcher>();
            dirWatcher.StopWatching();
        }

        public string GetDestinationDirectory()
        {
            return _destinationDirectory;
        }
    }
}
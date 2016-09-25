namespace Common.Watchers
{
    public interface IDirectoryWatcher
    {
        void SetWatchPath(string directoryPath);
        void StartWatching();
        void StopWatching();
    }
}
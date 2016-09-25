namespace Common.Services
{
    public interface IWatchService
    {
        void StartWatch(string watchedDirectory, string destinationDirectory);

        void StopWatch();

        string GetDestinationDirectory();
    }
}
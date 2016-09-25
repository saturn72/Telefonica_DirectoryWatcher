using System;
using System.IO;
using System.Linq;
using Common.Events;
using Common.Services;
using Core.DependencyManagement;
using Core.Events;

namespace Common.Consumers
{
    public class FileCreatedHandler : IConsumer<FileCreatedEvent>
    {
        private static readonly string[] ExcludeDateTimeExtensionList = {"txt"};

        public void HandleEvent(FileCreatedEvent eventArgs)
        {
            var sourceFile = eventArgs.FilePath;

            var destFileName = CalculateDetinationFileName(sourceFile);
            var destDirectory = Ioc.Resolve<IWatchService>().GetDestinationDirectory();
            //TODO: add error handling here
            var destFileFullPath = Path.Combine(destDirectory, destFileName);

            File.Copy(sourceFile, destFileFullPath, true);
        }

        private bool ShouldConcatDateTime(string ext)
        {
            return !ExcludeDateTimeExtensionList.Contains(ext);
        }

        private string CalculateDetinationFileName(string sourceFile)
        {
            var destFileName = Path.GetFileName(sourceFile);
            var ext = Path.GetExtension(destFileName).Remove(0, 1);
            if (ShouldConcatDateTime(ext))
                destFileName = destFileName.Replace(".", "_" + DateTime.Now.ToString("yyyy-MM-dd__HH_mm_ss.fff") + ".");
            return destFileName;
        }
    }
}
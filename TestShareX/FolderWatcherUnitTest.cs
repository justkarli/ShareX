using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareX.Folderwatcher;

namespace TestShareX
{
    [TestClass]
    public class FolderWatcherUnitTest
    {
        private static string _testfolder1_name = "/folderwatchertest1";
        private static string _testfolder2_name = "/folderwatchertest2";

        [TestMethod]
        public void TestWatchFolderDuplicateEventTimerIsDuplicateSamePathExpiredResultFalse()
        {
            var watch_folder1 = new WatchFolderDuplicateEventTimer(_testfolder1_name);
            Thread.Sleep(WatchFolderDuplicateEventTimer.WATCH_FOLDER_EXPIRATION_TIME_MILLIS + 1);
            var is_duplicate_event_result = watch_folder1.IsDuplicateEvent(_testfolder1_name);

            Assert.IsFalse(is_duplicate_event_result);
        }

        [TestMethod]
        public void TestWatchFolderDuplicateEventTimerIsDuplicateSamePathNotExpiredResultTrue()
        {
            var watch_folder1 = new WatchFolderDuplicateEventTimer(_testfolder1_name);
            Thread.Sleep(WatchFolderDuplicateEventTimer.WATCH_FOLDER_EXPIRATION_TIME_MILLIS - 1);
            var is_duplicate_event_result = watch_folder1.IsDuplicateEvent(_testfolder1_name);

            Assert.IsTrue(is_duplicate_event_result);
        }

        [TestMethod]
        public void TestWatchFolderDuplicateEventTimerIsDuplicateDifferentPathResultFalse()
        {
            var watch_folder1 = new WatchFolderDuplicateEventTimer(_testfolder1_name);
            var is_duplicate_event_result = watch_folder1.IsDuplicateEvent(_testfolder2_name);

            Assert.IsFalse(is_duplicate_event_result);
        }
    }
}

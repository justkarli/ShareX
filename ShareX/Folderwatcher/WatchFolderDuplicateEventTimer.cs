using System.Diagnostics;

namespace ShareX.Folderwatcher
{
    public class WatchFolderDuplicateEventTimer
    {
        public const int WATCH_FOLDER_EXPIRATION_TIME_MILLIS = 1000;

        public WatchFolderDuplicateEventTimer(string path)
        {
            _timer = Stopwatch.StartNew();
            _path = path;
        }

        public bool IsDuplicateEvent(string path)
        {
            bool result = (path == _path && !IsExpired);

            if (result)
                _timer = Stopwatch.StartNew();
         
            return result;
        }

        public bool IsExpired
        {
            get { return _timer.ElapsedMilliseconds >= WATCH_FOLDER_EXPIRATION_TIME_MILLIS; }
        }

        private Stopwatch _timer;
        private string _path;
    }
}

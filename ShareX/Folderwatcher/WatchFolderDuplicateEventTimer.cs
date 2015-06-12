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
            bool is_event_duplicated = IsEventDuplicated(path);

            if (is_event_duplicated)
                ResetTimer();
         
            return is_event_duplicated;
        }

        private void ResetTimer()
        {
            _timer = Stopwatch.StartNew();
        }

        private bool IsPathIdentical(string path)
        {
            return _path == path;
        }

        public bool IsEventDuplicated(string path)
        {
            return IsPathIdentical(path) && !IsExpired;
        }

        public bool IsExpired
        {
            get { return _timer.ElapsedMilliseconds >= WATCH_FOLDER_EXPIRATION_TIME_MILLIS; }
        }

        private Stopwatch _timer;
        private string _path;
    }
}

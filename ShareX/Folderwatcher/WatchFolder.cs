﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright © 2007-2015 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using ShareX.Folderwatcher;
using ShareX.HelpersLib;

namespace ShareX
{
    /// <summary>
    /// Watches a given folder path for changes and raises the FileWatcherTrigger event.
    /// </summary>
    public class WatchFolder : IDisposable
    {
        public WatchFolderSettings Settings { get; set; }
        public TaskSettings TaskSettings { get; set; }

        private SynchronizationContext context;
        private FileSystemWatcher fileWatcher;
        private List<WatchFolderDuplicateEventTimer> timers = new List<WatchFolderDuplicateEventTimer>();

        public event FileWatcherTriggerEventHandler FileWatcherTrigger;
        public delegate void FileWatcherTriggerEventHandler(string path);

        public void Enable()
        {
            Dispose();

            if (!string.IsNullOrEmpty(Settings.FolderPath) && Directory.Exists(Settings.FolderPath))
            {
                context = SynchronizationContext.Current ?? new SynchronizationContext();

                fileWatcher = new FileSystemWatcher(Settings.FolderPath);
                
                if (!string.IsNullOrEmpty(Settings.Filter))
                    fileWatcher.Filter = Settings.Filter;

                fileWatcher.IncludeSubdirectories = Settings.IncludeSubdirectories;
                fileWatcher.Created += fileWatcher_Created;
                fileWatcher.EnableRaisingEvents = true;
            }
        }

        protected void OnFileWatcherTrigger(string path)
        {
            if (FileWatcherTrigger != null)
                FileWatcherTrigger(path);
        }

        private void fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            CleanElapsedTimers();

            string path = e.FullPath;

            foreach (WatchFolderDuplicateEventTimer timer in timers)
            {
                if (timer.IsDuplicateEvent(path))
                    return;
            }

            timers.Add(new WatchFolderDuplicateEventTimer(path));

            Action onCompleted = () => context.Post(state => OnFileWatcherTrigger(path), null);
            Helpers.WaitWhileAsync(() => Helpers.IsFileLocked(path), 250, 5000, onCompleted, 1000);
        }

        protected void CleanElapsedTimers()
        {
            for (int i = 0; i < timers.Count; i++)
            {
                if (timers[i].IsExpired)
                    timers.Remove(timers[i]);
            }
        }

        public void Dispose()
        {
            if (fileWatcher != null)
                fileWatcher.Dispose();
        }
    }
}
#region License Information (GPL v3)

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

using System.Collections.Generic;
using Newtonsoft.Json;
using ShareX.HelpersLib;
using ShareX.Hotkey;
using ShareX.IndexerLib;
using ShareX.TaskManagement;
using ShareX.UploadersLib;

namespace ShareX
{
    public class TaskSettings
    {
        public string Description = string.Empty;

        public HotkeyCommandEnum Job = HotkeyCommandEnum.None;

        public bool UseDefaultAfterCaptureJob = true;
        public AfterCaptureTasks AfterCaptureJob = AfterCaptureTasks.CopyImageToClipboard | AfterCaptureTasks.SaveImageToFile | AfterCaptureTasks.UploadImageToHost;

        public bool UseDefaultAfterUploadJob = true;
        public AfterUploadTasks AfterUploadJob = AfterUploadTasks.CopyURLToClipboard;

        public bool UseDefaultDestinations = true;
        public ImageDestination ImageDestination = ImageDestination.Imgur;
        public FileDestination ImageFileDestination = FileDestination.Dropbox;
        public TextDestination TextDestination = TextDestination.Pastebin;
        public FileDestination TextFileDestination = FileDestination.Dropbox;
        public FileDestination FileDestination = FileDestination.Dropbox;
        public UrlShortenerType URLShortenerDestination = UrlShortenerType.BITLY;
        public URLSharingServices URLSharingServiceDestination = URLSharingServices.Twitter;

        public bool OverrideFTP = false;
        public int FTPIndex = 0;

        public bool OverrideCustomUploader = false;
        public int CustomUploaderIndex = 0;

        public bool UseDefaultGeneralSettings = true;
        public TaskSettingsGeneral GeneralSettings = new TaskSettingsGeneral();

        public bool UseDefaultImageSettings = true;
        public TaskSettingsImage ImageSettings = new TaskSettingsImage();

        public bool UseDefaultCaptureSettings = true;
        public TaskSettingsCapture CaptureSettings = new TaskSettingsCapture();

        public bool UseDefaultUploadSettings = true;
        public TaskSettingsUpload UploadSettings = new TaskSettingsUpload();

        public bool UseDefaultActions = true;
        public List<ExternalProgram> ExternalPrograms = new List<ExternalProgram>();

        public bool UseDefaultIndexerSettings = true;
        public IndexerSettings IndexerSettings = new IndexerSettings();

        public bool UseDefaultAdvancedSettings = true;
        public TaskSettingsAdvanced AdvancedSettings = new TaskSettingsAdvanced();

        public bool WatchFolderEnabled = false;
        public List<WatchFolderSettings> WatchFolderList = new List<WatchFolderSettings>();

        [JsonIgnore]
        public TaskSettings TaskSettingsReference { get; private set; }

        [JsonIgnore]
        public TaskSettingsCapture TaskSettingsCaptureReference
        {
            get
            {
                if (UseDefaultCaptureSettings)
                    return Program.DefaultTaskSettings.CaptureSettings;

                return TaskSettingsReference.CaptureSettings;
            }
        }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Description) ? Description : Job.GetLocalizedDescription();
        }

        public bool IsUsingDefaultSettings
        {
            get
            {
                return UseDefaultAfterCaptureJob && UseDefaultAfterUploadJob && UseDefaultDestinations && !OverrideFTP && !OverrideCustomUploader && UseDefaultGeneralSettings &&
                    UseDefaultImageSettings && UseDefaultCaptureSettings && UseDefaultUploadSettings && UseDefaultActions && UseDefaultIndexerSettings &&
                    UseDefaultAdvancedSettings && !WatchFolderEnabled;
            }
        }

        public static TaskSettings GetDefaultTaskSettings()
        {
            TaskSettings taskSettings = new TaskSettings();
            taskSettings.SetDefaultSettings();
            taskSettings.TaskSettingsReference = Program.DefaultTaskSettings;
            return taskSettings;
        }

        public static TaskSettings GetSafeTaskSettings(TaskSettings taskSettings)
        {
            TaskSettings safeTaskSettings;

            if (taskSettings.IsUsingDefaultSettings && Program.DefaultTaskSettings != null)
            {
                safeTaskSettings = Program.DefaultTaskSettings.Copy();
                safeTaskSettings.Description = taskSettings.Description;
                safeTaskSettings.Job = taskSettings.Job;
            }
            else
            {
                safeTaskSettings = taskSettings.Copy();
                safeTaskSettings.SetDefaultSettings();
            }

            safeTaskSettings.TaskSettingsReference = taskSettings;
            return safeTaskSettings;
        }

        private void SetDefaultSettings()
        {
            if (Program.DefaultTaskSettings != null)
            {
                TaskSettings defaultTaskSettings = Program.DefaultTaskSettings.Copy();

                if (UseDefaultAfterCaptureJob)
                    AfterCaptureJob = defaultTaskSettings.AfterCaptureJob;

                if (UseDefaultAfterUploadJob)
                    AfterUploadJob = defaultTaskSettings.AfterUploadJob;

                if (UseDefaultDestinations)
                {
                    ImageDestination = defaultTaskSettings.ImageDestination;
                    ImageFileDestination = defaultTaskSettings.ImageFileDestination;
                    TextDestination = defaultTaskSettings.TextDestination;
                    TextFileDestination = defaultTaskSettings.TextFileDestination;
                    FileDestination = defaultTaskSettings.FileDestination;
                    URLShortenerDestination = defaultTaskSettings.URLShortenerDestination;
                    URLSharingServiceDestination = defaultTaskSettings.URLSharingServiceDestination;
                }

                if (UseDefaultGeneralSettings)
                    GeneralSettings = defaultTaskSettings.GeneralSettings;

                if (UseDefaultImageSettings)
                    ImageSettings = defaultTaskSettings.ImageSettings;

                if (UseDefaultCaptureSettings)
                    CaptureSettings = defaultTaskSettings.CaptureSettings;

                if (UseDefaultUploadSettings)
                    UploadSettings = defaultTaskSettings.UploadSettings;

                if (UseDefaultActions)
                    ExternalPrograms = defaultTaskSettings.ExternalPrograms;

                if (UseDefaultIndexerSettings)
                    IndexerSettings = defaultTaskSettings.IndexerSettings;

                if (UseDefaultAdvancedSettings)
                    AdvancedSettings = defaultTaskSettings.AdvancedSettings;
            }
        }

        public string CaptureFolder
        {
            get
            {
                if (!string.IsNullOrEmpty(AdvancedSettings.CapturePath))
                    return AdvancedSettings.CapturePath;

                return Program.ScreenshotsFolder;
            }
        }
    }
}
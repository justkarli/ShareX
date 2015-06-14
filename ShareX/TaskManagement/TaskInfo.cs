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

using System;
using System.IO;
using ShareX.HelpersLib;
using ShareX.UploadersLib;
using ShareX.UploadersLib.HelperClasses;

namespace ShareX
{
    public class TaskInfo
    {
        public TaskInfo(TaskSettings taskSettings)
        {
            if (taskSettings == null)
                taskSettings = TaskSettings.GetDefaultTaskSettings();

            TaskSettings = taskSettings;
            Result = new UploadResult();
        }

        private bool IsTextFileUpload()
        {
            return (DataType == EDataType.Text && TaskSettings.TextDestination == TextDestination.FileUploader);
        }

        private bool IsImageFileUpload()
        {
            return (DataType == EDataType.Image && TaskSettings.ImageDestination == ImageDestination.FileUploader);
        }

        private string GetUploadDestination()
        {
            switch (UploadDestination)
            {
                case EDataType.Image:
                    return TaskSettings.ImageDestination.GetLocalizedDescription();
                case EDataType.Text:
                    return TaskSettings.TextDestination.GetLocalizedDescription();
                case EDataType.File:
                    switch (DataType)
                    {
                        case EDataType.Image:
                            return TaskSettings.ImageFileDestination.GetLocalizedDescription();
                        case EDataType.Text:
                            return TaskSettings.TextFileDestination.GetLocalizedDescription();
                        default:
                        case EDataType.File:
                            return TaskSettings.FileDestination.GetLocalizedDescription();
                    }
                case EDataType.URL:
                    if (Job == TaskJob.ShareURL)
                    {
                        return TaskSettings.URLSharingServiceDestination.GetLocalizedDescription();
                    }

                    return TaskSettings.URLShortenerDestination.GetLocalizedDescription();
            }
            return string.Empty;
        }

        public string UploaderHost
        {
            get
            {
                if (IsUploadJob)
                    return GetUploadDestination();

                return string.Empty;
            }
        }

        public TaskSettings TaskSettings { get; set; }
        public TaskJob Job { get; set; }

        public ProgressManager Progress { get; set; }

        public EDataType DataType { get; set; }
        public EDataType UploadDestination
        {
            get
            {
                if (IsImageFileUpload() || IsTextFileUpload())
                    return EDataType.File;

                return DataType;
            }
        }

        public DateTime StartTime { get; set; }
        public DateTime UploadTime { get; set; }
        public TimeSpan UploadDuration
        {
            get { return UploadTime - StartTime; }
        }

        public UploadResult Result { get; set; }

        public string Status { get; set; }

        public bool IsUploadJob
        {
            get { return Job != TaskJob.Job || TaskSettings.AfterCaptureJob.HasFlag(AfterCaptureTasks.UploadImageToHost); }
        }

        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value;

                if (string.IsNullOrEmpty(filePath))
                    FileName = string.Empty;
                else
                    FileName = Path.GetFileName(filePath);
            }
        }

        public string FileName { get; set; }
        public string ThumbnailFilePath { get; set; }
    }
}
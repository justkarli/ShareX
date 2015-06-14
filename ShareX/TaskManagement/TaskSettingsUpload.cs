using System;

namespace ShareX.TaskManagement
{
    public class TaskSettingsUpload
    {
        //#region Upload

        public bool UseCustomTimeZone = false;
        public TimeZoneInfo CustomTimeZone = TimeZoneInfo.Utc;
        public string NameFormatPattern = "%y-%mo-%d_%h-%mi-%s"; // Test: %y %mo %mon %mon2 %d %h %mi %s %ms %w %w2 %pm %rn %ra %width %height %app %ver
        public string NameFormatPatternActiveWindow = "%t_%y-%mo-%d_%h-%mi-%s";
        public bool FileUploadUseNamePattern = false;

        //#endregion Upload

        //#region Upload / Clipboard upload

        public bool ClipboardUploadURLContents = false;
        public bool ClipboardUploadShortenURL = false;
        public bool ClipboardUploadShareURL = false;
        public bool ClipboardUploadAutoIndexFolder = false;

        //#endregion Upload / Clipboard upload
    }
}

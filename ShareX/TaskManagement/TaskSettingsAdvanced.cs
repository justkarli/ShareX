using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using ShareX.HelpersLib;

namespace ShareX.TaskManagement
{
    public class TaskSettingsAdvanced
    {
        [Category("General"), DefaultValue(false), Description("Allow after capture tasks for image files by treating them as images when files are handled during file upload, clipboard file upload, drag & drop, watch folder and other tasks.")]
        public bool ProcessImagesDuringFileUpload { get; set; }

        [Category("General"), DefaultValue(false), Description("Use after capture tasks for clipboard image upload.")]
        public bool ProcessImagesDuringClipboardUpload { get; set; }

        [Category("General"), DefaultValue(false), Description("If task contains upload job then this setting will clear clipboard when task start.")]
        public bool AutoClearClipboard { get; set; }

        [Category("Image"), DefaultValue(256), Description("Preferred thumbnail width. 0 means aspect ratio will be used to adjust width according to height.")]
        public int ThumbnailPreferredWidth { get; set; }

        [Category("Image"), DefaultValue(0), Description("Preferred thumbnail height. 0 means aspect ratio will be used to adjust height according to width.")]
        public int ThumbnailPreferredHeight { get; set; }

        [Category("Paths"), Description("Custom capture path takes precedence over path configured in Application configuration.")]
        [Editor(typeof(DirectoryNameEditor), typeof(UITypeEditor))]
        public string CapturePath { get; set; }

        [Category("Upload"), Description("Files with these file extensions will be uploaded using image uploader.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> ImageExtensions { get; set; }

        [Category("Upload"), Description("Files with these file extensions will be uploaded using text uploader.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> TextExtensions { get; set; }

        [Category("After upload"), DefaultValue("$result"),
        Description("Clipboard content format after uploading. Supported variables: $result, $url, $shorturl, $thumbnailurl, $deletionurl, $filepath, $filename, $filenamenoext, $folderpath, $foldername, $uploadtime and other variables such as %y-%mo-%d etc.")]
        public string ClipboardContentFormat { get; set; }

        [Category("After upload"), DefaultValue("$result"), Description("Balloon tip content format after uploading. Supported variables: $result, $url, $shorturl, $thumbnailurl, $deletionurl, $filepath, $filename, $filenamenoext, $folderpath, $foldername, $uploadtime and other variables such as %y-%mo-%d etc.")]
        public string BalloonTipContentFormat { get; set; }

        [Category("After upload"), DefaultValue("$result"), Description("After upload task \"Open URL\" format. Supported variables: $result, $url, $shorturl, $thumbnailurl, $deletionurl, $filepath, $filename, $filenamenoext, $folderpath, $foldername, $uploadtime and other variables such as %y-%mo-%d etc.")]
        public string OpenURLFormat { get; set; }

        [Category("After upload / Automatic URL Shortener"), DefaultValue(0), Description("Automatically shorten URL if the URL is longer than the specified number of characters. 0 means automatic URL shortening is not active.")]
        public int AutoShortenURLLength { get; set; }

        private float toastWindowDuration;

        [Category("After upload / Notifications"), DefaultValue(3f), Description("Specify how long should toast notification window will stay on screen (in seconds).")]
        public float ToastWindowDuration
        {
            get { return toastWindowDuration; }
            set { toastWindowDuration = Math.Max(value, 0f); }
        }

        [Category("After upload / Notifications"), DefaultValue(ContentAlignment.BottomRight), Description("Specify where should toast notification window appear on the screen.")]
        public ContentAlignment ToastWindowPlacement { get; set; }

        [Category("After upload / Notifications"), DefaultValue(ToastClickAction.OpenUrl), Description("Specify action after toast notification window is left clicked."), TypeConverter(typeof(EnumDescriptionConverter))]
        public ToastClickAction ToastWindowClickAction { get; set; }

        private Size toastWindowSize;

        [Category("After upload / Notifications"), DefaultValue(typeof(Size), "400, 300"), Description("Maximum toast notification window size.")]
        public Size ToastWindowSize
        {
            get { return toastWindowSize; }
            set { toastWindowSize = new Size(Math.Max(value.Width, 100), Math.Max(value.Height, 100)); }
        }

        [Category("After upload"), DefaultValue(false), Description("After upload form will be automatically closed after 60 seconds.")]
        public bool AutoCloseAfterUploadForm { get; set; }

        [Category("Interaction"), DefaultValue(false), Description("Disable notifications")]
        public bool DisableNotifications { get; set; }

        [Category("Upload text"), DefaultValue("txt"), Description("File extension when saving text to the local hard disk.")]
        public string TextFileExtension { get; set; }

        [Category("Upload text"), DefaultValue("text"), Description("Text format e.g. csharp, cpp, etc.")]
        public string TextFormat { get; set; }

        [Category("Upload text"), DefaultValue(""), Description("Custom text input. Use %input for text input. Example you can create web page with your text in it."),
        Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string TextCustom { get; set; }

        [Category("Upload text"), DefaultValue(true), Description("HTML encode custom text input.")]
        public bool TextCustomEncodeInput { get; set; }

        [Category("Name pattern"), DefaultValue(100), Description("Maximum name pattern length for file name.")]
        public int NamePatternMaxLength { get; set; }

        [Category("Name pattern"), DefaultValue(50), Description("Maximum name pattern title (%t) length for file name.")]
        public int NamePatternMaxTitleLength { get; set; }

        [Category("Tools"), DefaultValue("$r, $g, $b"), Description("Copy this color format to clipboard after using screen color picker. Formats: $r, $g, $b, $hex, $x, $y")]
        public string ScreenColorPickerFormat { get; set; }

        public TaskSettingsAdvanced()
        {
            this.ApplyDefaultPropertyValues();
            ImageExtensions = Enum.GetNames(typeof(ImageFileExtensions)).ToList();
            TextExtensions = Enum.GetNames(typeof(TextFileExtensions)).ToList();
        }
    }
}

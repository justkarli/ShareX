using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareX.Hotkey
{
    public enum HotkeyCommandEnum
    {
        None,
        FileUpload,
        FolderUpload,
        ClipboardUpload,
        ClipboardUploadWithContentViewer,
        UploadURL,
        DragDropUpload,
        StopUploads,
        PrintScreen,
        ActiveWindow,
        ActiveMonitor,
        RectangleRegion,
        WindowRectangle,
        RectangleAnnotate,
        RectangleLight,
        RectangleTransparent,
        RoundedRectangleRegion,
        EllipseRegion,
        TriangleRegion,
        DiamondRegion,
        PolygonRegion,
        FreeHandRegion,
        CustomRegion,
        LastRegion,
        ScreenRecorder,
        StartScreenRecorder,
        ScreenRecorderGIF,
        StartScreenRecorderGIF,
        AutoCapture,
        StartAutoCapture,
        OpenScreenshotsFolder,
        ColorPicker,
        ScreenColorPicker,
        Ruler,
        FTPClient,
        HashCheck,
        IndexFolder,
        ImageEffects,
        QRCode,
        TweetMessage,
        Automate
    }
}

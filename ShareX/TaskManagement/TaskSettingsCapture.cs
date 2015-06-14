using System.Drawing;
using ShareX.ScreenCaptureLib;

namespace ShareX.TaskManagement
{
    public class TaskSettingsCapture
    {
        //#region Capture / General

        public bool ShowCursor = true;
        public bool CaptureTransparent = false;
        public bool CaptureShadow = true;
        public int CaptureShadowOffset = 20;
        public bool CaptureClientArea = false;
        public bool IsDelayScreenshot = false;
        public decimal DelayScreenshot = 2.0m;
        public bool CaptureAutoHideTaskbar = false;
        public Rectangle CaptureCustomRegion = new Rectangle(0, 0, 0, 0);

        //#endregion Capture / General

        //#region Capture / Region capture

        public SurfaceOptions SurfaceOptions = new SurfaceOptions();

        //#endregion Capture / Region capture

        //#region Capture / Screen recorder

        public FFmpegOptions FFmpegOptions = new FFmpegOptions();
        public int ScreenRecordFPS = 20;
        public int GIFFPS = 5;
        public bool ScreenRecordFixedDuration = false;
        public float ScreenRecordDuration = 3f;
        public bool ScreenRecordAutoStart = true;
        public float ScreenRecordStartDelay = 0.5f;
        public bool RunScreencastCLI = false;
        public int VideoEncoderSelected = 0;

        //#endregion Capture / Screen recorder

        //#region Capture / Rectangle annotate

        public RectangleAnnotateOptions RectangleAnnotateOptions = new RectangleAnnotateOptions();

        //#endregion Capture / Rectangle annotate
    }
}

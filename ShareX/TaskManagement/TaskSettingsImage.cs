using System.Collections.Generic;
using Newtonsoft.Json;
using ShareX.HelpersLib;
using ShareX.ImageEffectsLib;

namespace ShareX.TaskManagement
{
    public class TaskSettingsImage
    {
        //#region Image / General

        public EImageFormat ImageFormat = EImageFormat.PNG;
        public int ImageJPEGQuality = 90;
        public GIFQuality ImageGIFQuality = GIFQuality.Default;
        public int ImageSizeLimit = 1024;
        public EImageFormat ImageFormat2 = EImageFormat.JPEG;
        public FileExistAction FileExistAction = FileExistAction.Ask;

        //#endregion Image / General

        //#region Image / Effects

        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Auto)]
        public List<ImageEffect> ImageEffects = ImageEffectManager.GetDefaultImageEffects();

        public bool ShowImageEffectsWindowAfterCapture = false;
        public bool ImageEffectOnlyRegionCapture = false;

        //#endregion Image / Effects

        //#region Image / Thumbnail

        public int ThumbnailWidth = 200;
        public int ThumbnailHeight = 0;
        public string ThumbnailName = "-thumbnail";
        public bool ThumbnailCheckSize = false;

        //#endregion Image / Thumbnail
    }
}

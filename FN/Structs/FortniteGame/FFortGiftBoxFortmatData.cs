using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortGiftBoxFortmatData
    {
        public string StringAssetType;
        public string StringData;

        public FFortGiftBoxFortmatData(FStructFallback fallback)
        {
            StringAssetType = fallback.GetOrDefault<string>(nameof(StringAssetType));
            StringData = fallback.GetOrDefault<string>(nameof(StringData));
        }
    }
}
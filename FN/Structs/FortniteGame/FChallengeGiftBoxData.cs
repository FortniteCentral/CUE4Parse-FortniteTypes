using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FChallengeGiftBoxData
    {
        public FSoftObjectPath GiftBoxToUse; // UFortGiftBoxItemDefinition
        public FFortGiftBoxFortmatData GiftBoxFormatData;

        public FChallengeGiftBoxData(FStructFallback fallback)
        {
            GiftBoxToUse = fallback.GetOrDefault<FSoftObjectPath>(nameof(GiftBoxToUse));
            GiftBoxFormatData = fallback.GetOrDefault<FFortGiftBoxFortmatData>(nameof(GiftBoxFormatData));
        }
    }
}
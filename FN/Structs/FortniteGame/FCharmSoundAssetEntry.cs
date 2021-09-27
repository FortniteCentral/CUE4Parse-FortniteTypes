using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCharmSoundAssetEntry 
    {
        public FSoftObjectPath Sound; // USoundBase
        public FName Desc;

        public FCharmSoundAssetEntry(FStructFallback fallback)
        {
            Sound = fallback.GetOrDefault<FSoftObjectPath>(nameof(Sound));
            Desc = fallback.GetOrDefault<FName>(nameof(Desc));
        }
    }
}
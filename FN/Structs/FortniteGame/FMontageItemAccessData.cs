using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FMontageItemAccessData 
    {
        public FGameplayTag AccessTag;
        public FPackageIndex AccessToken; // UFortItemAccessTokenType

        public FMontageItemAccessData(FStructFallback fallback)
        {
            AccessTag = fallback.GetOrDefault<FGameplayTag>(nameof(AccessTag));
            AccessToken = fallback.GetOrDefault<FPackageIndex>(nameof(AccessToken));
        }
    }
}
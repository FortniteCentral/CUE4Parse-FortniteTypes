using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FMontageItemAccessData 
    {
        public FGameplayTag AccessTag;
        public UFortItemAccessTokenType AccessToken;

        public FMontageItemAccessData(FStructFallback fallback)
        {
            AccessTag = fallback.GetOrDefault<FGameplayTag>(nameof(AccessTag));
            AccessToken = fallback.GetOrDefault<UFortItemAccessTokenType>(nameof(AccessToken));
        }
    }
}
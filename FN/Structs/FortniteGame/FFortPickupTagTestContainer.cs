using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortPickupTagTestContainer 
    {
        public FGameplayTagContainer Tags;
        public FText FailReason;

        public FFortPickupTagTestContainer(FStructFallback fallback)
        {
            Tags = fallback.GetOrDefault<FGameplayTagContainer>(nameof(Tags));
            FailReason = fallback.GetOrDefault<FText>(nameof(FailReason));
        }
    }
}
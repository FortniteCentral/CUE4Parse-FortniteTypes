using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortConditionalIncludeTags 
    {
        public FGameplayTagContainer ConditionTags;
        public FGameplayTagContainer IncludeTags;

        public FFortConditionalIncludeTags(FStructFallback fallback)
        {
            ConditionTags = fallback.GetOrDefault<FGameplayTagContainer>(nameof(ConditionTags));
            IncludeTags = fallback.GetOrDefault<FGameplayTagContainer>(nameof(IncludeTags));
        }
    }
}
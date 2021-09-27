using CUE4Parse.FN.Structs.GA;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortTooltipDisplayStatInfo 
    {
        public FGameplayTag Token;
        public FGameplayAttribute Attribute;
        public FGameplayTagContainer ContextTags;
        public bool bLowerIsBetter;

        public FFortTooltipDisplayStatInfo(FStructFallback fallback)
        {
            Token = fallback.GetOrDefault<FGameplayTag>(nameof(Token));
            Attribute = fallback.GetOrDefault<FGameplayAttribute>(nameof(Attribute));
            ContextTags = fallback.GetOrDefault<FGameplayTagContainer>(nameof(ContextTags));
            bLowerIsBetter = fallback.GetOrDefault<bool>(nameof(bLowerIsBetter));
        }
    }
}
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortCosmeticAdaptiveStatPair 
    {
        public FGameplayTag StatTag; // FFortStatManagerTag
        public int StatValue;

        public FFortCosmeticAdaptiveStatPair(FStructFallback fallback)
        {
            StatTag = fallback.GetOrDefault<FGameplayTag>(nameof(StatTag));
            StatValue = fallback.GetOrDefault<int>(nameof(StatValue));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.GT
{
    [StructFallback]
    public class FGameplayTag 
    {
        public FName TagName;

        public FGameplayTag(FStructFallback fallback)
        {
            TagName = fallback.GetOrDefault<FName>(nameof(TagName));
        }
    }
}
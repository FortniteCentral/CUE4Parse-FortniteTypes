using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortMissionConfigDataBucket
    {
        public FGameplayTag Tag;
        public FSoftObjectPath ConfigDataClass; // UClass

        public FFortMissionConfigDataBucket(FStructFallback fallback)
        {
            Tag = fallback.GetOrDefault<FGameplayTag>(nameof(Tag));
            ConfigDataClass = fallback.GetOrDefault<FSoftObjectPath>(nameof(ConfigDataClass));
        }
    }
}
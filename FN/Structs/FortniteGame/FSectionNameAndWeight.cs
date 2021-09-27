using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FSectionNameAndWeight 
    {
        public FName SectionName;
        public float SectionWeight;

        public FSectionNameAndWeight(FStructFallback fallback)
        {
            SectionName = fallback.GetOrDefault<FName>(nameof(SectionName));
            SectionWeight = fallback.GetOrDefault<float>(nameof(SectionWeight));
        }
    }
}
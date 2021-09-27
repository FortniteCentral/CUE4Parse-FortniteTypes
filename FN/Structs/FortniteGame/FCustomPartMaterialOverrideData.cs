using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCustomPartMaterialOverrideData 
    {
        public int MaterialOverrideIndex;
        public FSoftObjectPath OverrideMaterial; // UMaterialInterface

        public FCustomPartMaterialOverrideData(FStructFallback fallback)
        {
            MaterialOverrideIndex = fallback.GetOrDefault<int>(nameof(MaterialOverrideIndex));
            OverrideMaterial = fallback.GetOrDefault<FSoftObjectPath>(nameof(OverrideMaterial));
        }
    }
}
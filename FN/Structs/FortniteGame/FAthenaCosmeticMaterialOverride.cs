using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FAthenaCosmeticMaterialOverride : FCustomPartMaterialOverrideData
    {
        public FName ComponentName;

        public FAthenaCosmeticMaterialOverride(FStructFallback fallback) : base(fallback)
        {
            ComponentName = fallback.GetOrDefault<FName>(nameof(ComponentName));
        }
    }
}
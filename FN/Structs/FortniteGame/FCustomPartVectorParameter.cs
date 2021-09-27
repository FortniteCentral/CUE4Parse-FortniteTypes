using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCustomPartVectorParameter 
    {
        public int MaterialIndexForVectorParameter;
        public FName VectorParameterNameForMaterial;
        public FLinearColor VectorOverride;

        public FCustomPartVectorParameter(FStructFallback fallback)
        {
            MaterialIndexForVectorParameter = fallback.GetOrDefault<int>(nameof(MaterialIndexForVectorParameter));
            VectorParameterNameForMaterial = fallback.GetOrDefault<FName>(nameof(VectorParameterNameForMaterial));
            VectorOverride = fallback.GetOrDefault<FLinearColor>(nameof(VectorOverride));
        }
    }
}
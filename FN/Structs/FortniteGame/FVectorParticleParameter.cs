using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FVectorParticleParameter 
    {
        public FVector Value;
        public FName ParameterName;

        public FVectorParticleParameter(FStructFallback fallback)
        {
            Value = fallback.GetOrDefault<FVector>(nameof(Value));
            ParameterName = fallback.GetOrDefault<FName>(nameof(ParameterName));
        }
    }
}
using CUE4Parse.FN.Structs.DataRegistry;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.GA
{
    [StructFallback]
    public class FScalableFloat 
    {
        public float Value;
        public FCurveTableRowHandle Curve;
        public FDataRegistryType RegistryType;

        public FScalableFloat(FStructFallback fallback)
        {
            Value = fallback.GetOrDefault<float>(nameof(Value));
            Curve = fallback.GetOrDefault<FCurveTableRowHandle>(nameof(Curve));
            RegistryType = fallback.GetOrDefault<FDataRegistryType>(nameof(RegistryType));
        }
    }
}
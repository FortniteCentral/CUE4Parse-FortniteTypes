using CUE4Parse.FN.Enums.Engine;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FAttachToComponentParams 
    {
        public EAttachmentRule LocationRule;
        public EAttachmentRule RotationRule;
        public EAttachmentRule ScaleRule;
        public bool bWeldSimulatedBodies;

        public FAttachToComponentParams(FStructFallback fallback)
        {
            LocationRule = fallback.GetOrDefault<EAttachmentRule>(nameof(LocationRule));
            RotationRule = fallback.GetOrDefault<EAttachmentRule>(nameof(RotationRule));
            ScaleRule = fallback.GetOrDefault<EAttachmentRule>(nameof(ScaleRule));
            bWeldSimulatedBodies = fallback.GetOrDefault<bool>(nameof(bWeldSimulatedBodies));
        }
    }
}
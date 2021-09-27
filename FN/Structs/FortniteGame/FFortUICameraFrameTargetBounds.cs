using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortUICameraFrameTargetBounds 
    {
        public FVector Origin;
        public float CylinderHalfHeight;
        public float CylinderRadius;

        public FFortUICameraFrameTargetBounds(FStructFallback fallback)
        {
            Origin = fallback.GetOrDefault<FVector>(nameof(Origin));
            CylinderHalfHeight = fallback.GetOrDefault<float>(nameof(CylinderHalfHeight));
            CylinderRadius = fallback.GetOrDefault<float>(nameof(CylinderRadius));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;

namespace CUE4Parse.FN.Structs.FortniteUI
{
    [StructFallback]
    public class FFortMtxGradient 
    {
        public FLinearColor Start;
        public FLinearColor Stop;

        public FFortMtxGradient(FStructFallback fallback)
        {
            Start = fallback.GetOrDefault<FLinearColor>(nameof(Start));
            Stop = fallback.GetOrDefault<FLinearColor>(nameof(Stop));
        }
    }
}
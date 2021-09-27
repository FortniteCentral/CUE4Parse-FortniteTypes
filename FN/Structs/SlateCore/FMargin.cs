using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.SlateCore
{
    [StructFallback]
    public class FMargin 
    {
        public float Left;
        public float Top;
        public float Right;
        public float Bottom;

        public FMargin(FStructFallback fallback)
        {
            Left = fallback.GetOrDefault<float>(nameof(Left));
            Top = fallback.GetOrDefault<float>(nameof(Top));
            Right = fallback.GetOrDefault<float>(nameof(Right));
            Bottom = fallback.GetOrDefault<float>(nameof(Bottom));
        }
    }
}
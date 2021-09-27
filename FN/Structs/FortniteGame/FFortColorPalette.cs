using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortColorPalette 
    {
        public FLinearColor Color1;
        public FLinearColor Color2;
        public FLinearColor Color3;
        public FLinearColor Color4;
        public FLinearColor Color5;

        public FFortColorPalette(FStructFallback fallback)
        {
            Color1 = fallback.GetOrDefault<FLinearColor>(nameof(Color1));
            Color2 = fallback.GetOrDefault<FLinearColor>(nameof(Color2));
            Color3 = fallback.GetOrDefault<FLinearColor>(nameof(Color3));
            Color4 = fallback.GetOrDefault<FLinearColor>(nameof(Color4));
            Color5 = fallback.GetOrDefault<FLinearColor>(nameof(Color5));
        }
    }
}
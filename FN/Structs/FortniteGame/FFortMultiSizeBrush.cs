using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortMultiSizeBrush 
    {
        public FSlateBrush Brush_XXS;
        public FSlateBrush Brush_XS;
        public FSlateBrush Brush_S;
        public FSlateBrush Brush_M;
        public FSlateBrush Brush_L;
        public FSlateBrush Brush_XL;

        public FFortMultiSizeBrush(FStructFallback fallback)
        {
            Brush_XXS = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_XXS));
            Brush_XS = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_XS));
            Brush_S = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_S));
            Brush_M = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_M));
            Brush_L = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_L));
            Brush_XL = fallback.GetOrDefault<FSlateBrush>(nameof(Brush_XL));
        }
    }
}
using CUE4Parse.FN.Enums.SlateCore;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;

namespace CUE4Parse.FN.Structs.SlateCore
{
    [StructFallback]
    public class FSlateColor 
    {
        public FLinearColor SpecifiedColor;
        public ESlateColorStylingMode ColorUseRule;

        public FSlateColor(FStructFallback fallback)
        {
            SpecifiedColor = fallback.GetOrDefault<FLinearColor>(nameof(SpecifiedColor));
            ColorUseRule = fallback.GetOrDefault<ESlateColorStylingMode>(nameof(ColorUseRule));
        }
    }
}
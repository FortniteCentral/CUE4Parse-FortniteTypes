using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FBundleGoalCardDisplayData
    {
        public FText HeaderText;
        public FLinearColor HeaderColor;
        public FText SubHeaderText;
        public FLinearColor SubHeaderColor;
        public FSoftObjectPath HeaderIcon; // UObject

        public FBundleGoalCardDisplayData(FStructFallback fallback)
        {
            HeaderText = fallback.GetOrDefault<FText>(nameof(HeaderText));
            HeaderColor = fallback.GetOrDefault<FLinearColor>(nameof(HeaderColor));
            SubHeaderText = fallback.GetOrDefault<FText>(nameof(SubHeaderText));
            SubHeaderColor = fallback.GetOrDefault<FLinearColor>(nameof(SubHeaderColor));
            HeaderIcon = fallback.GetOrDefault<FSoftObjectPath>(nameof(HeaderIcon));
        }
    }
}
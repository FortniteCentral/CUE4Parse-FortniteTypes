using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortTooltipDisplayStatsCategory 
    {
        public FText CategoryName;
        public FFortTooltipDisplayStatInfo[] TooltipStats;

        public FFortTooltipDisplayStatsCategory(FStructFallback fallback)
        {
            CategoryName = fallback.GetOrDefault<FText>(nameof(CategoryName));
            TooltipStats = fallback.GetOrDefault<FFortTooltipDisplayStatInfo[]>(nameof(TooltipStats));
        }
    }
}
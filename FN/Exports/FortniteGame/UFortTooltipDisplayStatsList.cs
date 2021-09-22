using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortTooltipDisplayStatsList : UObject
    {
        public FFortTooltipDisplayStatsCategory[]? TooltipCategories;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            TooltipCategories = GetOrDefault<FFortTooltipDisplayStatsCategory[]>(nameof(TooltipCategories));
        }
    }
}
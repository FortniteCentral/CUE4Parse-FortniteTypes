using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortBadgeItemDefinition : UFortWorldItemDefinition
    {
        public FText? DisplayText;
        public FText? FailedDisplayText;
        public FLinearColor BadgeColor;
        public int UIMissionPointsOffset;
        public FDataTableRowHandle? BadgeScoringValuesHandle;
        public FSoftObjectPath BadgeCardPackReward; // UFortCardPackItemDefinition
        public FFortItemQuantityPair[]? ItemRewards;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DisplayText = GetOrDefault<FText>(nameof(DisplayText));
            FailedDisplayText = GetOrDefault<FText>(nameof(FailedDisplayText));
            BadgeColor = GetOrDefault<FLinearColor>(nameof(BadgeColor));
            UIMissionPointsOffset = GetOrDefault<int>(nameof(UIMissionPointsOffset));
            BadgeScoringValuesHandle = GetOrDefault<FDataTableRowHandle>(nameof(BadgeScoringValuesHandle));
            BadgeCardPackReward = GetOrDefault<FSoftObjectPath>(nameof(BadgeCardPackReward));
            ItemRewards = GetOrDefault<FFortItemQuantityPair[]>(nameof(ItemRewards));
        }
    }
}
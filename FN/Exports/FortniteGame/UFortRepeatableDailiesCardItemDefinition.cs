using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortRepeatableDailiesCardItemDefinition : UFortAccountItemDefinition
    {
        public string? GranterQuestPack;
        public int FillCount;
        public FScalableFloat? ReplacedRestedXpValue;
        public FScalableFloat? ReducedXPReward;
        public FScalableFloat? ReplacedRestedXpValueScalarForMissedDays;
        public FSoftObjectPath RequiredItemDef; // UFortAthenaRewardEventGraphPurchaseToken
        public FRepeatableDailiesCardDateOverride[]? DateOverrides;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            GranterQuestPack = GetOrDefault<string>(nameof(GranterQuestPack));
            FillCount = GetOrDefault<int>(nameof(FillCount));
            ReplacedRestedXpValue = GetOrDefault<FScalableFloat>(nameof(ReplacedRestedXpValue));
            ReducedXPReward = GetOrDefault<FScalableFloat>(nameof(ReducedXPReward));
            ReplacedRestedXpValueScalarForMissedDays = GetOrDefault<FScalableFloat>(nameof(ReplacedRestedXpValueScalarForMissedDays));
            RequiredItemDef = GetOrDefault<FSoftObjectPath>(nameof(RequiredItemDef));
            DateOverrides = GetOrDefault<FRepeatableDailiesCardDateOverride[]>(nameof(DateOverrides));
        }
    }
}
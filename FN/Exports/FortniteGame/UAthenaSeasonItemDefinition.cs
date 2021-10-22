using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaSeasonItemDefinition : UFortItemDefinition
    {
        public bool bXpOnlySeason;
        public bool bCapFreeBattlePassLevels;
        public bool bUseSeasonCurveForBattlePassRewards;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bXpOnlySeason = GetOrDefault<bool>(nameof(bXpOnlySeason));
            bCapFreeBattlePassLevels = GetOrDefault<bool>(nameof(bCapFreeBattlePassLevels));
            bUseSeasonCurveForBattlePassRewards = GetOrDefault<bool>(nameof(bUseSeasonCurveForBattlePassRewards));
        }
    }
}
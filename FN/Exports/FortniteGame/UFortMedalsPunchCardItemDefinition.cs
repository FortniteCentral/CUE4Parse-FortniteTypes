using CUE4Parse.FN.Structs.GA;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortMedalsPunchCardItemDefinition : UFortItemDefinition
    {
        public int NumPunches;
        public bool bAllowMedalReplacement;
        public FScalableFloat? PunchCardXpRewards;
        public FScalableFloat? PunchCardRestXp;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            NumPunches = GetOrDefault<int>(nameof(NumPunches));
            bAllowMedalReplacement = GetOrDefault<bool>(nameof(bAllowMedalReplacement));
            PunchCardXpRewards = GetOrDefault<FScalableFloat>(nameof(PunchCardXpRewards));
            PunchCardRestXp = GetOrDefault<FScalableFloat>(nameof(PunchCardRestXp));
        }
    }
}
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeBundleLevelReward
    {
        public FAthenaRewardItemReference RewardItem;
        public int NumObjectivesNeeded;
        
        public FFortChallengeBundleLevelReward(FStructFallback fallback)
        {
            RewardItem = fallback.GetOrDefault<FAthenaRewardItemReference>(nameof(RewardItem));
            NumObjectivesNeeded = fallback.GetOrDefault<int>(nameof(NumObjectivesNeeded));
        }
    }
}
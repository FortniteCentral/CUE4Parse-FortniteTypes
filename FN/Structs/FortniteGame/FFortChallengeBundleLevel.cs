using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeBundleLevel
    {
        public FFortChallengeBundleLevelReward[] BundleLevelRewardEntries;

        public FFortChallengeBundleLevel(FStructFallback fallback)
        {
            BundleLevelRewardEntries = fallback.GetOrDefault<FFortChallengeBundleLevelReward[]>(nameof(BundleLevelRewardEntries));
        }
    }
}
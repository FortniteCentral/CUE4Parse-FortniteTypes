using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeBundleRewards
    {
        public int CompletionCount;
        public bool bBundlePrestige;
        public FAthenaRewardItemReference[] Rewards;

        public FFortChallengeBundleRewards(FStructFallback fallback)
        {
            CompletionCount = fallback.GetOrDefault<int>(nameof(CompletionCount));
            bBundlePrestige = fallback.GetOrDefault<bool>(nameof(bBundlePrestige));
            Rewards = fallback.GetOrDefault<FAthenaRewardItemReference[]>(nameof(Rewards));
        }
    }
}
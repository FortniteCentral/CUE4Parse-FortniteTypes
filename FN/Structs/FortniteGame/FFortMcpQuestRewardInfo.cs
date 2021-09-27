using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortMcpQuestRewardInfo
    {
        public FFortItemQuantityPair[] Rewards;
        
        public FFortMcpQuestRewardInfo(FStructFallback fallback)
        {
            Rewards = fallback.GetOrDefault<FFortItemQuantityPair[]>(nameof(Rewards));
        }
    }
}
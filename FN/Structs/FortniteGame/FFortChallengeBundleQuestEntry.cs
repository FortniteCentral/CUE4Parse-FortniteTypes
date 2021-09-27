using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeBundleQuestEntry
    {
        public FSoftObjectPath QuestDefinition; // UFortQuestItemDefinition
        public EChallengeBundleQuestUnlockType QuestUnlockType;
        public bool bStartActive;
        public bool bIsPrerequisite;
        public int UnlockValue;
        public FChallengeGiftBoxData RewardGiftBox;
        public FFortItemQuantityPair MenuOverrideRewardPreview;
        public int QuestChainLength;

        public FFortChallengeBundleQuestEntry(FStructFallback fallback)
        {
            QuestDefinition = fallback.GetOrDefault<FSoftObjectPath>(nameof(QuestDefinition));
            QuestUnlockType = fallback.GetOrDefault<EChallengeBundleQuestUnlockType>(nameof(QuestUnlockType));
            bStartActive = fallback.GetOrDefault<bool>(nameof(bStartActive));
            bIsPrerequisite = fallback.GetOrDefault<bool>(nameof(bIsPrerequisite));
            UnlockValue = fallback.GetOrDefault<int>(nameof(UnlockValue));
            RewardGiftBox = fallback.GetOrDefault<FChallengeGiftBoxData>(nameof(RewardGiftBox));
            MenuOverrideRewardPreview = fallback.GetOrDefault<FFortItemQuantityPair>(nameof(MenuOverrideRewardPreview));
            QuestChainLength = fallback.GetOrDefault<int>(nameof(QuestChainLength));
        }
    }
}
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortChallengeBundleItemDefinition : UFortAccountItemDefinition
    {
        public FFortChallengeBundleQuestEntry[]? QuestInfos;
        public FSoftObjectPath[]? SuppressedQuestDefs; // UFortQuestItemDefinition[]
        public string? CalendarEventTag;
        public string? CalendarEventName;
        public FFortChallengeBundleRewards[]? BundleCompletionRewards;
        public FFortChallengeBundleLevel[]? BundleLevelRewards;
        public FFortChallengeBundleSpecialOffer[]? SpecialOffers;
        public FSoftObjectPath[]? CareerQuestBitShifts; // UFortQuestItemDefinition[]
        public FBundleGoalCardDisplayData? GoalCardDisplayData;
        public FGameplayTag? GoalCardPinSeasonItemTag;
        public FSoftObjectPath NotificationIconOverride; // UObject
        public FFortChallengeSetStyle? DisplayStyle;
        public FAthenaRewardItemReference? OverrideRewardItem;
        public UAthenaCharacterItemDefinition? CharacterOverrideForRewardPreviews;
        public int MaxChainDepth;
        public FSoftObjectPath BundleHidenImageMaterial; // UMaterial
        public FText? UniqueLockedMessage;
        public bool bHideFromMapChallenges;
        public bool bHideFromMapChallengeUntilBundleExists;
        public bool bHideRewardFromMapChallenges;
        public bool bHideTimeRemaining;
        public bool bDeleteProgressTokenOnRemoval;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            QuestInfos = GetOrDefault<FFortChallengeBundleQuestEntry[]>(nameof(QuestInfos));
            SuppressedQuestDefs = GetOrDefault<FSoftObjectPath[]>(nameof(SuppressedQuestDefs));
            CalendarEventTag = GetOrDefault<string>(nameof(CalendarEventTag));
            CalendarEventName = GetOrDefault<string>(nameof(CalendarEventName));
            BundleCompletionRewards = GetOrDefault<FFortChallengeBundleRewards[]>(nameof(BundleCompletionRewards));
            BundleLevelRewards = GetOrDefault<FFortChallengeBundleLevel[]>(nameof(BundleLevelRewards));
            SpecialOffers = GetOrDefault<FFortChallengeBundleSpecialOffer[]>(nameof(SpecialOffers));
            CareerQuestBitShifts = GetOrDefault<FSoftObjectPath[]>(nameof(CareerQuestBitShifts));
            GoalCardDisplayData = GetOrDefault<FBundleGoalCardDisplayData>(nameof(GoalCardDisplayData));
            GoalCardPinSeasonItemTag = GetOrDefault<FGameplayTag>(nameof(GoalCardPinSeasonItemTag));
            NotificationIconOverride = GetOrDefault<FSoftObjectPath>(nameof(NotificationIconOverride));
            DisplayStyle = GetOrDefault<FFortChallengeSetStyle>(nameof(DisplayStyle));
            OverrideRewardItem = GetOrDefault<FAthenaRewardItemReference>(nameof(OverrideRewardItem));
            CharacterOverrideForRewardPreviews = GetOrDefault<UAthenaCharacterItemDefinition>(nameof(CharacterOverrideForRewardPreviews));
            MaxChainDepth = GetOrDefault<int>(nameof(MaxChainDepth));
            BundleHidenImageMaterial = GetOrDefault<FSoftObjectPath>(nameof(BundleHidenImageMaterial));
            UniqueLockedMessage = GetOrDefault<FText>(nameof(UniqueLockedMessage));
            bHideFromMapChallenges = GetOrDefault<bool>(nameof(bHideFromMapChallenges));
            bHideFromMapChallengeUntilBundleExists = GetOrDefault<bool>(nameof(bHideFromMapChallengeUntilBundleExists));
            bHideRewardFromMapChallenges = GetOrDefault<bool>(nameof(bHideRewardFromMapChallenges));
            bHideTimeRemaining = GetOrDefault<bool>(nameof(bHideTimeRemaining));
            bDeleteProgressTokenOnRemoval = GetOrDefault<bool>(nameof(bDeleteProgressTokenOnRemoval));
        }
    }
}
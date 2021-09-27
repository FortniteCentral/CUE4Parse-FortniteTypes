using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Exports.Engine;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortQuestItemDefinition : UFortAccountItemDefinition
    {
        public EFortQuestType QuestType;
        public EFortQuestSubtype QuestSubtype;
        public bool bShouldDisplayOverallQuestInformation;
        public bool bAthenaUpdateObjectiveOncePerMatch;
        public bool bAthenaGrantRarityToken;
        public bool bShouldAutoClaim;
        public bool bShouldGetFullMatchProgress;
        public bool bAthenaMustCompleteInSingleMatch;
        public bool bUpdateObjectiveOncePerMatch;
        public bool IsStreamingRequired;
        public bool bExpandsStormShield;
        public bool bHidden;
        public FSoftObjectPath TandemCharacterData; // UFortTandemCharacterData
        public FSoftObjectPath CharacterCompletionAudio; // USoundBase
        public float CharacterCompletionAudioDelay;
        public string? CompletionVideoUID;
        public bool bSuppressQuestGrantedEvent;
        public bool bInitiallySuppressedReplacementQuest;
        public bool bIncludedInCategories;
        public bool bAutoLaunch;
        public bool bDeprecated;
        public bool bDisableBackendConditionEvaluation;
        public bool bAllowTileMatching;
        public bool bAllowPlayNowNavigation;
        public bool bAllowMissionAlertMatchesBypassingTileRequirements;
        public bool bTutorialQuest;
        public bool bHideStageDescription;
        public bool bHideIncompleteObjectiveLocations;
        public bool bIsShared;
        public int ExpirationDuration;
        public int ObjectiveCompletionCount;
        public int Threshold;
        public FFortItemQuantityPair[]? Rewards;
        public UDataTable? RewardsTable;
        public string? QuestPool;
        public FFortHiddenRewardQuantityPair[]? HiddenReward;
        public string[]? FeatureRewards;
        public FFortMcpQuestRewardInfo[]? SelectableRewards;
        public FFortMcpQuestObjectiveInfo[]? Objectives;
        public FSoftObjectPath[]? TransientPrerequisiteQuests; // UFortQuestItemDefinition
        public bool bGrantTransientQuestToSquad;
        public bool bTransientAutoComplete;
        public bool bAllowMultipleCompletionsPerMatch;
        public FGameplayTagContainer Prerequisites;
        public FSoftObjectPath PrerequisiteQuest; // UFortQuestItemDefinition
        public FDataTableRowHandle? PrerequisiteObjective;
        public float Weight;
        public ushort GranterWindowPeriodMinutes;
        public ushort GranterCooldownPeriodSeconds;
        public FSoftObjectPath[]? QuestsToComplete; // UFortQuestItemDefinition[]
        public FDataTableRowHandle? Category;
        public FSoftObjectPath IntroConversation; // UFortConversation
        public FSoftObjectPath SelectRewardsConversation; // UFortConversation
        public FSoftObjectPath ClaimConversation; // UFortConversation
        public FText? RewardHeaderText;
        public FText? RewardDescription;
        public FText? CompletionText;
        public FText? NPCInteractionText;
        public FFortQuestMissionCreationContext[]? MissionCreationContexts;
        public FFortMissionConfigDataParams? MissionConfigMetadata;
        public uint ClaimPriority;
        public int SortPriority;
        public int TransientQuestStage;
        public int TransientQuestMaxStage;
        public FSoftObjectPath QuestAbilitySet; // UFortAbilitySet
        public bool bHideQuestProgressNotification;
        public bool bHideQuestRewardNotification;
        public bool bForceExpiryExport;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            QuestType = GetOrDefault<EFortQuestType>(nameof(QuestType));
            QuestSubtype = GetOrDefault<EFortQuestSubtype>(nameof(QuestSubtype));
            bShouldDisplayOverallQuestInformation = GetOrDefault<bool>(nameof(bShouldDisplayOverallQuestInformation));
            bAthenaUpdateObjectiveOncePerMatch = GetOrDefault<bool>(nameof(bAthenaUpdateObjectiveOncePerMatch));
            bAthenaGrantRarityToken = GetOrDefault<bool>(nameof(bAthenaGrantRarityToken));
            bShouldAutoClaim = GetOrDefault<bool>(nameof(bShouldAutoClaim));
            bShouldGetFullMatchProgress = GetOrDefault<bool>(nameof(bShouldGetFullMatchProgress));
            bAthenaMustCompleteInSingleMatch = GetOrDefault<bool>(nameof(bAthenaMustCompleteInSingleMatch));
            bUpdateObjectiveOncePerMatch = GetOrDefault<bool>(nameof(bUpdateObjectiveOncePerMatch));
            IsStreamingRequired = GetOrDefault<bool>(nameof(IsStreamingRequired));
            bExpandsStormShield = GetOrDefault<bool>(nameof(bExpandsStormShield));
            bHidden = GetOrDefault<bool>(nameof(bHidden));
            TandemCharacterData = GetOrDefault<FSoftObjectPath>(nameof(TandemCharacterData));
            CharacterCompletionAudio = GetOrDefault<FSoftObjectPath>(nameof(CharacterCompletionAudio));
            CharacterCompletionAudioDelay = GetOrDefault<float>(nameof(CharacterCompletionAudioDelay));
            CompletionVideoUID = GetOrDefault<string>(nameof(CompletionVideoUID));
            bSuppressQuestGrantedEvent = GetOrDefault<bool>(nameof(bSuppressQuestGrantedEvent));
            bInitiallySuppressedReplacementQuest = GetOrDefault<bool>(nameof(bInitiallySuppressedReplacementQuest));
            bIncludedInCategories = GetOrDefault<bool>(nameof(bIncludedInCategories));
            bAutoLaunch = GetOrDefault<bool>(nameof(bAutoLaunch));
            bDeprecated = GetOrDefault<bool>(nameof(bDeprecated));
            bDisableBackendConditionEvaluation = GetOrDefault<bool>(nameof(bDisableBackendConditionEvaluation));
            bAllowTileMatching = GetOrDefault<bool>(nameof(bAllowTileMatching));
            bAllowPlayNowNavigation = GetOrDefault<bool>(nameof(bAllowPlayNowNavigation));
            bAllowMissionAlertMatchesBypassingTileRequirements = GetOrDefault<bool>(nameof(bAllowMissionAlertMatchesBypassingTileRequirements));
            bTutorialQuest = GetOrDefault<bool>(nameof(bTutorialQuest));
            bHideStageDescription = GetOrDefault<bool>(nameof(bHideStageDescription));
            bHideIncompleteObjectiveLocations = GetOrDefault<bool>(nameof(bHideIncompleteObjectiveLocations));
            bIsShared = GetOrDefault<bool>(nameof(bIsShared));
            ExpirationDuration = GetOrDefault<int>(nameof(ExpirationDuration));
            ObjectiveCompletionCount = GetOrDefault<int>(nameof(ObjectiveCompletionCount));
            Threshold = GetOrDefault<int>(nameof(Threshold));
            Rewards = GetOrDefault<FFortItemQuantityPair[]>(nameof(Rewards));
            RewardsTable = GetOrDefault<UDataTable>(nameof(RewardsTable));
            QuestPool = GetOrDefault<string>(nameof(QuestPool));
            HiddenReward = GetOrDefault<FFortHiddenRewardQuantityPair[]>(nameof(HiddenReward));
            FeatureRewards = GetOrDefault<string[]>(nameof(FeatureRewards));
            SelectableRewards = GetOrDefault<FFortMcpQuestRewardInfo[]>(nameof(SelectableRewards));
            Objectives = GetOrDefault<FFortMcpQuestObjectiveInfo[]>(nameof(Objectives));
            TransientPrerequisiteQuests = GetOrDefault<FSoftObjectPath[]>(nameof(TransientPrerequisiteQuests));
            bGrantTransientQuestToSquad = GetOrDefault<bool>(nameof(bGrantTransientQuestToSquad));
            bTransientAutoComplete = GetOrDefault<bool>(nameof(bTransientAutoComplete));
            bAllowMultipleCompletionsPerMatch = GetOrDefault<bool>(nameof(bAllowMultipleCompletionsPerMatch));
            Prerequisites = GetOrDefault<FGameplayTagContainer>(nameof(Prerequisites));
            PrerequisiteQuest = GetOrDefault<FSoftObjectPath>(nameof(PrerequisiteQuest));
            PrerequisiteObjective = GetOrDefault<FDataTableRowHandle>(nameof(PrerequisiteObjective));
            Weight = GetOrDefault<float>(nameof(Weight));
            GranterWindowPeriodMinutes = GetOrDefault<ushort>(nameof(GranterWindowPeriodMinutes));
            GranterCooldownPeriodSeconds = GetOrDefault<ushort>(nameof(GranterCooldownPeriodSeconds));
            Category = GetOrDefault<FDataTableRowHandle>(nameof(Category));
            IntroConversation = GetOrDefault<FSoftObjectPath>(nameof(IntroConversation));
            SelectRewardsConversation = GetOrDefault<FSoftObjectPath>(nameof(SelectRewardsConversation));
            ClaimConversation = GetOrDefault<FSoftObjectPath>(nameof(ClaimConversation));
            RewardHeaderText = GetOrDefault<FText>(nameof(RewardHeaderText));
            RewardDescription = GetOrDefault<FText>(nameof(RewardDescription));
            CompletionText = GetOrDefault<FText>(nameof(CompletionText));
            NPCInteractionText = GetOrDefault<FText>(nameof(NPCInteractionText));
            MissionCreationContexts = GetOrDefault<FFortQuestMissionCreationContext[]>(nameof(MissionCreationContexts));
            MissionConfigMetadata = GetOrDefault<FFortMissionConfigDataParams>(nameof(MissionConfigMetadata));
            ClaimPriority = GetOrDefault<uint>(nameof(ClaimPriority));
            SortPriority = GetOrDefault<int>(nameof(SortPriority));
            TransientQuestStage = GetOrDefault<int>(nameof(TransientQuestStage));
            TransientQuestMaxStage = GetOrDefault<int>(nameof(TransientQuestMaxStage));
            QuestAbilitySet = GetOrDefault<FSoftObjectPath>(nameof(QuestAbilitySet));
            bHideQuestProgressNotification = GetOrDefault<bool>(nameof(bHideQuestProgressNotification));
            bHideQuestRewardNotification = GetOrDefault<bool>(nameof(bHideQuestRewardNotification));
            bForceExpiryExport = GetOrDefault<bool>(nameof(bForceExpiryExport));
        }
    }
}
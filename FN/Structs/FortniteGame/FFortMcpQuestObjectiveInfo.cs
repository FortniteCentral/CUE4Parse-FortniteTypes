using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortMcpQuestObjectiveInfo
    {
        public FName BackendName;
        public FFortQuestObjectiveStat[] InlineObjectiveStats;
        public FDataTableRowHandle ObjectiveStatHandle;
        public FDataTableRowHandle[] AlternativeStatHandles;
        public EFortQuestObjectiveItemEvent ItemEvent;
        public bool bHidden;
        public bool bRequirePrimaryMissionCompletion;
        public bool bCanProgressInZone;
        public bool bDisplayDynamicAnnouncementUpdate;
        public EObjectiveStatusUpdateType DynamicStatusUpdateType;
        public EFortInventoryFilter LinkVaultTab;
        public EFortFrontendInventoryFilter LinkToItemManagement;
        public FSoftObjectPath ItemReference; // UFortItemDefinition
        public string ItemTemplateIdOverride;
        public FName LinkSquadID;
        public int LinkSquadIndex;
        public FText Description;
        public FText HudShortDescription;
        public FSoftObjectPath HudIcon; // UTexture2D
        public int Count;
        public int Stage;
        public int DynamicStatusUpdatePercentInterval;
        public float DynamicUpdateCompletionDelay;
        public FSoftObjectPath ScriptedAction; // UClass
        public FSoftObjectPath FrontendScriptedAction; // UClass

        public FFortMcpQuestObjectiveInfo(FStructFallback fallback)
        {
            BackendName = fallback.GetOrDefault<FName>(nameof(BackendName));
            InlineObjectiveStats = fallback.GetOrDefault<FFortQuestObjectiveStat[]>(nameof(InlineObjectiveStats));
            ObjectiveStatHandle = fallback.GetOrDefault<FDataTableRowHandle>(nameof(ObjectiveStatHandle));
            AlternativeStatHandles = fallback.GetOrDefault<FDataTableRowHandle[]>(nameof(AlternativeStatHandles));
            ItemEvent = fallback.GetOrDefault<EFortQuestObjectiveItemEvent>(nameof(ItemEvent));
            bHidden = fallback.GetOrDefault<bool>(nameof(bHidden));
            bRequirePrimaryMissionCompletion = fallback.GetOrDefault<bool>(nameof(bRequirePrimaryMissionCompletion));
            bCanProgressInZone = fallback.GetOrDefault<bool>(nameof(bCanProgressInZone));
            bDisplayDynamicAnnouncementUpdate = fallback.GetOrDefault<bool>(nameof(bDisplayDynamicAnnouncementUpdate));
            DynamicStatusUpdateType = fallback.GetOrDefault<EObjectiveStatusUpdateType>(nameof(DynamicStatusUpdateType));
            LinkVaultTab = fallback.GetOrDefault<EFortInventoryFilter>(nameof(LinkVaultTab));
            LinkToItemManagement = fallback.GetOrDefault<EFortFrontendInventoryFilter>(nameof(LinkToItemManagement));
            ItemReference = fallback.GetOrDefault<FSoftObjectPath>(nameof(ItemReference));
            ItemTemplateIdOverride = fallback.GetOrDefault<string>(nameof(ItemTemplateIdOverride));
            LinkSquadID = fallback.GetOrDefault<FName>(nameof(LinkSquadID));
            LinkSquadIndex = fallback.GetOrDefault<int>(nameof(LinkSquadIndex));
            Description = fallback.GetOrDefault<FText>(nameof(Description));
            HudShortDescription = fallback.GetOrDefault<FText>(nameof(HudShortDescription));
            HudIcon = fallback.GetOrDefault<FSoftObjectPath>(nameof(HudIcon));
            Count = fallback.GetOrDefault<int>(nameof(Count));
            Stage = fallback.GetOrDefault<int>(nameof(Stage));
            DynamicStatusUpdatePercentInterval = fallback.GetOrDefault<int>(nameof(DynamicStatusUpdatePercentInterval));
            DynamicUpdateCompletionDelay = fallback.GetOrDefault<float>(nameof(DynamicUpdateCompletionDelay));
            ScriptedAction = fallback.GetOrDefault<FSoftObjectPath>(nameof(ScriptedAction));
            FrontendScriptedAction = fallback.GetOrDefault<FSoftObjectPath>(nameof(FrontendScriptedAction));
        }
    }
}
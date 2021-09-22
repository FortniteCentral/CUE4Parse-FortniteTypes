using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaGadgetItemDefinition : UFortGadgetItemDefinition
    {
        public bool bCanBeDroppedWhenEquipmentChangeIsBlocked;
        public bool bAllowedFuelGadgetUI;
        public bool bShowCooldownUI;
        public bool bShowShortDescriptionInPickupDisplay;
        public bool bDisplayPlayerNameForInventoryActor;
        public bool bDisplayHealthForInventoryActor;
        public bool bDisplayShieldForInventoryActor;
        public FGameplayTag? SpecialActorInventoryTag;
        public FName InventorySpecialActorUniqueID;
        public FSlateBrush? InventoryMinimapIconBrush;
        public FVector2D InventoryMinimapIconScale;
        public FSlateBrush? InventoryCompassIconBrush;
        public FVector2D InventoryCompassIconScale;
        public FText? InventoryActorDisplayName;
        public FSpecialActorSingleStatData[]? SpecialActorInventoryStatList;
        public UClass? ContextOverrideWidget;
        public FFortCreativeTagsHelper? CreativeTagsHelper;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bCanBeDroppedWhenEquipmentChangeIsBlocked = GetOrDefault<bool>(nameof(bCanBeDroppedWhenEquipmentChangeIsBlocked));
            bAllowedFuelGadgetUI = GetOrDefault<bool>(nameof(bAllowedFuelGadgetUI));
            bShowCooldownUI = GetOrDefault<bool>(nameof(bShowCooldownUI));
            bShowShortDescriptionInPickupDisplay = GetOrDefault<bool>(nameof(bShowShortDescriptionInPickupDisplay));
            bDisplayPlayerNameForInventoryActor = GetOrDefault<bool>(nameof(bDisplayPlayerNameForInventoryActor));
            bDisplayHealthForInventoryActor = GetOrDefault<bool>(nameof(bDisplayHealthForInventoryActor));
            bDisplayShieldForInventoryActor = GetOrDefault<bool>(nameof(bDisplayShieldForInventoryActor));
            SpecialActorInventoryTag = GetOrDefault<FGameplayTag>(nameof(SpecialActorInventoryTag));
            InventorySpecialActorUniqueID = GetOrDefault<FName>(nameof(InventorySpecialActorUniqueID));
            InventoryMinimapIconBrush = GetOrDefault<FSlateBrush>(nameof(InventoryMinimapIconBrush));
            InventoryMinimapIconScale = GetOrDefault<FVector2D>(nameof(InventoryMinimapIconScale));
            InventoryCompassIconBrush = GetOrDefault<FSlateBrush>(nameof(InventoryCompassIconBrush));
            InventoryCompassIconScale = GetOrDefault<FVector2D>(nameof(InventoryCompassIconScale));
            InventoryActorDisplayName = GetOrDefault<FText>(nameof(InventoryActorDisplayName));
            SpecialActorInventoryStatList = GetOrDefault<FSpecialActorSingleStatData[]>(nameof(SpecialActorInventoryStatList));
            ContextOverrideWidget = GetOrDefault<UClass>(nameof(ContextOverrideWidget));
            CreativeTagsHelper = GetOrDefault<FFortCreativeTagsHelper>(nameof(CreativeTagsHelper));
        }
    }
}
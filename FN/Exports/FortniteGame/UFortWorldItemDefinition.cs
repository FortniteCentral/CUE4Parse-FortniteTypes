using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWorldItemDefinition : UFortItemDefinition
    {
        public FGameplayTagContainer RequiredEquipTags;
        public FFortPickupRestrictionLists[]? PickupRestrictionListEntry;
        public EWorldItemDropBehavior DropBehavior;
        public bool bIgnoreRespawningForDroppingAsPickup;
        public bool bCanAutoEquipByClass;
        public bool bPersistInInventoryWhenFinalStackEmpty;
        public bool bSupportsQuickbarFocus;
        public bool bSupportsQuickbarFocusForGamepadOnly;
        public bool bShouldActivateWhenFocused;
        public bool bForceFocusWhenAdded;
        public bool bForceIntoOverflow;
        public bool bForceStayInOverflow;
        public bool bDropCurrentItemOnOverflow;
        public bool bShouldShowItemToast;
        public bool bShowDirectionalArrowWhenFarOff;
        public bool bCanBeDropped;
        public bool bCanBeReplacedByPickup;
        public bool bItemCanBeStolen;
        public bool bCanBeDepositedInStorageVault;
        public bool bItemHasDurability;
        public bool bAllowedToBeLockedInInventory;
        public bool bOverridePickupMeshTransform;
        public bool bAlwaysCountForCollectionQuest;
        public bool bDropOnDeath;
        public bool bDropOnLogout;
        public bool bDropOnDBNO;
        public bool bDoesNotNeedSourceSchematic;
        public bool bUsesGoverningTags;
        public int DropCount;
        public float MiniMapViewableDistance;
        public FSlateBrush? MiniMapIconBrush;
        public FText? OwnerPickupText;
        public FDataTableCategoryHandle? LootLevelData;
        public FTransform PickupMeshTransform;
        public bool bIsPickupASpecialActor;
        public FGameplayTag? SpecialActorPickupTag;
        public FSpecialActorSingleStatData[]? SpecialActorPickupStatList;
        public FName PickupSpecialActorUniqueID;
        public FSlateBrush? PickupMinimapIconBrush;
        public FVector2D PickupMinimapIconScale;
        public FSlateBrush? PickupCompassIconBrush;
        public FVector2D PickupCompassIconScale;
        public FScalableFloat? PickupDespawnTime;
        public FScalableFloat? InStormPickupDespawnTime;
        public FScalableFloat? NetworkCullDistanceOverride;
        public FSoftObjectPath PickupStaticMesh; // UStaticMesh
        public FSoftObjectPath PickupSkeletalMesh; // USkeletalMesh
        public FSoftObjectPath PickupEffectOverride; // UClass
        public FSoftObjectPath PickupSound; // USoundBase
        public FSoftObjectPath PickupByNearbyPawnSound; // USoundBase
        public FSoftObjectPath DropSound; // USoundBase
        public FSoftObjectPath DroppedLoopSound; // USoundBase
        public FSoftObjectPath LandedSound; // USoundBase
        public FDataTableRowHandle? DisassembleRecipe;
        public float DisassembleDurabilityDegradeMinLootPercent;
        public float DisassembleDurabilityDegradeMaxLootPercent;
        public int PreferredQuickbarSlot;
        public int MinLevel;
        public int MaxLevel;
        public int NumberOfSlotsToTake;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            RequiredEquipTags = GetOrDefault<FGameplayTagContainer>(nameof(RequiredEquipTags));
            PickupRestrictionListEntry = GetOrDefault<FFortPickupRestrictionLists[]>(nameof(PickupRestrictionListEntry));
            DropBehavior = GetOrDefault<EWorldItemDropBehavior>(nameof(DropBehavior));
            bIgnoreRespawningForDroppingAsPickup = GetOrDefault<bool>(nameof(bIgnoreRespawningForDroppingAsPickup));
            bCanAutoEquipByClass = GetOrDefault<bool>(nameof(bCanAutoEquipByClass));
            bPersistInInventoryWhenFinalStackEmpty = GetOrDefault<bool>(nameof(bPersistInInventoryWhenFinalStackEmpty));
            bSupportsQuickbarFocus = GetOrDefault<bool>(nameof(bSupportsQuickbarFocus));
            bSupportsQuickbarFocusForGamepadOnly = GetOrDefault<bool>(nameof(bSupportsQuickbarFocusForGamepadOnly));
            bShouldActivateWhenFocused = GetOrDefault<bool>(nameof(bShouldActivateWhenFocused));
            bForceFocusWhenAdded = GetOrDefault<bool>(nameof(bForceFocusWhenAdded));
            bForceIntoOverflow = GetOrDefault<bool>(nameof(bForceIntoOverflow));
            bForceStayInOverflow = GetOrDefault<bool>(nameof(bForceStayInOverflow));
            bDropCurrentItemOnOverflow = GetOrDefault<bool>(nameof(bDropCurrentItemOnOverflow));
            bShouldShowItemToast = GetOrDefault<bool>(nameof(bShouldShowItemToast));
            bShowDirectionalArrowWhenFarOff = GetOrDefault<bool>(nameof(bShowDirectionalArrowWhenFarOff));
            bCanBeDropped = GetOrDefault<bool>(nameof(bCanBeDropped));
            bCanBeReplacedByPickup = GetOrDefault<bool>(nameof(bCanBeReplacedByPickup));
            bItemCanBeStolen = GetOrDefault<bool>(nameof(bItemCanBeStolen));
            bCanBeDepositedInStorageVault = GetOrDefault<bool>(nameof(bCanBeDepositedInStorageVault));
            bItemHasDurability = GetOrDefault<bool>(nameof(bItemHasDurability));
            bAllowedToBeLockedInInventory = GetOrDefault<bool>(nameof(bAllowedToBeLockedInInventory));
            bOverridePickupMeshTransform = GetOrDefault<bool>(nameof(bOverridePickupMeshTransform));
            bAlwaysCountForCollectionQuest = GetOrDefault<bool>(nameof(bAlwaysCountForCollectionQuest));
            bDropOnDeath = GetOrDefault<bool>(nameof(bDropOnDeath));
            bDropOnLogout = GetOrDefault<bool>(nameof(bDropOnLogout));
            bDropOnDBNO = GetOrDefault<bool>(nameof(bDropOnDBNO));
            bDoesNotNeedSourceSchematic = GetOrDefault<bool>(nameof(bDoesNotNeedSourceSchematic));
            bUsesGoverningTags = GetOrDefault<bool>(nameof(bUsesGoverningTags));
            DropCount = GetOrDefault<int>(nameof(DropCount));
            MiniMapViewableDistance = GetOrDefault<float>(nameof(MiniMapViewableDistance));
            MiniMapIconBrush = GetOrDefault<FSlateBrush>(nameof(MiniMapIconBrush));
            OwnerPickupText = GetOrDefault<FText>(nameof(OwnerPickupText));
            LootLevelData = GetOrDefault<FDataTableCategoryHandle>(nameof(LootLevelData));
            PickupMeshTransform = GetOrDefault<FTransform>(nameof(PickupMeshTransform));
            bIsPickupASpecialActor = GetOrDefault<bool>(nameof(bIsPickupASpecialActor));
            SpecialActorPickupTag = GetOrDefault<FGameplayTag>(nameof(SpecialActorPickupTag));
            SpecialActorPickupStatList = GetOrDefault<FSpecialActorSingleStatData[]>(nameof(SpecialActorPickupStatList));
            PickupSpecialActorUniqueID = GetOrDefault<FName>(nameof(PickupSpecialActorUniqueID));
            PickupMinimapIconBrush = GetOrDefault<FSlateBrush>(nameof(PickupMinimapIconBrush));
            PickupMinimapIconScale = GetOrDefault<FVector2D>(nameof(PickupMinimapIconScale));
            PickupCompassIconBrush = GetOrDefault<FSlateBrush>(nameof(PickupCompassIconBrush));
            PickupCompassIconScale = GetOrDefault<FVector2D>(nameof(PickupCompassIconScale));
            PickupDespawnTime = GetOrDefault<FScalableFloat>(nameof(PickupDespawnTime));
            InStormPickupDespawnTime = GetOrDefault<FScalableFloat>(nameof(InStormPickupDespawnTime));
            NetworkCullDistanceOverride = GetOrDefault<FScalableFloat>(nameof(NetworkCullDistanceOverride));
            PickupStaticMesh = GetOrDefault<FSoftObjectPath>(nameof(PickupStaticMesh));
            PickupSkeletalMesh = GetOrDefault<FSoftObjectPath>(nameof(PickupSkeletalMesh));
            PickupEffectOverride = GetOrDefault<FSoftObjectPath>(nameof(PickupEffectOverride));
            PickupSound = GetOrDefault<FSoftObjectPath>(nameof(PickupSound));
            PickupByNearbyPawnSound = GetOrDefault<FSoftObjectPath>(nameof(PickupByNearbyPawnSound));
            DropSound = GetOrDefault<FSoftObjectPath>(nameof(DropSound));
            DroppedLoopSound = GetOrDefault<FSoftObjectPath>(nameof(DroppedLoopSound));
            LandedSound = GetOrDefault<FSoftObjectPath>(nameof(LandedSound));
            DisassembleRecipe = GetOrDefault<FDataTableRowHandle>(nameof(DisassembleRecipe));
            DisassembleDurabilityDegradeMinLootPercent = GetOrDefault<float>(nameof(DisassembleDurabilityDegradeMinLootPercent));
            DisassembleDurabilityDegradeMaxLootPercent = GetOrDefault<float>(nameof(DisassembleDurabilityDegradeMaxLootPercent));
            PreferredQuickbarSlot = GetOrDefault<int>(nameof(PreferredQuickbarSlot));
            MinLevel = GetOrDefault<int>(nameof(MinLevel));
            MaxLevel = GetOrDefault<int>(nameof(MaxLevel));
            NumberOfSlotsToTake = GetOrDefault<int>(nameof(NumberOfSlotsToTake));
        }
    }
}
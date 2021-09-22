using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWeaponItemDefinition : UFortWorldItemDefinition
    {
        public FSoftObjectPath WeaponActorClass; // UClass
        public FSoftObjectPath WeaponMeshOverride; // USkeletalMesh
        public FSoftObjectPath IntrinsicOverrideWrap; // UAthenaItemWrapDefinition
        public FDataTableRowHandle? WeaponStatHandle;
        public bool bRechargeAmmoToClip;
        public FScalableFloat? WeaponRechargeAmmoRate;
        public FScalableFloat? WeaponRechargeAmmoQuantity;
        public FSoftObjectPath AbilitySet; // UFortAbilitySet
        public FName AlterationSlotsLoadoutRow;
        public FName BaselineAlterationSlotsLoadoutRow;
        public FSoftObjectPath BaseAlteration; // UFortAlterationItemDefinition
        public FSoftObjectPath BaseCosmeticAlteration; // UFortAlterationItemDefinition
        public FFortWeaponModSlot[]? WeaponModSlots;
        public FSoftObjectPath PrimaryFireAbility; // UClass
        public FSoftObjectPath SecondaryFireAbility; // UClass
        public FSoftObjectPath ReloadAbility; // UClass
        public FSoftObjectPath OnHitAbility; // UClass
        public FSoftObjectPath[]? EquippedAbilities; // UClass[]
        public FSoftObjectPath EquippedAbilitySet; // UFortAbilitySet
        public UCustomCharacterPart[]? EquippedCharacterParts;
        public FSoftObjectPath AmmoData; // UFortWorldItemDefinition
        public UFortWeaponAdditionalData[]? AdditionalDataFields;
        public float LowAmmoPercentage;
        public EFortWeaponTriggerType TriggerType;
        public EFortWeaponTriggerType SecondaryTriggerType;
        public EFortDisplayTier DisplayTier;
        public bool bUsesPhantomReserveAmmo;
        public bool bUsesCustomAmmoType;
        public bool bAllowSecondaryFireToInterruptPrimary;
        public bool bAllowTargetingDuringReload;
        public bool bTargetingPreventsReload;
        public bool bCanFireWhileInstigatorTethered;
        public bool bCanFireWhileNotTargetedInVehicle;
        public bool bAlwaysChargeUpToMin;
        public bool bNoFireOnReleaseBeforeMinChargeTime;
        public bool bEndAbilityOnChargeEnd;
        public bool bUpdateLastFireTimeOnDischarge;
        public bool bReticleCornerOutsideSpreadRadius;
        public bool bValidForLastEquipped;
        public bool bPreventDefaultPreload;
        public bool bRequestClientPreload;
        public float HitNotifyDuration;
        public FSoftObjectPath ReticleImage; // UTexture2D
        public float[]? ReticleCornerAngles;
        public FSoftObjectPath ReticleCenterImage; // UTexture2D
        public FSoftObjectPath ReticleCenterPerfectAimImage; // UTexture2D
        public FVector2D ReticleCenterImageOffset;
        public FSoftObjectPath ReticleInvalidTargetImage; // UTexture2D
        public FGameplayTagContainer AnalyticTags;
        public FGameplayTagContainer PlayerGrantedGameplayTags;
        public FName[]? ActualAnalyticFNames;
        public FSoftObjectPath RequiredWeaponParent; // UAthenaCosmeticItemDefinition
        public FFortCreativeTagsHelper? CreativeTagsHelper;
        public UFortWeaponAdditionalData AdditionalData;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);
        }
    }
}
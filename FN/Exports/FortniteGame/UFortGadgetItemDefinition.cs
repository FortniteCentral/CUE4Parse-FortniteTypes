using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortGadgetItemDefinition : UFortWorldItemDefinition
    {
        public int GadgetPriority;
        public bool bDestroyGadgetWhenTrackedAttributesIsZero;
        public bool bHasChargeUp;
        public bool bDropAllOnEquip;
        public bool bCanChangePreviewImageDuringGame;
        public UCustomCharacterPart[]? CharacterParts;
        public FGameplayTagContainer SkinMetaTagsToSkip;
        public FGameplayTag? PartSwapTag;
        public FCharacterPartsExtraSpecial[]? CharacterPartsExtraSpecial;
        public FSoftObjectPath AnimBPOverride; // UClass
        public FSoftObjectPath FootstepBankOverride; // UFortFootstepAudioBank
        public FSoftObjectPath AbilitySet; // UFortAbilitySet
        public FSoftObjectPath AttributeSet; // UClass
        public FFortAttributeInitializationKey? AttributeInitKey;
        public FGameplayAttribute[]? TrackedAttributes;
        public FSoftObjectPath OnDestroyParticleSystem; // UParticleSystem
        public FSoftObjectPath OnDestroySound; // USoundBase
        public FName OnDestroyAttachToSocketName;
        public FSoftObjectPath GameplayAbility; // UClass
        public FGameplayTagContainer HUDVisibilityTags;
        public FSoftObjectPath WeaponItemDefinition; // UFortWeaponItemDefinition
        public FSoftObjectPath[]? AdditionalItemsToLoadWhenEquipped; // UFortItemDefinition[]
        public bool bValidForLastEquipped;
        public FGameplayAttribute? LevelAttribute;
        public FDataTableRowHandle? DamageStatHandle;
        public string? NodeId;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            GadgetPriority = GetOrDefault<int>(nameof(GadgetPriority));
            bDestroyGadgetWhenTrackedAttributesIsZero = GetOrDefault<bool>(nameof(bDestroyGadgetWhenTrackedAttributesIsZero));
            bHasChargeUp = GetOrDefault<bool>(nameof(bHasChargeUp));
            bDropAllOnEquip = GetOrDefault<bool>(nameof(bDropAllOnEquip));
            bCanChangePreviewImageDuringGame = GetOrDefault<bool>(nameof(bCanChangePreviewImageDuringGame));
            CharacterParts = GetOrDefault<UCustomCharacterPart[]>(nameof(CharacterParts));
            SkinMetaTagsToSkip = GetOrDefault<FGameplayTagContainer>(nameof(SkinMetaTagsToSkip));
            PartSwapTag = GetOrDefault<FGameplayTag>(nameof(PartSwapTag));
            CharacterPartsExtraSpecial = GetOrDefault<FCharacterPartsExtraSpecial[]>(nameof(CharacterPartsExtraSpecial));
            AnimBPOverride = GetOrDefault<FSoftObjectPath>(nameof(AnimBPOverride));
            FootstepBankOverride = GetOrDefault<FSoftObjectPath>(nameof(FootstepBankOverride));
            AbilitySet = GetOrDefault<FSoftObjectPath>(nameof(AbilitySet));
            AttributeSet = GetOrDefault<FSoftObjectPath>(nameof(AttributeSet));
            AttributeInitKey = GetOrDefault<FFortAttributeInitializationKey>(nameof(AttributeInitKey));
            TrackedAttributes = GetOrDefault<FGameplayAttribute[]>(nameof(TrackedAttributes));
            OnDestroyParticleSystem = GetOrDefault<FSoftObjectPath>(nameof(OnDestroyParticleSystem));
            OnDestroySound = GetOrDefault<FSoftObjectPath>(nameof(OnDestroySound));
            OnDestroyAttachToSocketName = GetOrDefault<FName>(nameof(OnDestroyAttachToSocketName));
            GameplayAbility = GetOrDefault<FSoftObjectPath>(nameof(GameplayAbility));
            HUDVisibilityTags = GetOrDefault<FGameplayTagContainer>(nameof(HUDVisibilityTags));
            WeaponItemDefinition = GetOrDefault<FSoftObjectPath>(nameof(WeaponItemDefinition));
            AdditionalItemsToLoadWhenEquipped = GetOrDefault<FSoftObjectPath[]>(nameof(AdditionalItemsToLoadWhenEquipped));
            bValidForLastEquipped = GetOrDefault<bool>(nameof(bValidForLastEquipped));
            LevelAttribute = GetOrDefault<FGameplayAttribute>(nameof(LevelAttribute));
            DamageStatHandle = GetOrDefault<FDataTableRowHandle>(nameof(DamageStatHandle));
            NodeId = GetOrDefault<string>(nameof(NodeId));
        }
    }
}
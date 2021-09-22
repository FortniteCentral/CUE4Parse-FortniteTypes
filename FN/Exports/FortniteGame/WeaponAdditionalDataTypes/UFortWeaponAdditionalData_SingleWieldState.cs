using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame.WeaponAdditionalDataTypes
{
    public class UFortWeaponAdditionalData_SingleWieldState : UFortWeaponAdditionalData
    {
        public FGameplayTag? AssociatedTagVariant;
        public FSoftObjectPath PrimaryFireAbility_InState; // UClass
        public FSoftObjectPath AnimSet_InState; // UFortWeaponAnimSet
        public FSoftObjectPath EquipMontage_InState; // UAnimMontage
        public bool bHideOffhandMesh;
        public bool bUseWeaponHandSocketOverride;
        public FName WeaponHandSocketOverride;
        public bool bUseSeparatePreviewOffsets;
        public FVector ImpactFxPreviewOffset;
        public FVector OffHandPreviewOffset;
        public FRotator OffHandPreviewRotation;
        public FRotator InitialPreviewRotation;
        public float FrontendPreviewScale;
        public FFortUICameraFrameTargetBounds? CameraFramingBounds;
        public EFortWeaponCoreAnimation AnimationStyleToUse;
        public UClass? LiveAbility;
        public UObject? LiveAnimSet; // UFortWeaponAnimSet
        public UObject? LiveMontage; // UAnimMontage

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            AssociatedTagVariant = GetOrDefault<FGameplayTag>(nameof(AssociatedTagVariant));
            PrimaryFireAbility_InState = GetOrDefault<FSoftObjectPath>(nameof(PrimaryFireAbility_InState));
            AnimSet_InState = GetOrDefault<FSoftObjectPath>(nameof(AnimSet_InState));
            EquipMontage_InState = GetOrDefault<FSoftObjectPath>(nameof(EquipMontage_InState));
            bHideOffhandMesh = GetOrDefault<bool>(nameof(bHideOffhandMesh));
            bUseWeaponHandSocketOverride = GetOrDefault<bool>(nameof(bUseWeaponHandSocketOverride));
            WeaponHandSocketOverride = GetOrDefault<FName>(nameof(WeaponHandSocketOverride));
            bUseSeparatePreviewOffsets = GetOrDefault<bool>(nameof(bUseSeparatePreviewOffsets));
            ImpactFxPreviewOffset = GetOrDefault<FVector>(nameof(ImpactFxPreviewOffset));
            OffHandPreviewOffset = GetOrDefault<FVector>(nameof(OffHandPreviewOffset));
            OffHandPreviewRotation = GetOrDefault<FRotator>(nameof(OffHandPreviewRotation));
            InitialPreviewRotation = GetOrDefault<FRotator>(nameof(InitialPreviewRotation));
            FrontendPreviewScale = GetOrDefault<float>(nameof(FrontendPreviewScale));
            CameraFramingBounds = GetOrDefault<FFortUICameraFrameTargetBounds>(nameof(CameraFramingBounds));
            AnimationStyleToUse = GetOrDefault<EFortWeaponCoreAnimation>(nameof(AnimationStyleToUse));
            LiveAbility = GetOrDefault<UClass>(nameof(LiveAbility));
            LiveAnimSet = GetOrDefault<UObject>(nameof(LiveAnimSet));
            LiveMontage = GetOrDefault<UObject>(nameof(LiveMontage));
        }
    }
}
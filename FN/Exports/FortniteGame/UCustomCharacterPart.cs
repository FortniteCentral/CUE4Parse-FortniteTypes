using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UCustomCharacterPart : UObject
    {
        public EFortCustomGender GenderPermitted;
        public EFortCustomBodyType BodyTypesPermitted;
        public EFortCustomPartType CharacterPartType;
        public FGameplayTagContainer BoneSetsToHide;
        public bool bShouldHideBonesForThisPart;
        public FGameplayTagContainer GameplayTags;
        public FGameplayTagContainer DisallowedCosmeticTags;
        public bool bGameplayRelevantCosmeticPart;
        public bool bAttachToSocket;
        public bool bIgnorePart;
        public FSoftObjectPath PartModifierBlueprint; // UClass
        public UCustomCharacterPartData? AdditionalData; // TODO: Actual types
        public FSoftObjectPath DefaultMontageLookupTable; // UFortMontageLookupTable
        public FSoftObjectPath OverrideMontageLookupTable; // UFortMontageLookupTable
        public FSoftObjectPath FrontendAnimMontageIdleOverride; // UAnimMontage
        public FSoftObjectPath SkydiveAnimSet; // UFortPlayerSkydiveAnimSet
        public float FrontEndBackPreviewRotationOffset;
        public FSoftObjectPath SkeletalMesh; // USkeletalMesh
        public FSoftObjectPath[]? MasterSkeletalMeshes; // USkeletalMesh[]
        public bool bSinglePieceMesh;
        public bool bSupportsColorSwatches;
        public bool bAllowStaticRenderPath;
        public FCustomPartMaterialOverrideData[]? MaterialOverrides;
        public FCustomPartTextureParameter[]? TextureParameters;
        public FCustomPartScalarParameter[]? ScalarParameters;
        public FCustomPartVectorParameter[]? VectorParameters;
        public UClass[]? FoleyLibraries;
        public int MaterialOverrideFlags;
        public int IgnoredMaterialOverrideFlags;
        public FSoftObjectPath IdleEffect; // UParticleSystem
        public FSoftObjectPath IdleEffectNiagara; // UNiagaraSystem
        public FName IdleFXSocketName;
        public bool bUseIdleFXNativeCustomAttachmentParams;
        public FCharacterPartAttachmentParams? IdleFXNativeCustomAttachmentParams;
        public bool bAutoActivate;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            GenderPermitted = GetOrDefault<EFortCustomGender>(nameof(GenderPermitted));
            BodyTypesPermitted = GetOrDefault<EFortCustomBodyType>(nameof(BodyTypesPermitted));
            CharacterPartType = GetOrDefault<EFortCustomPartType>(nameof(CharacterPartType));
            BoneSetsToHide = GetOrDefault<FGameplayTagContainer>(nameof(BoneSetsToHide));
            bShouldHideBonesForThisPart = GetOrDefault<bool>(nameof(bShouldHideBonesForThisPart));
            GameplayTags = GetOrDefault<FGameplayTagContainer>(nameof(GameplayTags));
            DisallowedCosmeticTags = GetOrDefault<FGameplayTagContainer>(nameof(DisallowedCosmeticTags));
            bGameplayRelevantCosmeticPart = GetOrDefault<bool>(nameof(bGameplayRelevantCosmeticPart));
            bAttachToSocket = GetOrDefault<bool>(nameof(bAttachToSocket));
            bIgnorePart = GetOrDefault<bool>(nameof(bIgnorePart));
            PartModifierBlueprint = GetOrDefault<FSoftObjectPath>(nameof(PartModifierBlueprint));
            AdditionalData = GetOrDefault<UCustomCharacterPartData>(nameof(AdditionalData));
            DefaultMontageLookupTable = GetOrDefault<FSoftObjectPath>(nameof(DefaultMontageLookupTable));
            OverrideMontageLookupTable = GetOrDefault<FSoftObjectPath>(nameof(OverrideMontageLookupTable));
            FrontendAnimMontageIdleOverride = GetOrDefault<FSoftObjectPath>(nameof(FrontendAnimMontageIdleOverride));
            SkydiveAnimSet = GetOrDefault<FSoftObjectPath>(nameof(SkydiveAnimSet));
            FrontEndBackPreviewRotationOffset = GetOrDefault<float>(nameof(FrontEndBackPreviewRotationOffset));
            SkeletalMesh = GetOrDefault<FSoftObjectPath>(nameof(SkeletalMesh));
            MasterSkeletalMeshes = GetOrDefault<FSoftObjectPath[]>(nameof(MasterSkeletalMeshes));
            bSinglePieceMesh = GetOrDefault<bool>(nameof(bSinglePieceMesh));
            bSupportsColorSwatches = GetOrDefault<bool>(nameof(bSupportsColorSwatches));
            bAllowStaticRenderPath = GetOrDefault<bool>(nameof(bAllowStaticRenderPath));
            MaterialOverrides = GetOrDefault<FCustomPartMaterialOverrideData[]>(nameof(MaterialOverrides));
            TextureParameters = GetOrDefault<FCustomPartTextureParameter[]>(nameof(TextureParameters));
            ScalarParameters = GetOrDefault<FCustomPartScalarParameter[]>(nameof(ScalarParameters));
            VectorParameters = GetOrDefault<FCustomPartVectorParameter[]>(nameof(VectorParameters));
            FoleyLibraries = GetOrDefault<UClass[]>(nameof(FoleyLibraries));
            MaterialOverrideFlags = GetOrDefault<int>(nameof(MaterialOverrideFlags));
            IgnoredMaterialOverrideFlags = GetOrDefault<int>(nameof(IgnoredMaterialOverrideFlags));
            IdleEffect = GetOrDefault<FSoftObjectPath>(nameof(IdleEffect));
            IdleEffectNiagara = GetOrDefault<FSoftObjectPath>(nameof(IdleEffectNiagara));
            IdleFXSocketName = GetOrDefault<FName>(nameof(IdleFXSocketName));
            bUseIdleFXNativeCustomAttachmentParams = GetOrDefault<bool>(nameof(bUseIdleFXNativeCustomAttachmentParams));
            IdleFXNativeCustomAttachmentParams = GetOrDefault<FCharacterPartAttachmentParams>(nameof(IdleFXNativeCustomAttachmentParams));
            bAutoActivate = GetOrDefault<bool>(nameof(bAutoActivate));
        }
    }
}
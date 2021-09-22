using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaPickaxeItemDefinition : UAthenaCosmeticItemDefinition
    {
        public UFortWeaponMeleeItemDefinition? WeaponDefinition;
        public FName MainMeshAttachmentSocketName;
        public FName OffhandMeshAttachmentSocketName;
        public FTransform MainMeshRelativeTransform;
        public FTransform OffhandMeshRelativeTransform;
        public FVector PickaxeImpactFXPreviewOffset;
        public FVector PickaxeDualWieldPreviewOffset;
        public FRotator PickaxeDualWieldPreviewRotation;
        public FSoftObjectPath PreviewIdleMontage; // UAnimMontage
        public FSoftObjectPath PreviewSwingMontage; // UAnimMontage
        public FFortUICameraFrameTargetBounds? CameraFramingBounds;
        public FVector CameraFramingBoundsCenterOffset;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            WeaponDefinition = GetOrDefault<UFortWeaponMeleeItemDefinition>(nameof(WeaponDefinition));
            MainMeshAttachmentSocketName = GetOrDefault<FName>(nameof(MainMeshAttachmentSocketName));
            OffhandMeshAttachmentSocketName = GetOrDefault<FName>(nameof(OffhandMeshAttachmentSocketName));
            MainMeshRelativeTransform = GetOrDefault<FTransform>(nameof(MainMeshRelativeTransform));
            OffhandMeshRelativeTransform = GetOrDefault<FTransform>(nameof(OffhandMeshRelativeTransform));
            PickaxeImpactFXPreviewOffset = GetOrDefault<FVector>(nameof(PickaxeImpactFXPreviewOffset));
            PickaxeDualWieldPreviewOffset = GetOrDefault<FVector>(nameof(PickaxeDualWieldPreviewOffset));
            PickaxeDualWieldPreviewRotation = GetOrDefault<FRotator>(nameof(PickaxeDualWieldPreviewRotation));
            PreviewIdleMontage = GetOrDefault<FSoftObjectPath>(nameof(PreviewIdleMontage));
            PreviewSwingMontage = GetOrDefault<FSoftObjectPath>(nameof(PreviewSwingMontage));
            CameraFramingBounds = GetOrDefault<FFortUICameraFrameTargetBounds>(nameof(CameraFramingBounds));
            CameraFramingBoundsCenterOffset = GetOrDefault<FVector>(nameof(CameraFramingBoundsCenterOffset));
        }
    }
}
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Exports.Material;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaEmojiItemDefinition : UAthenaDanceItemDefinition
    {
        public FGameplayTag? EmojiGameplayCueTag;
        public FSoftObjectPath PreviewAnimation; // UAnimMontage
        public FSoftObjectPath SpriteSheet; // UTexture2D
        public FIntPoint SheetDimensions;
        public int FrameIndex;
        public int FrameCount;
        public UMaterialInterface? BaseMaterial;
        public FVector IconSize;
        public FLinearColor InitialColor;
        public FVector InitialLocation;
        public FVector InitialVelocity;
        public float LifetimeIntroSeconds;
        public float LifetimeMidSeconds;
        public float LifetimeOutroSeconds;
        public UMaterialInstance? GeneratedMaterial;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            EmojiGameplayCueTag = GetOrDefault<FGameplayTag>(nameof(EmojiGameplayCueTag));
            PreviewAnimation = GetOrDefault<FSoftObjectPath>(nameof(PreviewAnimation));
            SpriteSheet = GetOrDefault<FSoftObjectPath>(nameof(SpriteSheet));
            SheetDimensions = GetOrDefault<FIntPoint>(nameof(SheetDimensions));
            FrameIndex = GetOrDefault<int>(nameof(FrameIndex));
            FrameCount = GetOrDefault<int>(nameof(FrameCount));
            BaseMaterial = GetOrDefault<UMaterialInterface>(nameof(BaseMaterial));
            IconSize = GetOrDefault<FVector>(nameof(IconSize));
            InitialColor = GetOrDefault<FLinearColor>(nameof(InitialColor));
            InitialLocation = GetOrDefault<FVector>(nameof(InitialLocation));
            InitialVelocity = GetOrDefault<FVector>(nameof(InitialVelocity));
            LifetimeIntroSeconds = GetOrDefault<float>(nameof(LifetimeIntroSeconds));
            LifetimeMidSeconds = GetOrDefault<float>(nameof(LifetimeMidSeconds));
            LifetimeOutroSeconds = GetOrDefault<float>(nameof(LifetimeOutroSeconds));
            GeneratedMaterial = GetOrDefault<UMaterialInstance>(nameof(GeneratedMaterial));
        }
    }
}
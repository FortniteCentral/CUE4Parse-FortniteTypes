using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaSprayItemDefinition : UAthenaDanceItemDefinition
    {
        public FSoftObjectPath DecalMaterial; // UMaterialInterface
        public FName ProgressiveCosmeticStatName;
        public bool bUseBannerAsTexture;
        public FSoftObjectPath DecalTexture; // UTexture2D

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DecalMaterial = GetOrDefault<FSoftObjectPath>(nameof(DecalMaterial));
            ProgressiveCosmeticStatName = GetOrDefault<FName>(nameof(ProgressiveCosmeticStatName));
            bUseBannerAsTexture = GetOrDefault<bool>(nameof(bUseBannerAsTexture));
            DecalTexture = GetOrDefault<FSoftObjectPath>(nameof(DecalTexture));
        }
    }
}
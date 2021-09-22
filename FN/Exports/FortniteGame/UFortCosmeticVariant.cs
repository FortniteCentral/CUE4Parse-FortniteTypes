using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortCosmeticVariant : UObject
    {
        public FSoftObjectPath CustomPreviewTileMaterial; // UMaterialInterface
        public FGameplayTag? VariantChannelTag;
        public FText? VariantChannelName;
        public FGameplayTag? ActiveVariantTag;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            CustomPreviewTileMaterial = GetOrDefault<FSoftObjectPath>(nameof(CustomPreviewTileMaterial));
            VariantChannelTag = GetOrDefault<FGameplayTag>(nameof(VariantChannelTag));
            VariantChannelName = GetOrDefault<FText>(nameof(VariantChannelName));
            ActiveVariantTag = GetOrDefault<FGameplayTag>(nameof(ActiveVariantTag));
        }
    }
}
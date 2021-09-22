using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class URewardGraphToken : UFortTokenType
    {
        public FSoftObjectPath PrimaryCosmeticItem; // UAthenaCosmeticItemDefinition
        public FFortCosmeticVariantPreview[]? ItemVariantPreviews;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            PrimaryCosmeticItem = GetOrDefault<FSoftObjectPath>(nameof(PrimaryCosmeticItem));
            ItemVariantPreviews = GetOrDefault<FFortCosmeticVariantPreview[]>(nameof(ItemVariantPreviews));
        }
    }
}
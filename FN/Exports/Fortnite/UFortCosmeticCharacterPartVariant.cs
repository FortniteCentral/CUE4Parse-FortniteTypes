using CUE4Parse.FN.Exports.Fortnite.NoProperties;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.Fortnite
{
    public class UFortCosmeticCharacterPartVariant : UFortCosmeticVariantBackedByArray
    {
        public FStructFallback[]? PartOptions; // FPartVariantDef[]

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            PartOptions = GetOrDefault<FStructFallback[]>(nameof(PartOptions));
        }
    }
}
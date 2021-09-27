using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeBundleSpecialOffer
    {
        public string Storefront;
        public FText RichText;
        public FSoftObjectPath OfferImage; // UMaterial

        public FFortChallengeBundleSpecialOffer(FStructFallback fallback)
        {
            Storefront = fallback.GetOrDefault<string>(nameof(Storefront));
            RichText = fallback.GetOrDefault<FText>(nameof(RichText));
            OfferImage = fallback.GetOrDefault<FSoftObjectPath>(nameof(OfferImage));
        }
    }
}
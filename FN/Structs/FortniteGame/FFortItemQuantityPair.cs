using CUE4Parse.FN.Structs.CoreUObject;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortItemQuantityPair 
    {
        public FPrimaryAssetId ItemPrimaryAssetId;
        public int Quantity;

        public FFortItemQuantityPair(FStructFallback fallback)
        {
            ItemPrimaryAssetId = fallback.GetOrDefault<FPrimaryAssetId>(nameof(ItemPrimaryAssetId));
            Quantity = fallback.GetOrDefault<int>(nameof(Quantity));
        }
    }
}
using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortCosmeticVariantPreviewElement 
    {
        public FMcpVariantChannelInfo[] VariantOptions;
        public UAthenaCosmeticItemDefinition Item;

        public FFortCosmeticVariantPreviewElement(FStructFallback fallback)
        {
            VariantOptions = fallback.GetOrDefault<FMcpVariantChannelInfo[]>(nameof(VariantOptions));
            Item = fallback.GetOrDefault<UAthenaCosmeticItemDefinition>(nameof(Item));
        }
    }
}
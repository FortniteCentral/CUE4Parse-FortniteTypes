using CUE4Parse.FN.Exports.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FFortCosmeticVariantPreviewElement : IUStruct
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
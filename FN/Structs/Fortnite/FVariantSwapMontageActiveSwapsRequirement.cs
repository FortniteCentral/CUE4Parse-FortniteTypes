using CUE4Parse.FN.Exports.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FVariantSwapMontageActiveSwapsRequirement : IUStruct
    {
        public FMcpVariantChannelInfo[] VariantSelections;
        public UFortItemDefinition Item;

        public FVariantSwapMontageActiveSwapsRequirement(FStructFallback fallback)
        {
            VariantSelections = fallback.GetOrDefault<FMcpVariantChannelInfo[]>(nameof(VariantSelections));
            Item = fallback.GetOrDefault<UFortItemDefinition>(nameof(Item));
        }
    }
}
using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FVariantSwapMontageActiveSwapsRequirement 
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
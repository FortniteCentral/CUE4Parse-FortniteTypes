using CUE4Parse.FN.Enums.Fortnite;
using CUE4Parse.FN.Exports.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FMontageVisibilityData : IUStruct
    {
        public EMontageVisibilityRule Rule;
        public UFortItemDefinition Item;

        public FMontageVisibilityData(FStructFallback fallback)
        {
            Rule = fallback.GetOrDefault<EMontageVisibilityRule>(nameof(Rule));
            Item = fallback.GetOrDefault<UFortItemDefinition>(nameof(Item));
        }
    }
}
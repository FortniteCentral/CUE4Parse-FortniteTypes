using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FMontageVisibilityData 
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
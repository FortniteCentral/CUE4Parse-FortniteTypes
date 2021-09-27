using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCharacterPartsExtraSpecial 
    {
        public UCustomCharacterPart[] CharacterPartsForExtraSpecial;
        public FGameplayTagContainer SkinMetaTagsForExtraSpecial;

        public FCharacterPartsExtraSpecial(FStructFallback fallback)
        {
            CharacterPartsForExtraSpecial = fallback.GetOrDefault<UCustomCharacterPart[]>(nameof(CharacterPartsForExtraSpecial));
            SkinMetaTagsForExtraSpecial = fallback.GetOrDefault<FGameplayTagContainer>(nameof(SkinMetaTagsForExtraSpecial));
        }
    }
}
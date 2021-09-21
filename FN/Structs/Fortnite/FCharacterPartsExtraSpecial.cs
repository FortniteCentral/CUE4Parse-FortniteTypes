using CUE4Parse.FN.Exports.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FCharacterPartsExtraSpecial : IUStruct
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
using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FVariantSwapMontagePartRequirement 
    {
        public EFortCustomPartType PartType;
        public FSoftObjectPath Part; // UCustomCharacterPart

        public FVariantSwapMontagePartRequirement(FStructFallback fallback)
        {
            PartType = fallback.GetOrDefault<EFortCustomPartType>(nameof(PartType));
            Part = fallback.GetOrDefault<FSoftObjectPath>(nameof(Part));
        }
    }
}
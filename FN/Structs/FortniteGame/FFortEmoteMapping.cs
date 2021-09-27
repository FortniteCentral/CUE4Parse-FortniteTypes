using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortEmoteMapping 
    {
        public EFortCustomBodyType BodyType;
        public EFortCustomGender Gender;
        public FSoftObjectPath EmoteMontage; // UAnimMontage

        public FFortEmoteMapping(FStructFallback fallback)
        {
            BodyType = fallback.GetOrDefault<EFortCustomBodyType>(nameof(BodyType));
            Gender = fallback.GetOrDefault<EFortCustomGender>(nameof(Gender));
            EmoteMontage = fallback.GetOrDefault<FSoftObjectPath>(nameof(EmoteMontage));
        }
    }
}
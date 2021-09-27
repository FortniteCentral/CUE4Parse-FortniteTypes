using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortChallengeSetStyle
    {
        public FLinearColor PrimaryColor;
        public FLinearColor SecondaryColor;
        public FLinearColor AccentColor;
        public FLinearColor Context_LimitedTimeColor;
        public FLinearColor Context_BaseColor;
        public FSoftObjectPath DisplayImage; // UObject
        public FSoftObjectPath CustomBackground; // UObject

        public FFortChallengeSetStyle(FStructFallback fallback)
        {
            PrimaryColor = fallback.GetOrDefault<FLinearColor>(nameof(PrimaryColor));
            SecondaryColor = fallback.GetOrDefault<FLinearColor>(nameof(SecondaryColor));
            AccentColor = fallback.GetOrDefault<FLinearColor>(nameof(AccentColor));
            Context_LimitedTimeColor = fallback.GetOrDefault<FLinearColor>(nameof(Context_LimitedTimeColor));
            Context_BaseColor = fallback.GetOrDefault<FLinearColor>(nameof(Context_BaseColor));
            DisplayImage = fallback.GetOrDefault<FSoftObjectPath>(nameof(DisplayImage));
            CustomBackground = fallback.GetOrDefault<FSoftObjectPath>(nameof(CustomBackground));
        }
    }
}
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaLoadingScreenItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath BackgroundImage; // UTexture2D
        public FSoftObjectPath BackgroundMaterialOrTexture; // UObject
        public FSoftObjectPath BackgroundWidget; // UClass
        public FVector2D BackgroundDesiredSize;
        public FLinearColor BackgroundColor;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            BackgroundImage = GetOrDefault<FSoftObjectPath>(nameof(BackgroundImage));
            BackgroundMaterialOrTexture = GetOrDefault<FSoftObjectPath>(nameof(BackgroundMaterialOrTexture));
            BackgroundWidget = GetOrDefault<FSoftObjectPath>(nameof(BackgroundWidget));
            BackgroundDesiredSize = GetOrDefault<FVector2D>(nameof(BackgroundDesiredSize));
            BackgroundColor = GetOrDefault<FLinearColor>(nameof(BackgroundColor));
        }
    }
}
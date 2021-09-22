using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortItemSeriesDefinition : UObject
    {
        public FText? DisplayName;
        public FFortColorPalette? Colors;
        public FSoftObjectPath BackgroundTexture;
        public FSoftObjectPath ItemCardMaterial;
        public FSoftObjectPath BackgroundMaterial;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DisplayName = GetOrDefault<FText>(nameof(DisplayName));
            Colors = GetOrDefault<FFortColorPalette>(nameof(Colors));
            BackgroundTexture = GetOrDefault<FSoftObjectPath>(nameof(BackgroundTexture));
            ItemCardMaterial = GetOrDefault<FSoftObjectPath>(nameof(ItemCardMaterial));
            BackgroundMaterial = GetOrDefault<FSoftObjectPath>(nameof(BackgroundMaterial));
        }
    }
}
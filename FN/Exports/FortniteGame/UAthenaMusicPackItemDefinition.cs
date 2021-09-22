using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaMusicPackItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath FrontEndLobbyMusic; // USoundBase
        public FSoftObjectPath CoverArtImage; // UTexture2D
        public bool bIsDefaultMusicPack;
        public float MusicPreviewStartTime;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            FrontEndLobbyMusic = GetOrDefault<FSoftObjectPath>(nameof(FrontEndLobbyMusic));
            CoverArtImage = GetOrDefault<FSoftObjectPath>(nameof(CoverArtImage));
            bIsDefaultMusicPack = GetOrDefault<bool>(nameof(bIsDefaultMusicPack));
            MusicPreviewStartTime = GetOrDefault<float>(nameof(MusicPreviewStartTime));
        }
    }
}
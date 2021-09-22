using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaPetCarrierItemDefinition : UAthenaBackpackItemDefinition
    {
        public UAthenaPetItemDefinition? DefaultPet;
        public FFortUICameraFrameTargetBounds? CameraFramingBounds;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DefaultPet = GetOrDefault<UAthenaPetItemDefinition>(nameof(DefaultPet));
            CameraFramingBounds = GetOrDefault<FFortUICameraFrameTargetBounds>(nameof(CameraFramingBounds));
        }
    }
}
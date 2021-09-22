using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.UE4.Assets.Exports.Texture;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame.WeaponAdditionalDataTypes
{
    public class UFortWeaponAdditionalData_AudioVisualizerData : UFortWeaponAdditionalData
    {
        public UTexture? AudioVisualizerIconOverride;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            AudioVisualizerIconOverride = GetOrDefault<UTexture>(nameof(AudioVisualizerIconOverride));
        }
    }
}
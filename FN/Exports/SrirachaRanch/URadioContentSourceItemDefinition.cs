using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.SrirachaRanch
{
    public class URadioContentSourceItemDefinition : UFortAccountItemDefinition
    {
        public string? ResourceID;
        public UObject? MediaSource; // UFortStreamMediaSource

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ResourceID = GetOrDefault<string>(nameof(ResourceID));
            MediaSource = GetOrDefault<UObject>(nameof(MediaSource));
        }
    }
}
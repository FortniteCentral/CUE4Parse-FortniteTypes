using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UPlaylistUserOptions : UObject
    {
        public bool bSupportNoOverride;
        public UObject[]? Options; // UPlaylistUserOptionBase[]
        public UClass[]? OptionFilters;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bSupportNoOverride = GetOrDefault<bool>(nameof(bSupportNoOverride));
            Options = GetOrDefault<UObject[]>(nameof(Options));
            OptionFilters = GetOrDefault<UClass[]>(nameof(OptionFilters));
        }
    }
}
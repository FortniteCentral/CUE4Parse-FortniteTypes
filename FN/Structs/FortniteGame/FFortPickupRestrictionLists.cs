using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortPickupRestrictionLists 
    {
        public FFortPickupTagTestContainer WhiteList;
        public FFortPickupTagTestContainer Blacklist;

        public FFortPickupRestrictionLists(FStructFallback fallback)
        {
            WhiteList = fallback.GetOrDefault<FFortPickupTagTestContainer>(nameof(WhiteList));
            Blacklist = fallback.GetOrDefault<FFortPickupTagTestContainer>(nameof(Blacklist));
        }
    }
}
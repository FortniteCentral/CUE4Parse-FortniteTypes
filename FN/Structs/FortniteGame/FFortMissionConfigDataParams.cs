using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortMissionConfigDataParams
    {
        public FFortMissionConfigDataBucket[] ConfigParams;

        public FFortMissionConfigDataParams(FStructFallback fallback)
        {
            ConfigParams = fallback.GetOrDefault<FFortMissionConfigDataBucket[]>(nameof(ConfigParams));
        }
    }
}
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortAwardItemDefinition : UFortAccountItemDefinition
    {
        public bool bSingleSharedDetector;
        public bool bCanEarnMultipleTimes;
        public UClass? DetectorClass;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bSingleSharedDetector = GetOrDefault<bool>(nameof(bSingleSharedDetector));
            bCanEarnMultipleTimes = GetOrDefault<bool>(nameof(bCanEarnMultipleTimes));
            DetectorClass = GetOrDefault<UClass>(nameof(DetectorClass));
        }
    }
}
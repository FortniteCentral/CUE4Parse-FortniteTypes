using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.CoreUObject
{
    [StructFallback]
    public class FPrimaryAssetId 
    {
        public FPrimaryAssetType PrimaryAssetType;
        public FName PrimaryAssetName;

        public FPrimaryAssetId(FStructFallback fallback)
        {
            PrimaryAssetType = fallback.GetOrDefault<FPrimaryAssetType>(nameof(PrimaryAssetType));
            PrimaryAssetName = fallback.GetOrDefault<FName>(nameof(PrimaryAssetName));
        }
    }

    [StructFallback]
    public class FPrimaryAssetType 
    {
        public FName Name;

        public FPrimaryAssetType(FStructFallback fallback)
        {
            Name = fallback.GetOrDefault<FName>(nameof(Name));
        }
    }
}
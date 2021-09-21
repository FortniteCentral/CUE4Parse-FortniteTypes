using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FFortCreativeTagsHelper : IUStruct
    {
        public FName[] CreativeTags;

        public FFortCreativeTagsHelper(FStructFallback fallback)
        {
            CreativeTags = fallback.GetOrDefault<FName[]>(nameof(CreativeTags));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortAttributeInitializationKey 
    {
        public FName AttributeInitCategory;
        public FName AttributeInitSubCategory;

        public FFortAttributeInitializationKey(FStructFallback fallback)
        {
            AttributeInitCategory = fallback.GetOrDefault<FName>(nameof(AttributeInitCategory));
            AttributeInitSubCategory = fallback.GetOrDefault<FName>(nameof(AttributeInitSubCategory));
        }
    }
}
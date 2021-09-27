using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.GA
{
    [StructFallback]
    public class FGameplayAttribute 
    {
        public string AttributeName;
        public FFieldPath Attribute;
        public UStruct AttributeOwner;

        public FGameplayAttribute(FStructFallback fallback)
        {
            AttributeName = fallback.GetOrDefault<string>(nameof(AttributeName));
            Attribute = fallback.GetOrDefault<FFieldPath>(nameof(Attribute));
            AttributeOwner = fallback.GetOrDefault<UStruct>(nameof(AttributeOwner));
        }
    }
}
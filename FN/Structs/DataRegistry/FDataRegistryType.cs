using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.DataRegistry
{
    [StructFallback]
    public class FDataRegistryType 
    {
        public FName Name;

        public FDataRegistryType(FStructFallback fallback)
        {
            Name = fallback.GetOrDefault<FName>(nameof(Name));
        }
    }
}
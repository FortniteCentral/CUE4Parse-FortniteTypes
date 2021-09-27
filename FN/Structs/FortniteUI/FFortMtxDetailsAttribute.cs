using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Structs.FortniteUI
{
    [StructFallback]
    public class FFortMtxDetailsAttribute 
    {
        public FText Name;
        public FText Value;
        
        public FFortMtxDetailsAttribute(FStructFallback fallback)
        {
            Name = fallback.GetOrDefault<FText>(nameof(Name));
            Value = fallback.GetOrDefault<FText>(nameof(Value));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Exports.Engine;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Engine
{
    [StructFallback]
    public class FCurveTableRowHandle 
    {
        public UCurveTable CurveTable;
        public FName RowName;

        public FCurveTableRowHandle(FStructFallback fallback)
        {
            CurveTable = fallback.GetOrDefault<UCurveTable>(nameof(CurveTable));
            RowName = fallback.GetOrDefault<FName>(nameof(RowName));
        }
    }
}
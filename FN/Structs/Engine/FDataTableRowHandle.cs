using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Exports.Engine;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Engine
{
    [StructFallback]
    public class FDataTableRowHandle 
    {
        public UDataTable DataTable;
        public FName RowName;

        public FDataTableRowHandle(FStructFallback fallback)
        {
            DataTable = fallback.GetOrDefault<UDataTable>(nameof(DataTable));
            RowName = fallback.GetOrDefault<FName>(nameof(RowName));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Exports.Engine;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Engine
{
    [StructFallback]
    public class FDataTableCategoryHandle 
    {
        public UDataTable DataTable;
        public FName ColumnName;
        public FName RowContents;

        public FDataTableCategoryHandle(FStructFallback fallback)
        {
            DataTable = fallback.GetOrDefault<UDataTable>(nameof(DataTable));
            ColumnName = fallback.GetOrDefault<FName>(nameof(ColumnName));
            RowContents = fallback.GetOrDefault<FName>(nameof(RowContents));
        }
    }
}
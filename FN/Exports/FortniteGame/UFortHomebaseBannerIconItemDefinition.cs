using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortHomebaseBannerIconItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FDataTableRowHandle? Category;
        public bool bFullUsageRights;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            Category = GetOrDefault<FDataTableRowHandle>(nameof(Category));
            bFullUsageRights = GetOrDefault<bool>(nameof(bFullUsageRights));
        }
    }
}
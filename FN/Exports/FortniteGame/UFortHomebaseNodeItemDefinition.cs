using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortHomebaseNodeItemDefinition : UFortAccountItemDefinition
    {
        public FHomebaseNodeLevel[]? LevelData;
        public EHomebaseNodeType DisplayType;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            LevelData = GetOrDefault<FHomebaseNodeLevel[]>(nameof(LevelData));
            DisplayType = GetOrDefault<EHomebaseNodeType>(nameof(DisplayType));
        }
    }
}
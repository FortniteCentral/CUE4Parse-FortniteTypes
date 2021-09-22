using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortAccountItemDefinition : UFortItemDefinition // UFortPersistableItemDefinition
    {
        public FCurveTableRowHandle? LevelToXpHandle;
        public FCurveTableRowHandle? LevelToSacrificeXpHandle;
        public FDataTableRowHandle? SacrificeRecipe;
        public FDataTableRowHandle? TransmogSacrificeRow;
        public FDataTableRowHandle[]? ConversionRecipes;
        public FDataTableRowHandle? UpgradeRarityRecipeHandle;
        public int MinLevel;
        public int MaxLevel;
        public string? GrantToProfileType;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            LevelToXpHandle = GetOrDefault<FCurveTableRowHandle>(nameof(LevelToXpHandle));
            LevelToSacrificeXpHandle = GetOrDefault<FCurveTableRowHandle>(nameof(LevelToSacrificeXpHandle));
            SacrificeRecipe = GetOrDefault<FDataTableRowHandle>(nameof(SacrificeRecipe));
            TransmogSacrificeRow = GetOrDefault<FDataTableRowHandle>(nameof(TransmogSacrificeRow));
            ConversionRecipes = GetOrDefault<FDataTableRowHandle[]>(nameof(ConversionRecipes));
            UpgradeRarityRecipeHandle = GetOrDefault<FDataTableRowHandle>(nameof(UpgradeRarityRecipeHandle));
            MinLevel = GetOrDefault<int>(nameof(MinLevel));
            MaxLevel = GetOrDefault<int>(nameof(MaxLevel));
            GrantToProfileType = GetOrDefault<string>(nameof(GrantToProfileType));
        }
    }
}
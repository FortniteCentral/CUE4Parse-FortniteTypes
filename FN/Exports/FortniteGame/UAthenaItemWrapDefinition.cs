using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaItemWrapDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath ItemWrapModifierBlueprint; // UClass
        public FSoftObjectPath ItemWrapMaterial; // UMaterialInterface

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ItemWrapModifierBlueprint = GetOrDefault<FSoftObjectPath>(nameof(ItemWrapModifierBlueprint));
            ItemWrapMaterial = GetOrDefault<FSoftObjectPath>(nameof(ItemWrapMaterial));
        }
    }
}
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWeaponModItemDefinition : UFortWorldItemDefinition
    {
        public FFortConditionalIncludeTags[]? AdditionalGameplayTags;
        public FSoftObjectPath AbilitySet; // UFortAbilitySet

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            AdditionalGameplayTags = GetOrDefault<FFortConditionalIncludeTags[]>(nameof(AdditionalGameplayTags));
            AbilitySet = GetOrDefault<FSoftObjectPath>(nameof(AbilitySet));
        }
    }
}
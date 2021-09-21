using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Exports
{
    public class UFortWorldItemDefinition : UFortItemDefinition
    {
        public FGameplayTagContainer RequiredEquipTags;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            RequiredEquipTags = GetOrDefault<FGameplayTagContainer>(nameof(RequiredEquipTags));
        }
    }
}
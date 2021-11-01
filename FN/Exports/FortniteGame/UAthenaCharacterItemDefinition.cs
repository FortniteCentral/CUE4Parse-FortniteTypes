using System.Collections.Generic;
using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaCharacterItemDefinition : UAthenaCosmeticItemDefinition
    {
        public Dictionary<FName, UClass> RequestedDataStores = new();
        public FSoftObjectPath[]? BaseCharacterParts;
        public UFortHeroType? HeroDefinition;
        public UAthenaBackpackItemDefinition? DefaultBackpack;
        public UAthenaCosmeticItemDefinition[]? RequiredCosmeticItems;
        public float PreviewPawnScale;
        public EFortCustomGender Gender;
        public FSoftObjectPath FeedbackBank; // UFortFeedbackBank
        public Dictionary<FGameplayTag, FAthenaCharacterTaggedPartsList> TaggedPartsOverride = new();

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            var dataStores = GetOrDefault(nameof(RequestedDataStores), new UScriptMap());
            foreach (var (key, value) in dataStores.Properties)
            {
                if (key?.GenericValue is FName name && value?.GenericValue is FPackageIndex i && i.TryLoad<UClass>(out var store))
                {
                    RequestedDataStores.Add(name, store);
                }
            }

            BaseCharacterParts = GetOrDefault<FSoftObjectPath[]>(nameof(BaseCharacterParts));
            HeroDefinition = GetOrDefault<UFortHeroType>(nameof(HeroDefinition));
            DefaultBackpack = GetOrDefault<UAthenaBackpackItemDefinition>(nameof(DefaultBackpack));
            RequiredCosmeticItems = GetOrDefault<UAthenaCosmeticItemDefinition[]>(nameof(RequiredCosmeticItems));
            PreviewPawnScale = GetOrDefault<float>(nameof(PreviewPawnScale));
            Gender = GetOrDefault<EFortCustomGender>(nameof(Gender));
            FeedbackBank = GetOrDefault<FSoftObjectPath>(nameof(FeedbackBank));

            var taggedParts = GetOrDefault(nameof(TaggedPartsOverride), new UScriptMap());
            foreach (var (key, value) in taggedParts.Properties)
            {
                if (key?.GenericValue is UScriptStruct { StructType: FStructFallback tag } && value?.GenericValue is UScriptStruct { StructType: FStructFallback parts })
                {
                    TaggedPartsOverride.Add(new FGameplayTag(tag), new FAthenaCharacterTaggedPartsList(parts));
                }
            }
        }
    }
}

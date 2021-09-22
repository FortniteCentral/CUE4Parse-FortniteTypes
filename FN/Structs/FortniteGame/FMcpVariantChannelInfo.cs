using CUE4Parse.FN.Exports.FortniteGame;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FMcpVariantChannelInfo : FCosmeticVariantInfo
    {
        public FGameplayTagContainer OwnedVariantTags;
        public UFortItemDefinition ItemVariantIsUsedFor;
        public string CustomData;

        public FMcpVariantChannelInfo(FStructFallback fallback) : base(fallback)
        {
            OwnedVariantTags = fallback.GetOrDefault<FGameplayTagContainer>(nameof(OwnedVariantTags));
            ItemVariantIsUsedFor = fallback.GetOrDefault<UFortItemDefinition>(nameof(ItemVariantIsUsedFor));
            CustomData = fallback.GetOrDefault<string>(nameof(CustomData));
        }
    }
}
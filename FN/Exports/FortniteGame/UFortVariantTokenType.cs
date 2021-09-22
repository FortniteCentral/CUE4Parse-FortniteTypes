using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortVariantTokenType : UFortAccountItemDefinition
    {
        public EItemProfileType ProfileType;
        public UFortItemDefinition? cosmetic_item;
        public FGameplayTag? VariantChanelTag;
        public FGameplayTag? VariantNameTag;
        public FCosmeticVariantInfo[]? AdditionalVariantsToGrant;
        public FCosmeticVariantInfo[]? VariantPreviewOverrides;
        public bool bAutoEquipVariant;
        public bool bMarkItemUnseen;
        public bool bCreateGiftbox;
        public string? CustomGiftbox;
        public bool bUseDisplayNameInGiftBox;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ProfileType = GetOrDefault<EItemProfileType>(nameof(ProfileType));
            cosmetic_item = GetOrDefault<UFortItemDefinition>(nameof(cosmetic_item));
            VariantChanelTag = GetOrDefault<FGameplayTag>(nameof(VariantChanelTag));
            VariantNameTag = GetOrDefault<FGameplayTag>(nameof(VariantNameTag));
            AdditionalVariantsToGrant = GetOrDefault<FCosmeticVariantInfo[]>(nameof(AdditionalVariantsToGrant));
            VariantPreviewOverrides = GetOrDefault<FCosmeticVariantInfo[]>(nameof(VariantPreviewOverrides));
            bAutoEquipVariant = GetOrDefault<bool>(nameof(bAutoEquipVariant));
            bMarkItemUnseen = GetOrDefault<bool>(nameof(bMarkItemUnseen));
            bCreateGiftbox = GetOrDefault<bool>(nameof(bCreateGiftbox));
            CustomGiftbox = GetOrDefault<string>(nameof(CustomGiftbox));
            bUseDisplayNameInGiftBox = GetOrDefault<bool>(nameof(bUseDisplayNameInGiftBox));
        }
    }
}
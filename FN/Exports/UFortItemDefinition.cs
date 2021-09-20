using CUE4Parse.FN.Enums;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse_Fortnite.Enums;

namespace CUE4Parse.FN.Exports
{
    public class UFortItemDefinition : UObject
    {
        public EFortRarity Rarity;
        public EFortItemType ItemType;
        public EFortItemType PrimaryAssetIdItemTypeOverride;
        public EFortInventoryFilter FilterOverride;
        public EFortItemTier Tier;
        public EFortItemTier MaxTier;
        public EFortTemplateAccess Access;

        public bool bIsAccountItem;
        public bool bNeverPersisted;
        public bool bAllowMultipleStacks;
        public bool bAutoBalanceStacks;
        public bool bForceAutoPickup;
        public bool bInventorySizeLimited;

        public FText ItemTypeNameOverride;
        public FText DisplayName;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            Rarity = GetOrDefault(nameof(Rarity), EFortRarity.Uncommon);
            ItemType = GetOrDefault<EFortItemType>(nameof(ItemType));
            PrimaryAssetIdItemTypeOverride = GetOrDefault<EFortItemType>(nameof(PrimaryAssetIdItemTypeOverride));
            FilterOverride = GetOrDefault<EFortInventoryFilter>(nameof(FilterOverride));
            Tier = GetOrDefault<EFortItemTier>(nameof(Tier));
            MaxTier = GetOrDefault<EFortItemTier>(nameof(MaxTier));
            Access = GetOrDefault<EFortTemplateAccess>(nameof(Access));

            bIsAccountItem = GetOrDefault<bool>(nameof(bIsAccountItem));
            bNeverPersisted = GetOrDefault<bool>(nameof(bNeverPersisted));
            bAllowMultipleStacks = GetOrDefault<bool>(nameof(bAllowMultipleStacks));
            bAutoBalanceStacks = GetOrDefault<bool>(nameof(bAutoBalanceStacks));
            bForceAutoPickup = GetOrDefault<bool>(nameof(bForceAutoPickup));
            bInventorySizeLimited = GetOrDefault<bool>(nameof(bInventorySizeLimited));

            ItemTypeNameOverride = GetOrDefault<FText>(nameof(ItemTypeNameOverride));
            DisplayName = GetOrDefault<FText>(nameof(DisplayName));
        }
    }
}
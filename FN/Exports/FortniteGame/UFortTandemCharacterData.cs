using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortTandemCharacterData : UObject
    {
        public FGameplayTag? GameplayTag;
        public FGameplayTagContainer POILocations;
        public FText[]? POITextOverrides;
        public FText? DisplayName;
        public FText? GeneralDescription;
        public FText? AdditionalDescription;
        public FText? BehaviorDescription;
        public FSoftObjectPath ToastIcon; // UObject
        public FSoftObjectPath EntryListIcon; // UObject
        public FSoftObjectPath SidePanelIcon; // UObject
        public FSoftObjectPath PunchCardIcon; // UObject
        public FLinearColor PrimaryColor;
        public FLinearColor SecondaryColor;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            GameplayTag = GetOrDefault<FGameplayTag>(nameof(GameplayTag));
            POILocations = GetOrDefault<FGameplayTagContainer>(nameof(POILocations));
            POITextOverrides = GetOrDefault<FText[]>(nameof(POITextOverrides));
            DisplayName = GetOrDefault<FText>(nameof(DisplayName));
            GeneralDescription = GetOrDefault<FText>(nameof(GeneralDescription));
            AdditionalDescription = GetOrDefault<FText>(nameof(AdditionalDescription));
            BehaviorDescription = GetOrDefault<FText>(nameof(BehaviorDescription));
            ToastIcon = GetOrDefault<FSoftObjectPath>(nameof(ToastIcon));
            EntryListIcon = GetOrDefault<FSoftObjectPath>(nameof(EntryListIcon));
            SidePanelIcon = GetOrDefault<FSoftObjectPath>(nameof(SidePanelIcon));
            PunchCardIcon = GetOrDefault<FSoftObjectPath>(nameof(PunchCardIcon));
            PrimaryColor = GetOrDefault<FLinearColor>(nameof(PrimaryColor));
            SecondaryColor = GetOrDefault<FLinearColor>(nameof(SecondaryColor));
        }
    }
}
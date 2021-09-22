using System;
using System.Collections.Generic;
using CUE4Parse.FN.Enums.Fortnite;
using CUE4Parse.FN.Exports.Fortnite.NoProperties;
using CUE4Parse.FN.Structs.Fortnite;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.Fortnite
{
    public class UAthenaCosmeticItemDefinition : UFortAccountItemDefinition
    {
        public bool bIsShuffleTile;
        public bool bIsOwnedByCampaignHero;
        public bool bHasMoreThanOneCharacterPartVariant;
        public bool bHideIfNotOwned;
        public bool bInitializedConfiguredDynamicInstallBundles;
        public bool bDynamicInstallBundlesError;
        public bool bDynamicInstallBundlesCancelled;
        public bool bDynamicInstallBundlesComplete;
        public double DynamicInstallBundlesUpdateStartTime;
        public uint DynamicInstallBundleRequestRefCount;
        public int DynamicInstallBundleRequestRetryCount;
        public EVariantUnlockType VariantUnlockType;
        public FRotator PreviewPawnRotationOffset;
        public UClass[]? FoleyLibraries;
        public FGameplayTagContainer DisallowedCosmeticTags;
        public FGameplayTagContainer MetaTags;
        public FGameplayTag[]? VariantChannelsToNeverSendToMCP;
        public Dictionary<FCosmeticVariantInfo, FSoftObjectPath> ReactivePreviewDrivers = new(); // FSoftObjectPath = UClass
        public FAthenaCosmeticMaterialOverride[]? MaterialOverrides;
        public FGameplayTagContainer ObservedPlayerStats;
        public List<UFortMontageItemDefinitionBase> BuiltInEmotes = new();
        public UFortCosmeticVariant[]? ItemVariants;
        public FGameplayTag? VariantChannelToUseForThumbnails;
        public FFortCosmeticVariantPreview[]? ItemVariantPreviews;
        public UFortVariantPreviewGenerator? ItemVariantPreviewGenerator;
        public FText? DirectAquisitionStyleDisclaimerOverride;
        public FFortCosmeticAdaptiveStatPreview[]? ItemObservedStatPreviews;
        public FText? UnlockRequirements;
        public FSoftObjectPath UnlockingItemDef; // UFortAccountItemDefinition
        public FSoftObjectPath ItemPreviewActorClass; // UClass
        public FSoftObjectPath ItemPreviewParticleSystem; // UFXSystemAsset
        public FSoftObjectPath ItemPreviewMontage_Male; // UAnimMontage
        public FSoftObjectPath ItemPreviewMontage_Female; // UAnimMontage
        public FSoftObjectPath ItemPreviewHero; // UAthenaCharacterItemDefinition
        public FName[]? ConfiguredDynamicInstallBundles;
        public FName[]? PendingDynamicInstallBundles;
        public FGameplayTagContainer ExclusiveRequiresOutfitTags;
        public FText? CustomExclusiveCallout;
        public FText? ExclusiveDescription;
        public FSoftObjectPath ExclusiveIcon; // UTexture2D
        public FText[]? ItemSearchTags;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bIsShuffleTile = GetOrDefault<bool>(nameof(bIsShuffleTile));
            bIsOwnedByCampaignHero = GetOrDefault<bool>(nameof(bIsOwnedByCampaignHero));
            bHasMoreThanOneCharacterPartVariant = GetOrDefault<bool>(nameof(bHasMoreThanOneCharacterPartVariant));
            bHideIfNotOwned = GetOrDefault<bool>(nameof(bHideIfNotOwned));
            bInitializedConfiguredDynamicInstallBundles = GetOrDefault<bool>(nameof(bInitializedConfiguredDynamicInstallBundles));
            bDynamicInstallBundlesError = GetOrDefault<bool>(nameof(bDynamicInstallBundlesError));
            bDynamicInstallBundlesCancelled = GetOrDefault<bool>(nameof(bDynamicInstallBundlesCancelled));
            bDynamicInstallBundlesComplete = GetOrDefault<bool>(nameof(bDynamicInstallBundlesComplete));
            DynamicInstallBundlesUpdateStartTime = GetOrDefault<double>(nameof(DynamicInstallBundlesUpdateStartTime));
            DynamicInstallBundleRequestRefCount = GetOrDefault<uint>(nameof(DynamicInstallBundleRequestRefCount));
            DynamicInstallBundleRequestRetryCount = GetOrDefault<int>(nameof(DynamicInstallBundleRequestRetryCount));
            VariantUnlockType = GetOrDefault<EVariantUnlockType>(nameof(VariantUnlockType));
            PreviewPawnRotationOffset = GetOrDefault<FRotator>(nameof(PreviewPawnRotationOffset));
            FoleyLibraries = GetOrDefault<UClass[]>(nameof(FoleyLibraries));
            DisallowedCosmeticTags = GetOrDefault<FGameplayTagContainer>(nameof(DisallowedCosmeticTags));
            MetaTags = GetOrDefault<FGameplayTagContainer>(nameof(MetaTags));
            VariantChannelsToNeverSendToMCP = GetOrDefault<FGameplayTag[]>(nameof(VariantChannelsToNeverSendToMCP));

            var previewDrivers = GetOrDefault(nameof(ReactivePreviewDrivers), new UScriptMap());
            foreach (var (key, value) in previewDrivers.Properties)
            {
                if (key?.GenericValue is UScriptStruct { StructType: FStructFallback variantInfo } && value?.GenericValue is FSoftObjectPath clazz)
                {
                    ReactivePreviewDrivers.Add(new FCosmeticVariantInfo(variantInfo), clazz);
                }
            }

            MaterialOverrides = GetOrDefault<FAthenaCosmeticMaterialOverride[]>(nameof(MaterialOverrides));
            ObservedPlayerStats = GetOrDefault<FGameplayTagContainer>(nameof(ObservedPlayerStats));

            // Prevents this object from becoming the montage object
            foreach (var montage in GetOrDefault(nameof(BuiltInEmotes), Array.Empty<UFortMontageItemDefinitionBase>()))
            {
                BuiltInEmotes.Add(montage);
            }

            // ItemVariants = GetOrDefault<UFortCosmeticVariant[]>(nameof(ItemVariants)); // TODO: Causes InvalidOperationException
            VariantChannelToUseForThumbnails = GetOrDefault<FGameplayTag>(nameof(VariantChannelToUseForThumbnails));
            ItemVariantPreviews = GetOrDefault<FFortCosmeticVariantPreview[]>(nameof(ItemVariantPreviews));
            ItemVariantPreviewGenerator = GetOrDefault<UFortVariantPreviewGenerator>(nameof(ItemVariantPreviewGenerator));
            DirectAquisitionStyleDisclaimerOverride = GetOrDefault<FText>(nameof(DirectAquisitionStyleDisclaimerOverride));
            ItemObservedStatPreviews = GetOrDefault<FFortCosmeticAdaptiveStatPreview[]>(nameof(ItemObservedStatPreviews));
            UnlockRequirements = GetOrDefault<FText>(nameof(UnlockRequirements));
            UnlockingItemDef = GetOrDefault<FSoftObjectPath>(nameof(UnlockingItemDef));
            ItemPreviewActorClass = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewActorClass));
            ItemPreviewParticleSystem = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewParticleSystem));
            ItemPreviewMontage_Male = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewMontage_Male));
            ItemPreviewMontage_Female = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewMontage_Female));
            ItemPreviewHero = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewHero));
            ConfiguredDynamicInstallBundles = GetOrDefault<FName[]>(nameof(ConfiguredDynamicInstallBundles));
            PendingDynamicInstallBundles = GetOrDefault<FName[]>(nameof(PendingDynamicInstallBundles));
            ExclusiveRequiresOutfitTags = GetOrDefault<FGameplayTagContainer>(nameof(ExclusiveRequiresOutfitTags));
            CustomExclusiveCallout = GetOrDefault<FText>(nameof(CustomExclusiveCallout));
            ExclusiveDescription = GetOrDefault<FText>(nameof(ExclusiveDescription));
            ExclusiveIcon = GetOrDefault<FSoftObjectPath>(nameof(ExclusiveIcon));
            ItemSearchTags = GetOrDefault<FText[]>(nameof(ItemSearchTags));
        }
    }
}
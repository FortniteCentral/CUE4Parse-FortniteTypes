using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.FN.Structs.Engine;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortHeroType : UFortWorkerType
    {
        public bool bForceShowHeadAccessory;
        public bool bForceShowBackpack;
        public FSoftObjectPath[]? Specializations; // UFortHeroSpecialization[]
        public FSoftObjectPath DefaultMontageLookupTable; // UFortMontageLookupTable
        public FSoftObjectPath OverrideMontageLookupTable; // UFortMontageLookupTable
        public FGameplayEffectApplicationInfo[]? CombinedStatGEs;
        public FGameplayTagContainer RequiredGPTags;
        public FSoftObjectPath MaleOverrideFeedback; // UFortFeedbackBank
        public FSoftObjectPath FemaleOverrideFeedback; // UFortFeedbackBank
        public FSoftObjectPath OverridePawnClass; // UClass
        public UObject? HeroGameplayDefinition; // UFortHeroGameplayDefinition
        public UAthenaCharacterItemDefinition? HeroCosmeticOutfitDefinition;
        public UAthenaBackpackItemDefinition? HeroCosmeticBackblingDefinition;
        public FSoftObjectPath FrontEndAnimClass; // UClass
        public FSoftObjectPath FrontendAnimMontageIdleOverride; // UAnimMontage
        public float FrontEndBackPreviewRotationOffset;
        public FText? Subtype;
        public FFortAttributeInitializationKey? AttributeInitKey;
        public FDataTableRowHandle? LegacyStatHandle;
        public FSoftObjectPath ItemPreviewMontage_Male; // UAnimMontage
        public FSoftObjectPath ItemPreviewMontage_Female; // UAnimMontage

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            bForceShowHeadAccessory = GetOrDefault<bool>(nameof(bForceShowHeadAccessory));
            bForceShowBackpack = GetOrDefault<bool>(nameof(bForceShowBackpack));
            Specializations = GetOrDefault<FSoftObjectPath[]>(nameof(Specializations));
            DefaultMontageLookupTable = GetOrDefault<FSoftObjectPath>(nameof(DefaultMontageLookupTable));
            OverrideMontageLookupTable = GetOrDefault<FSoftObjectPath>(nameof(OverrideMontageLookupTable));
            CombinedStatGEs = GetOrDefault<FGameplayEffectApplicationInfo[]>(nameof(CombinedStatGEs));
            RequiredGPTags = GetOrDefault<FGameplayTagContainer>(nameof(RequiredGPTags));
            MaleOverrideFeedback = GetOrDefault<FSoftObjectPath>(nameof(MaleOverrideFeedback));
            FemaleOverrideFeedback = GetOrDefault<FSoftObjectPath>(nameof(FemaleOverrideFeedback));
            OverridePawnClass = GetOrDefault<FSoftObjectPath>(nameof(OverridePawnClass));
            HeroGameplayDefinition = GetOrDefault<UObject>(nameof(HeroGameplayDefinition));
            HeroCosmeticOutfitDefinition = GetOrDefault<UAthenaCharacterItemDefinition>(nameof(HeroCosmeticOutfitDefinition));
            HeroCosmeticBackblingDefinition = GetOrDefault<UAthenaBackpackItemDefinition>(nameof(HeroCosmeticBackblingDefinition));
            FrontEndAnimClass = GetOrDefault<FSoftObjectPath>(nameof(FrontEndAnimClass));
            FrontendAnimMontageIdleOverride = GetOrDefault<FSoftObjectPath>(nameof(FrontendAnimMontageIdleOverride));
            FrontEndBackPreviewRotationOffset = GetOrDefault<float>(nameof(FrontEndBackPreviewRotationOffset));
            Subtype = GetOrDefault<FText>(nameof(Subtype));
            AttributeInitKey = GetOrDefault<FFortAttributeInitializationKey>(nameof(AttributeInitKey));
            LegacyStatHandle = GetOrDefault<FDataTableRowHandle>(nameof(LegacyStatHandle));
            ItemPreviewMontage_Male = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewMontage_Male));
            ItemPreviewMontage_Female = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewMontage_Female));
        }
    }
}
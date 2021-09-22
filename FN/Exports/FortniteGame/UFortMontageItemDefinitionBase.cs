using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortMontageItemDefinitionBase : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath Animation; // UAnimMontage
        public FSoftObjectPath AnimationFemaleOverride; // UAnimMontage
        public FFortEmoteMapping[]? AnimationOverrides;
        public int PreviewLoops;
        public float PreviewLength;
        public bool bIncludeAudioWithAnimDuration;
        public float EmoteCooldownSecs;
        public bool bMontageContainsFacialAnimation;
        public bool bPlayRandomSection;
        public FSectionNameAndWeight[]? PlayRandomSectionByName;
        public bool bSwitchToHarvestingToolOnUse;
        public bool bHolsterWeapon;
        public bool bHolsterWeaponIfDualWieldPickaxe;
        public FMontageItemAccessData[]? AccessData;
        public FMontageVisibilityData[]? VisibilityData;
        public FGameplayTagContainer EmoteWheelExclusiveTags;
        public FSoftObjectPath RequiredEmoteParent; // UAthenaCosmeticItemDefinition
        public FGameplayTagContainer TagsWhichIndicateEmoteParent;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            Animation = GetOrDefault<FSoftObjectPath>(nameof(Animation));
            AnimationFemaleOverride = GetOrDefault<FSoftObjectPath>(nameof(AnimationFemaleOverride));
            AnimationOverrides = GetOrDefault<FFortEmoteMapping[]>(nameof(AnimationOverrides));
            PreviewLoops = GetOrDefault<int>(nameof(PreviewLoops));
            PreviewLength = GetOrDefault<float>(nameof(PreviewLength));
            bIncludeAudioWithAnimDuration = GetOrDefault<bool>(nameof(bIncludeAudioWithAnimDuration));
            EmoteCooldownSecs = GetOrDefault<float>(nameof(EmoteCooldownSecs));
            bMontageContainsFacialAnimation = GetOrDefault<bool>(nameof(bMontageContainsFacialAnimation));
            bPlayRandomSection = GetOrDefault<bool>(nameof(bPlayRandomSection));
            PlayRandomSectionByName = GetOrDefault<FSectionNameAndWeight[]>(nameof(PlayRandomSectionByName));
            bSwitchToHarvestingToolOnUse = GetOrDefault<bool>(nameof(bSwitchToHarvestingToolOnUse));
            bHolsterWeapon = GetOrDefault<bool>(nameof(bHolsterWeapon));
            bHolsterWeaponIfDualWieldPickaxe = GetOrDefault<bool>(nameof(bHolsterWeaponIfDualWieldPickaxe));
            AccessData = GetOrDefault<FMontageItemAccessData[]>(nameof(AccessData));
            VisibilityData = GetOrDefault<FMontageVisibilityData[]>(nameof(VisibilityData));
            EmoteWheelExclusiveTags = GetOrDefault<FGameplayTagContainer>(nameof(EmoteWheelExclusiveTags));
            RequiredEmoteParent = GetOrDefault<FSoftObjectPath>(nameof(RequiredEmoteParent));
            TagsWhichIndicateEmoteParent = GetOrDefault<FGameplayTagContainer>(nameof(TagsWhichIndicateEmoteParent));
        }
    }
}
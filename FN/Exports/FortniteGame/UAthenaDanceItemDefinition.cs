using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaDanceItemDefinition : UFortMontageItemDefinitionBase
    {
        public bool bUsesSecondaryFireInput;
        public bool bMovingEmote;
        public bool bMovingEmoteSkipLandingFX;
        public bool bMoveForwardOnly;
        public bool bMoveFollowingOnly;
        public bool bGroupEmote;
        public bool bUseHighPreviewCamera;
        public bool bGroupAnimationSync;
        public float WalkForwardSpeed;
        public float GroupSyncAnimOffset;
        public UAthenaDanceItemDefinition? GroupEmoteToStartLeader;
        public UAthenaDanceItemDefinition? GroupEmoteToStartFollower;
        public UAthenaDanceItemDefinition? GroupEmoteToStartLeaderIfBothOwn;
        public UAthenaDanceItemDefinition? GroupEmoteToStartFollowerIfBothOwn;
        public FVariantSwapMontageData[]? MontageSelectionGroups;
        public FVector GroupEmotePositionOffset;
        public float GroupEmotePositionOffsetTolerance;
        public float GroupEmoteFollowDistance;
        public bool bLockGroupEmoteLeaderRotation;
        public float GroupEmoteLeaderRotationYawOffset;
        public float GroupEmoteFollowerRotationYawOffset;
        public FSoftObjectPath FrontEndAnimation; // UAnimMontage
        public FSoftObjectPath FrontEndAnimationFemaleOverride; // UAnimMontage
        public FSoftObjectPath CustomDanceAbility; // UClass
        public FText? ChatTriggerCommandName;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);
            bUsesSecondaryFireInput = GetOrDefault<bool>(nameof(bUsesSecondaryFireInput));
            bMovingEmote = GetOrDefault<bool>(nameof(bMovingEmote));
            bMovingEmoteSkipLandingFX = GetOrDefault<bool>(nameof(bMovingEmoteSkipLandingFX));
            bMoveForwardOnly = GetOrDefault<bool>(nameof(bMoveForwardOnly));
            bMoveFollowingOnly = GetOrDefault<bool>(nameof(bMoveFollowingOnly));
            bGroupEmote = GetOrDefault<bool>(nameof(bGroupEmote));
            bUseHighPreviewCamera = GetOrDefault<bool>(nameof(bUseHighPreviewCamera));
            bGroupAnimationSync = GetOrDefault<bool>(nameof(bGroupAnimationSync));
            WalkForwardSpeed = GetOrDefault<float>(nameof(WalkForwardSpeed));
            GroupSyncAnimOffset = GetOrDefault<float>(nameof(GroupSyncAnimOffset));
            GroupEmoteToStartLeader = GetOrDefault<UAthenaDanceItemDefinition>(nameof(GroupEmoteToStartLeader));
            GroupEmoteToStartFollower = GetOrDefault<UAthenaDanceItemDefinition>(nameof(GroupEmoteToStartFollower));
            GroupEmoteToStartLeaderIfBothOwn = GetOrDefault<UAthenaDanceItemDefinition>(nameof(GroupEmoteToStartLeaderIfBothOwn));
            GroupEmoteToStartFollowerIfBothOwn = GetOrDefault<UAthenaDanceItemDefinition>(nameof(GroupEmoteToStartFollowerIfBothOwn));
            MontageSelectionGroups = GetOrDefault<FVariantSwapMontageData[]>(nameof(MontageSelectionGroups));
            GroupEmotePositionOffset = GetOrDefault<FVector>(nameof(GroupEmotePositionOffset));
            GroupEmotePositionOffsetTolerance = GetOrDefault<float>(nameof(GroupEmotePositionOffsetTolerance));
            GroupEmoteFollowDistance = GetOrDefault<float>(nameof(GroupEmoteFollowDistance));
            bLockGroupEmoteLeaderRotation = GetOrDefault<bool>(nameof(bLockGroupEmoteLeaderRotation));
            GroupEmoteLeaderRotationYawOffset = GetOrDefault<float>(nameof(GroupEmoteLeaderRotationYawOffset));
            GroupEmoteFollowerRotationYawOffset = GetOrDefault<float>(nameof(GroupEmoteFollowerRotationYawOffset));
            FrontEndAnimation = GetOrDefault<FSoftObjectPath>(nameof(FrontEndAnimation));
            FrontEndAnimationFemaleOverride = GetOrDefault<FSoftObjectPath>(nameof(FrontEndAnimationFemaleOverride));
            CustomDanceAbility = GetOrDefault<FSoftObjectPath>(nameof(CustomDanceAbility));
            ChatTriggerCommandName = GetOrDefault<FText>(nameof(ChatTriggerCommandName));
        }
    }
}
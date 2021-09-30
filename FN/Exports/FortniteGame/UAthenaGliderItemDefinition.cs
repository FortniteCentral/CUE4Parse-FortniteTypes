using System;
using System.Collections.Generic;
using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaGliderItemDefinition : UAthenaCosmeticItemDefinition
    {
        public EFortGliderType GliderType;
        public FVector CameraFramingBoundsCenterOffset;
        public bool bActivateTrailsOnRotationalMovement;
        public FSoftObjectPath ParachutePrefabClass; // UClass
        public FSoftObjectPath SkeletalMesh; // USkeletalMesh
        public FSoftObjectPath AnimClass; // UClass
        public FSoftObjectPath CameraClass; // UClass
        public FSoftObjectPath PlayerAnimSet; // UFortPlayerGliderAnimSet
        public FTransform GliderMeshTransform;
        public FSoftObjectPath TrailParticles; // UParticleSystem
        public FSoftObjectPath OwnerTrailParticles; // UParticleSystem
        public FName TrailParamName;
        public FName AttachSocket;
        public FSoftObjectPath TrailEffect; // UParticleSystem
        public FSoftObjectPath TrailEffectNiagara; // UNiagaraSystem
        public FSoftObjectPath TrailEffect2; // UParticleSystem
        public FSoftObjectPath TrailEffectNiagara2; // UNiagaraSystem
        public FStructFallback[]? GlidingSwaps; // FFortCosmeticDependentSwapData[]
        public bool bAutoActivate;
        public FName DeployEffectTagName;
        public bool CleanUpDeployEffect;
        public bool bAttachNiagaraEffectToPlayerPawn;
        public FName UserSkeletonParameterName;
        public FSoftObjectPath OpenSound; // USoundBase
        public FSoftObjectPath CloseSound; // USoundBase
        public FSoftObjectPath ThrustLoopSound; // USoundBase
        public Dictionary<ELayeredAudioTriggerDirection, FStructFallback> ThrustSoundParams = new(); // FFortGliderLayeredAudioFloatParam

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            GliderType = GetOrDefault<EFortGliderType>(nameof(GliderType));
            CameraFramingBoundsCenterOffset = GetOrDefault<FVector>(nameof(CameraFramingBoundsCenterOffset));
            bActivateTrailsOnRotationalMovement = GetOrDefault<bool>(nameof(bActivateTrailsOnRotationalMovement));
            ParachutePrefabClass = GetOrDefault<FSoftObjectPath>(nameof(ParachutePrefabClass));
            SkeletalMesh = GetOrDefault<FSoftObjectPath>(nameof(SkeletalMesh));
            AnimClass = GetOrDefault<FSoftObjectPath>(nameof(AnimClass));
            CameraClass = GetOrDefault<FSoftObjectPath>(nameof(CameraClass));
            PlayerAnimSet = GetOrDefault<FSoftObjectPath>(nameof(PlayerAnimSet));
            GliderMeshTransform = GetOrDefault<FTransform>(nameof(GliderMeshTransform));
            TrailParticles = GetOrDefault<FSoftObjectPath>(nameof(TrailParticles));
            OwnerTrailParticles = GetOrDefault<FSoftObjectPath>(nameof(OwnerTrailParticles));
            TrailParamName = GetOrDefault<FName>(nameof(TrailParamName));
            AttachSocket = GetOrDefault<FName>(nameof(AttachSocket));
            TrailEffect = GetOrDefault<FSoftObjectPath>(nameof(TrailEffect));
            TrailEffectNiagara = GetOrDefault<FSoftObjectPath>(nameof(TrailEffectNiagara));
            TrailEffect2 = GetOrDefault<FSoftObjectPath>(nameof(TrailEffect2));
            TrailEffectNiagara2 = GetOrDefault<FSoftObjectPath>(nameof(TrailEffectNiagara2));
            GlidingSwaps = GetOrDefault<FStructFallback[]>(nameof(GlidingSwaps));
            bAutoActivate = GetOrDefault<bool>(nameof(bAutoActivate));
            DeployEffectTagName = GetOrDefault<FName>(nameof(DeployEffectTagName));
            CleanUpDeployEffect = GetOrDefault<bool>(nameof(CleanUpDeployEffect));
            bAttachNiagaraEffectToPlayerPawn = GetOrDefault<bool>(nameof(bAttachNiagaraEffectToPlayerPawn));
            UserSkeletonParameterName = GetOrDefault<FName>(nameof(UserSkeletonParameterName));
            OpenSound = GetOrDefault<FSoftObjectPath>(nameof(OpenSound));
            CloseSound = GetOrDefault<FSoftObjectPath>(nameof(CloseSound));
            ThrustLoopSound = GetOrDefault<FSoftObjectPath>(nameof(ThrustLoopSound));

            var soundParams = GetOrDefault(nameof(ThrustSoundParams), new UScriptMap());
            foreach (var (key, value) in soundParams.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out ELayeredAudioTriggerDirection direction) &&
                    value?.GenericValue is UScriptStruct { StructType: FStructFallback param })
                {
                    ThrustSoundParams.Add(direction, param);
                }
            }
        }
    }
}
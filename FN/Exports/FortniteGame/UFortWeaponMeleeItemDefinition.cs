using System;
using System.Collections.Generic;
using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Enums.PhysicsCore;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWeaponMeleeItemDefinition : UFortWeaponItemDefinition
    {
        public FSoftObjectPath IdleEffect; // UParticleSystem
        public FSoftObjectPath IdleEffectNiagara; // UNiagaraSystem
        public FName IdleFXSocketName;
        public FSoftObjectPath SwingEffect; // UParticleSystem
        public FSoftObjectPath SwingEffectNiagara; // UNiagaraSystem
        public FName SwingFXSocketName;
        public FSoftObjectPath AnimTrails; // UParticleSystem
        public FSoftObjectPath AnimTrailsNiagara; // UNiagaraSystem
        public FName NiagaraSkeletonDIVariableName;
        public FName AnimTrailsFirstSocketName;
        public FName AnimTrailsSecondSocketName;
        public float AnimTrailsWidth;
        public bool bUseAnimTrails;
        public bool bAttachAnimTrailsToWeapon;
        public Dictionary<EPhysicalSurface, FSoftObjectPath> ImpactPhysicalSurfaceEffectsMap = new(); // UParticleSystem
        public FSoftObjectPath[]? ImpactNiagaraPhysicalSurfaceEffects; // UNiagaraSystem[]
        public Dictionary<EPhysicalSurface, FSoftObjectPath> ImpactNiagaraPhysicalSurfaceEffectsMap = new(); // UNiagaraSystem
        public FStructFallback[]? ParticleComponentsDefs; // FAttachedParticleComponentDef[]
        public FSoftObjectPath[]? WeaponMaterialOverrides;
        public FSoftObjectPath AnimClass; // UClass
        public FSoftObjectPath SingleAnimationToPlay; // UAnimationAsset
        public Dictionary<EPhysicalSurface, FSoftObjectPath> ImpactPhysicalSurfaceSoundsMap = new(); // USoundBase
        public Dictionary<EFortReloadFXState, FSoftObjectPath> ReloadSoundsMap = new(); // USoundBase
        public Dictionary<EFortWeaponSoundState, FSoftObjectPath> PrimaryFireSoundMap = new(); // USoundBase
        public FSoftObjectPath GenericImpactSound; // USoundBase
        public bool bNeedsMaterial0MID;
        public bool bWatchKills;
        public bool bCandyCaneKillReaction;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            IdleEffect = GetOrDefault<FSoftObjectPath>(nameof(IdleEffect));
            IdleEffectNiagara = GetOrDefault<FSoftObjectPath>(nameof(IdleEffectNiagara));
            IdleFXSocketName = GetOrDefault<FName>(nameof(IdleFXSocketName));
            SwingEffect = GetOrDefault<FSoftObjectPath>(nameof(SwingEffect));
            SwingEffectNiagara = GetOrDefault<FSoftObjectPath>(nameof(SwingEffectNiagara));
            SwingFXSocketName = GetOrDefault<FName>(nameof(SwingFXSocketName));
            AnimTrails = GetOrDefault<FSoftObjectPath>(nameof(AnimTrails));
            AnimTrailsNiagara = GetOrDefault<FSoftObjectPath>(nameof(AnimTrailsNiagara));
            NiagaraSkeletonDIVariableName = GetOrDefault<FName>(nameof(NiagaraSkeletonDIVariableName));
            AnimTrailsFirstSocketName = GetOrDefault<FName>(nameof(AnimTrailsFirstSocketName));
            AnimTrailsSecondSocketName = GetOrDefault<FName>(nameof(AnimTrailsSecondSocketName));
            AnimTrailsWidth = GetOrDefault<float>(nameof(AnimTrailsWidth));
            bUseAnimTrails = GetOrDefault<bool>(nameof(bUseAnimTrails));
            bAttachAnimTrailsToWeapon = GetOrDefault<bool>(nameof(bAttachAnimTrailsToWeapon));

            var impPhysicalFx = GetOrDefault(nameof(ImpactPhysicalSurfaceEffectsMap), new UScriptMap());
            foreach (var (key, value) in impPhysicalFx.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out EPhysicalSurface surface) &&
                    value?.GenericValue is FSoftObjectPath path)
                {
                    ImpactPhysicalSurfaceEffectsMap.Add(surface, path);
                }
            }

            ImpactNiagaraPhysicalSurfaceEffects = GetOrDefault<FSoftObjectPath[]>(nameof(ImpactNiagaraPhysicalSurfaceEffects));

            var impNiagaraPhysFx = GetOrDefault(nameof(ImpactNiagaraPhysicalSurfaceEffectsMap), new UScriptMap());
            foreach (var (key, value) in impNiagaraPhysFx.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out EPhysicalSurface surface) &&
                    value?.GenericValue is FSoftObjectPath path)
                {
                    ImpactNiagaraPhysicalSurfaceEffectsMap.Add(surface, path);
                }
            }

            ParticleComponentsDefs = GetOrDefault<FStructFallback[]>(nameof(ParticleComponentsDefs));
            WeaponMaterialOverrides = GetOrDefault<FSoftObjectPath[]>(nameof(WeaponMaterialOverrides));
            AnimClass = GetOrDefault<FSoftObjectPath>(nameof(AnimClass));
            SingleAnimationToPlay = GetOrDefault<FSoftObjectPath>(nameof(SingleAnimationToPlay));

            var impPhysSound = GetOrDefault(nameof(ImpactPhysicalSurfaceSoundsMap), new UScriptMap());
            foreach (var (key, value) in impPhysSound.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out EPhysicalSurface surface) &&
                    value?.GenericValue is FSoftObjectPath path)
                {
                    ImpactPhysicalSurfaceSoundsMap.Add(surface, path);
                }
            }

            var reloadSounds = GetOrDefault(nameof(ReloadSoundsMap), new UScriptMap());
            foreach (var (key, value) in reloadSounds.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out EFortReloadFXState state) &&
                    value?.GenericValue is FSoftObjectPath path)
                {
                    ReloadSoundsMap.Add(state, path);
                }
            }

            var fireSounds = GetOrDefault(nameof(PrimaryFireSoundMap), new UScriptMap());
            foreach (var (key, value) in fireSounds.Properties)
            {
                if (key is EnumProperty k && Enum.TryParse(k.Value.Text, true, out EFortWeaponSoundState state) &&
                    value?.GenericValue is FSoftObjectPath path)
                {
                    PrimaryFireSoundMap.Add(state, path);
                }
            }

            GenericImpactSound = GetOrDefault<FSoftObjectPath>(nameof(GenericImpactSound));
            bNeedsMaterial0MID = GetOrDefault<bool>(nameof(bNeedsMaterial0MID));
            bWatchKills = GetOrDefault<bool>(nameof(bWatchKills));
            bCandyCaneKillReaction = GetOrDefault<bool>(nameof(bCandyCaneKillReaction));
        }
    }
}
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWeaponRangedItemDefinition : UFortWeaponItemDefinition
    {
        public FSoftObjectPath ProjectileTemplate; // UClass
        public FSoftObjectPath BulletShellFXTemplate; // UClass
        public bool bUseNativeWeaponTrace;
        public bool bTraceThroughPawns;
        public bool bTraceThroughWorld;
        public bool bShouldSpawnBulletShellFX;
        public bool bShouldUsePerfectAimWhenTargetingMinSpread;
        public bool bDoNotAllowDoublePump;
        public bool bUseOnTouch;
        public bool bAllowADSInAir;
        public bool bShowReticleHitNotifyAtImpactLocation;
        public bool bForceProjectileTooltip;
        public bool bSecondaryFireRequiresAmmo;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ProjectileTemplate = GetOrDefault<FSoftObjectPath>(nameof(ProjectileTemplate));
            BulletShellFXTemplate = GetOrDefault<FSoftObjectPath>(nameof(BulletShellFXTemplate));
            bUseNativeWeaponTrace = GetOrDefault<bool>(nameof(bUseNativeWeaponTrace));
            bTraceThroughPawns = GetOrDefault<bool>(nameof(bTraceThroughPawns));
            bTraceThroughWorld = GetOrDefault<bool>(nameof(bTraceThroughWorld));
            bShouldSpawnBulletShellFX = GetOrDefault<bool>(nameof(bShouldSpawnBulletShellFX));
            bShouldUsePerfectAimWhenTargetingMinSpread = GetOrDefault<bool>(nameof(bShouldUsePerfectAimWhenTargetingMinSpread));
            bDoNotAllowDoublePump = GetOrDefault<bool>(nameof(bDoNotAllowDoublePump));
            bUseOnTouch = GetOrDefault<bool>(nameof(bUseOnTouch));
            bAllowADSInAir = GetOrDefault<bool>(nameof(bAllowADSInAir));
            bShowReticleHitNotifyAtImpactLocation = GetOrDefault<bool>(nameof(bShowReticleHitNotifyAtImpactLocation));
            bForceProjectileTooltip = GetOrDefault<bool>(nameof(bForceProjectileTooltip));
            bSecondaryFireRequiresAmmo = GetOrDefault<bool>(nameof(bSecondaryFireRequiresAmmo));
        }
    }
}
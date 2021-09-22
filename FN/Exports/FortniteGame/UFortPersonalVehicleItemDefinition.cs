using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortPersonalVehicleItemDefinition : UFortAccountItemDefinition
    {
        public FSoftObjectPath PersonalVehicleAbility; // UClass
        public float MountTime;
        public FSoftObjectPath SkeletalMesh; // USkeletalMesh
        public UClass? AnimClass;
        public FSoftObjectPath ActivateSound; // USoundBase
        public FSoftObjectPath DeactivateSound; // USoundBase

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            PersonalVehicleAbility = GetOrDefault<FSoftObjectPath>(nameof(PersonalVehicleAbility));
            MountTime = GetOrDefault<float>(nameof(MountTime));
            SkeletalMesh = GetOrDefault<FSoftObjectPath>(nameof(SkeletalMesh));
            AnimClass = GetOrDefault<UClass>(nameof(AnimClass));
            ActivateSound = GetOrDefault<FSoftObjectPath>(nameof(ActivateSound));
            DeactivateSound = GetOrDefault<FSoftObjectPath>(nameof(DeactivateSound));
        }
    }
}
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaCharmItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath CharmModifierBlueprint; // UClass
        public FSoftObjectPath CharmPrefabClass; // UClass
        public FSoftObjectPath SkeletalMesh; // USkeletalMesh
        public FSoftObjectPath AnimClass; // UClass
        public FSoftObjectPath WeaponAnimClass; // UClass
        public FCharmSoundAssetEntry[]? CharmSounds;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            CharmModifierBlueprint = GetOrDefault<FSoftObjectPath>(nameof(CharmModifierBlueprint));
            CharmPrefabClass = GetOrDefault<FSoftObjectPath>(nameof(CharmPrefabClass));
            SkeletalMesh = GetOrDefault<FSoftObjectPath>(nameof(SkeletalMesh));
            AnimClass = GetOrDefault<FSoftObjectPath>(nameof(AnimClass));
            WeaponAnimClass = GetOrDefault<FSoftObjectPath>(nameof(WeaponAnimClass));
            CharmSounds = GetOrDefault<FCharmSoundAssetEntry[]>(nameof(CharmSounds));
        }
    }
}
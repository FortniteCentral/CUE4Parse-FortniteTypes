using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaPetItemDefinition : UAthenaCosmeticItemDefinition
    {
        public EAthenaPetAttachRule PetAttachRule;
        public FVector PetAttachOffset;
        public FName PetAttachSocket;
        public UObject[]? StimuliBanks; // UFortPetStimuliBank[]
        public FSoftObjectPath PetPrefabClass; // UClass
        public FSoftObjectPath PetSoundBank; // UFortTaggedSoundBank

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            PetAttachRule = GetOrDefault<EAthenaPetAttachRule>(nameof(PetAttachRule));
            PetAttachOffset = GetOrDefault<FVector>(nameof(PetAttachOffset));
            PetAttachSocket = GetOrDefault<FName>(nameof(PetAttachSocket));
            StimuliBanks = GetOrDefault<UObject[]>(nameof(StimuliBanks));
            PetPrefabClass = GetOrDefault<FSoftObjectPath>(nameof(PetPrefabClass));
            PetSoundBank = GetOrDefault<FSoftObjectPath>(nameof(PetSoundBank));
        }
    }
}
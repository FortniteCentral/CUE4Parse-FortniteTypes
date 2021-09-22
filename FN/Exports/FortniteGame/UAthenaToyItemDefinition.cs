using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaToyItemDefinition : UAthenaDanceItemDefinition
    {
        public FSoftObjectPath ToySpawnAbility; // UClass
        public FSoftObjectPath ToyActorClass; // UClass
        public FSoftObjectPath FrontEndPreviewActor; // UClass
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ToySpawnAbility = GetOrDefault<FSoftObjectPath>(nameof(ToySpawnAbility));
            ToyActorClass = GetOrDefault<FSoftObjectPath>(nameof(ToyActorClass));
            FrontEndPreviewActor = GetOrDefault<FSoftObjectPath>(nameof(FrontEndPreviewActor));
        }
    }
}
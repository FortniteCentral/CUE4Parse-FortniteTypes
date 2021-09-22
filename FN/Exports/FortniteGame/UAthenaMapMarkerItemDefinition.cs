using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaMapMarkerItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath TopperActorClass; // UClass
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            TopperActorClass = GetOrDefault<FSoftObjectPath>(nameof(TopperActorClass));
        }
    }
}
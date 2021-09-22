using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaBattleBusItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath IgnitionSound; // USoundBase
        public FSoftObjectPath LobbyLoopingMusic; // USoundBase
        public FSoftObjectPath LobbyLoopingSound; // USoundBase
        public FSoftObjectPath FlightLoopingMusic; // USoundBase
        public FSoftObjectPath FlightLoopingSound; // USoundBase
        public FSoftObjectPath BusPrefabClass; // UClass

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            IgnitionSound = GetOrDefault<FSoftObjectPath>(nameof(IgnitionSound));
            LobbyLoopingMusic = GetOrDefault<FSoftObjectPath>(nameof(LobbyLoopingMusic));
            LobbyLoopingSound = GetOrDefault<FSoftObjectPath>(nameof(LobbyLoopingSound));
            FlightLoopingMusic = GetOrDefault<FSoftObjectPath>(nameof(FlightLoopingMusic));
            FlightLoopingSound = GetOrDefault<FSoftObjectPath>(nameof(FlightLoopingSound));
            BusPrefabClass = GetOrDefault<FSoftObjectPath>(nameof(BusPrefabClass));
        }
    }
}
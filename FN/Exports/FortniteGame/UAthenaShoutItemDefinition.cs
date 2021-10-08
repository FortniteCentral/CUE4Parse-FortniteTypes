using System.Collections.Generic;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaShoutItemDefinition : UAthenaEmojiItemDefinition
    {
        public FSoftObjectPath ShoutSound; // USoundBase
        public List<UObject> TemporarilyHeldAudioComponents = new(); // UAudioComponent

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ShoutSound = GetOrDefault<FSoftObjectPath>(nameof(ShoutSound));

            var audioComp = GetOrDefault(nameof(TemporarilyHeldAudioComponents), new UScriptSet());
            foreach (var prop in audioComp.Properties)
            {
                if (prop.GenericValue is FPackageIndex i && i.TryLoad<UObject>(out var component))
                {
                    TemporarilyHeldAudioComponents.Add(component);
                }
            }
        }
    }
}
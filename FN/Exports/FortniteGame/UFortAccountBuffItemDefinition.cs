using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortAccountBuffItemDefinition : UFortAccountItemDefinition
    {
        public FSoftObjectPath[]? BuffEffects; // UClass[]

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            BuffEffects = GetOrDefault<FSoftObjectPath[]>(nameof(BuffEffects));
        }
    }
}
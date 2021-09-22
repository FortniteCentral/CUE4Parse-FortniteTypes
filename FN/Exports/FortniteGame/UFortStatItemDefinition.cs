using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortStatItemDefinition : UFortAccountItemDefinition
    {
        public EFortStatType Stat;
        public FGameplayAttribute? StatAttribute;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            Stat = GetOrDefault<EFortStatType>(nameof(Stat));
            StatAttribute = GetOrDefault<FGameplayAttribute>(nameof(StatAttribute));
        }
    }
}
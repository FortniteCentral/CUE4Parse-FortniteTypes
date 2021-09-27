using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FSpecialActorSingleStatData 
    {
        public ESpecialActorStatType StatType;
        public float Value;
        public float StatLogicValue;

        public FSpecialActorSingleStatData(FStructFallback fallback)
        {
            StatType = fallback.GetOrDefault<ESpecialActorStatType>(nameof(StatType));
            Value = fallback.GetOrDefault<float>(nameof(Value));
            StatLogicValue = fallback.GetOrDefault<float>(nameof(StatLogicValue));
        }
    }
}
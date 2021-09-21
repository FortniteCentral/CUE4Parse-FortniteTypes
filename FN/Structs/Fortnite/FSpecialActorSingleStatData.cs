using CUE4Parse.FN.Enums.Fortnite;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FSpecialActorSingleStatData : IUStruct
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
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortHiddenRewardQuantityPair
    {
        public FName TemplateId;
        public int Quantity;

        public FFortHiddenRewardQuantityPair(FStructFallback fallback)
        {
            TemplateId = fallback.GetOrDefault<FName>(nameof(TemplateId));
            Quantity = fallback.GetOrDefault<int>(nameof(Quantity));
        }
    }
}
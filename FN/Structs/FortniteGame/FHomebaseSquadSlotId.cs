using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FHomebaseSquadSlotId
    {
        public FName SquadId;
        public int SquadSlotIndex;

        public FHomebaseSquadSlotId(FStructFallback fallback)
        {
            SquadId = fallback.GetOrDefault<FName>(nameof(SquadId));
            SquadSlotIndex = fallback.GetOrDefault<int>(nameof(SquadSlotIndex));
        }
    }
}
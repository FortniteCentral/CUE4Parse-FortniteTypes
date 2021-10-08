using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FHomebaseNodeLevel
    {
        public FName DisplayDataId;
        public int MinCommanderLevel;
        public FFortItemQuantityPair[] Cost;
        public FName[] GameplayEffectRowNames;
        public FSoftObjectPath AbilityKit; // UFortAbilityKit
        public FHomebaseSquadSlotId[] UnlockedSquadSlots;
        
        public FHomebaseNodeLevel(FStructFallback fallback)
        {
            DisplayDataId = fallback.GetOrDefault<FName>(nameof(DisplayDataId));
            MinCommanderLevel = fallback.GetOrDefault<int>(nameof(MinCommanderLevel));
            Cost = fallback.GetOrDefault<FFortItemQuantityPair[]>(nameof(Cost));
            GameplayEffectRowNames = fallback.GetOrDefault<FName[]>(nameof(GameplayEffectRowNames));
            AbilityKit = fallback.GetOrDefault<FSoftObjectPath>(nameof(AbilityKit));
            UnlockedSquadSlots = fallback.GetOrDefault<FHomebaseSquadSlotId[]>(nameof(UnlockedSquadSlots));
        }
    }
}
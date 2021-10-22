using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Misc;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FRepeatableDailiesCardDateOverride
    {
        public FSoftObjectPath Quest; // UFortQuestItemDefinition
        public FDateTime Start;
        public FDateTime End;
        
        public FRepeatableDailiesCardDateOverride(FStructFallback fallback)
        {
            Quest = fallback.GetOrDefault<FSoftObjectPath>(nameof(Quest));
            Start = fallback.GetOrDefault<FDateTime>(nameof(Start));
            End = fallback.GetOrDefault<FDateTime>(nameof(End));
        }
    }
}
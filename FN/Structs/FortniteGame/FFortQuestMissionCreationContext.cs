using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortQuestMissionCreationContext
    {
        public FSoftObjectPath MissionInfo; // UFortMissionInfo
        public FGameplayTagContainer[] MissionCreationContextTags;
        public bool bSetQuestOwnerAsMissionOwner;
        public int MaxNumberToSpawnInWorld;

        public FFortQuestMissionCreationContext(FStructFallback fallback)
        {
            MissionInfo = fallback.GetOrDefault<FSoftObjectPath>(nameof(MissionInfo));
            MissionCreationContextTags = fallback.GetOrDefault<FGameplayTagContainer[]>(nameof(MissionCreationContextTags));
            bSetQuestOwnerAsMissionOwner = fallback.GetOrDefault<bool>(nameof(bSetQuestOwnerAsMissionOwner));
            MaxNumberToSpawnInWorld = fallback.GetOrDefault<int>(nameof(MaxNumberToSpawnInWorld));
        }
    }
}
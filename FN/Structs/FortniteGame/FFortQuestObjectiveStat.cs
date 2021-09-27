using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortQuestObjectiveStat
    {
        public FInlineObjectiveStatTagCheckEntry[] TagConditions;
        public string Condition;
        public string[] TemplateIds;
        public EFortQuestObjectiveStatEvent Type;
        public bool bIsCached;
        public bool bHasInclusiveTargetTags;
        public bool bHasInclusiveSourceTags;
        public bool bHasInclusiveContextTags;

        public FFortQuestObjectiveStat(FStructFallback fallback)
        {
            TagConditions = fallback.GetOrDefault<FInlineObjectiveStatTagCheckEntry[]>(nameof(TagConditions));
            Condition = fallback.GetOrDefault<string>(nameof(Condition));
            TemplateIds = fallback.GetOrDefault<string[]>(nameof(TemplateIds));
            Type = fallback.GetOrDefault<EFortQuestObjectiveStatEvent>(nameof(Type));
            bIsCached = fallback.GetOrDefault<bool>(nameof(bIsCached));
            bHasInclusiveTargetTags = fallback.GetOrDefault<bool>(nameof(bHasInclusiveTargetTags));
            bHasInclusiveSourceTags = fallback.GetOrDefault<bool>(nameof(bHasInclusiveSourceTags));
            bHasInclusiveContextTags = fallback.GetOrDefault<bool>(nameof(bHasInclusiveContextTags));
        }
    }
}
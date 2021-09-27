using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FAthenaRewardItemReference
    {
        public FSoftObjectPath ItemDefinition; // UFortItemDefinition
        public string TemplateId;
        public int Quantity;
        public FChallengeGiftBoxData RewardGiftBox;
        public bool IsChaseReward;
        public EAthenaRewardItemType RewardType;
        public EAthenaRewardVisualImportanceType RewardVisualImportanceType;
        public FMcpVariantChannelInfo[] AdditionalPreviewVariants;

        public FAthenaRewardItemReference(FStructFallback fallback)
        {
            ItemDefinition = fallback.GetOrDefault<FSoftObjectPath>(nameof(ItemDefinition));
            TemplateId = fallback.GetOrDefault<string>(nameof(TemplateId));
            Quantity = fallback.GetOrDefault<int>(nameof(Quantity));
            RewardGiftBox = fallback.GetOrDefault<FChallengeGiftBoxData>(nameof(RewardGiftBox));
            IsChaseReward = fallback.GetOrDefault<bool>(nameof(IsChaseReward));
            RewardType = fallback.GetOrDefault<EAthenaRewardItemType>(nameof(RewardType));
            RewardVisualImportanceType = fallback.GetOrDefault<EAthenaRewardVisualImportanceType>(nameof(RewardVisualImportanceType));
            AdditionalPreviewVariants = fallback.GetOrDefault<FMcpVariantChannelInfo[]>(nameof(AdditionalPreviewVariants));
        }
    }
}
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.GA;
using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortAmmoItemDefinition : UFortWorldItemDefinition
    {
        public FSlateBrush? ClipIconBrush;
        public FScalableFloat? bIsConsumed;
        public bool bTriggersFeedbackLines;
        public FScalableFloat? RegenCooldown;
        public FFortMultiSizeBrush? AmmoIconBrush;
        public FSoftObjectPath HUDAmmoSmallPreviewImage; // UTexture2D
        public UClass? WorldItemClassOverride;
        public UPlaylistUserOptions? ItemOptions;
        public FFortCreativeTagsHelper? CreativeTagsHelper;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ClipIconBrush = GetOrDefault<FSlateBrush>(nameof(ClipIconBrush));
            bIsConsumed = GetOrDefault<FScalableFloat>(nameof(bIsConsumed));
            bTriggersFeedbackLines = GetOrDefault<bool>(nameof(bTriggersFeedbackLines));
            RegenCooldown = GetOrDefault<FScalableFloat>(nameof(RegenCooldown));
            AmmoIconBrush = GetOrDefault<FFortMultiSizeBrush>(nameof(AmmoIconBrush));
            HUDAmmoSmallPreviewImage = GetOrDefault<FSoftObjectPath>(nameof(HUDAmmoSmallPreviewImage));
            WorldItemClassOverride = GetOrDefault<UClass>(nameof(WorldItemClassOverride));
            ItemOptions = GetOrDefault<UPlaylistUserOptions>(nameof(ItemOptions));
            CreativeTagsHelper = GetOrDefault<FFortCreativeTagsHelper>(nameof(CreativeTagsHelper));
        }
    }
}
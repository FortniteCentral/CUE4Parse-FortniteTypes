using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FFortCosmeticVariantPreview 
    {
        public FText UnlockCondition;
        public float PreviewTime;
        public FMcpVariantChannelInfo[] VariantOptions;
        public FFortCosmeticVariantPreviewElement[] AdditionalItems;

        public FFortCosmeticVariantPreview(FStructFallback fallback)
        {
            UnlockCondition = fallback.GetOrDefault<FText>(nameof(UnlockCondition));
            PreviewTime = fallback.GetOrDefault<float>(nameof(PreviewTime));
            VariantOptions = fallback.GetOrDefault<FMcpVariantChannelInfo[]>(nameof(VariantOptions));
            AdditionalItems = fallback.GetOrDefault<FFortCosmeticVariantPreviewElement[]>(nameof(AdditionalItems));
        }
    }
}
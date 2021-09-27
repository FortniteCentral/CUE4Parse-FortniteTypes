using CUE4Parse.FN.Enums.SlateCore;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.SlateCore
{
    [StructFallback]
    public class FSlateBrush 
    {
        public FVector2D ImageSize;
        public FMargin Margin;
        public FSlateColor TintColor;
        public UObject ResourceObject;
        public FName ResourceName;
        public FBox2D UVRegion;
        public ESlateBrushDrawType DrawAs;
        public ESlateBrushTileType Tiling;
        public ESlateBrushMirrorType Mirroring;
        public ESlateBrushImageType ImageType;
        public bool bIsDynamicallyLoaded;
        public bool bHasUObject;

        public FSlateBrush(FStructFallback fallback)
        {
            ImageSize = fallback.GetOrDefault<FVector2D>(nameof(ImageSize));
            Margin = fallback.GetOrDefault<FMargin>(nameof(Margin));
            TintColor = fallback.GetOrDefault<FSlateColor>(nameof(TintColor));
            ResourceObject = fallback.GetOrDefault<UObject>(nameof(ResourceObject));
            ResourceName = fallback.GetOrDefault<FName>(nameof(ResourceName));
            UVRegion = fallback.GetOrDefault<FBox2D>(nameof(UVRegion));
            DrawAs = fallback.GetOrDefault<ESlateBrushDrawType>(nameof(DrawAs));
            Tiling = fallback.GetOrDefault<ESlateBrushTileType>(nameof(Tiling));
            Mirroring = fallback.GetOrDefault<ESlateBrushMirrorType>(nameof(Mirroring));
            ImageType = fallback.GetOrDefault<ESlateBrushImageType>(nameof(ImageType));
            bIsDynamicallyLoaded = fallback.GetOrDefault<bool>(nameof(bIsDynamicallyLoaded));
            bHasUObject = fallback.GetOrDefault<bool>(nameof(bHasUObject));
        }
    }
}
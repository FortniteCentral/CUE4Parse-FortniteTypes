using CUE4Parse.FN.Enums.FortniteUI;
using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.FN.Structs.FortniteUI;
using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Exports.Material;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;

namespace CUE4Parse.FN.Exports.FortniteUI
{
    public class UFortMtxOfferData : UObject
    {
        public FText? DisplayName;
        public FText? ShortDisplayName;
        public FText? ShortDescription;
        public FText? SubTitleText;
        public FText? DisclaimerText;
        public FFortItemQuantityPair[]? GrantOverride;
        public FSlateBrush? TileImage;
        public FSlateBrush? BadgeImage;
        public FSlateBrush? DetailsImage;
        public FSlateBrush? SimpleImage;
        public UMaterialInterface? DetailsBadge;
        public FFortMtxDetailsAttribute[]? DetailsAttributes;
        public FFortMtxGradient? Gradient;
        public FLinearColor Background;
        public FSlateBrush? BackgroundImage;
        public FLinearColor UpsellPrimaryColor;
        public FLinearColor UpsellSecondaryColor;
        public FLinearColor UpsellTextColor;
        public bool bUseBaseColors;
        public EFortMtxOfferDisplaySize DisplaySize;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DisplayName = GetOrDefault<FText>(nameof(DisplayName));
            ShortDisplayName = GetOrDefault<FText>(nameof(ShortDisplayName));
            ShortDescription = GetOrDefault<FText>(nameof(ShortDescription));
            SubTitleText = GetOrDefault<FText>(nameof(SubTitleText));
            DisclaimerText = GetOrDefault<FText>(nameof(DisclaimerText));
            GrantOverride = GetOrDefault<FFortItemQuantityPair[]>(nameof(GrantOverride));
            TileImage = GetOrDefault<FSlateBrush>(nameof(TileImage));
            BadgeImage = GetOrDefault<FSlateBrush>(nameof(BadgeImage));
            DetailsImage = GetOrDefault<FSlateBrush>(nameof(DetailsImage));
            SimpleImage = GetOrDefault<FSlateBrush>(nameof(SimpleImage));
            DetailsBadge = GetOrDefault<UMaterialInterface>(nameof(DetailsBadge));
            DetailsAttributes = GetOrDefault<FFortMtxDetailsAttribute[]>(nameof(DetailsAttributes));
            Gradient = GetOrDefault<FFortMtxGradient>(nameof(Gradient));
            Background = GetOrDefault<FLinearColor>(nameof(Background));
            BackgroundImage = GetOrDefault<FSlateBrush>(nameof(BackgroundImage));
            UpsellPrimaryColor = GetOrDefault<FLinearColor>(nameof(UpsellPrimaryColor));
            UpsellSecondaryColor = GetOrDefault<FLinearColor>(nameof(UpsellSecondaryColor));
            UpsellTextColor = GetOrDefault<FLinearColor>(nameof(UpsellTextColor));
            bUseBaseColors = GetOrDefault<bool>(nameof(bUseBaseColors));
            DisplaySize = GetOrDefault<EFortMtxOfferDisplaySize>(nameof(DisplaySize));
        }
    }
}
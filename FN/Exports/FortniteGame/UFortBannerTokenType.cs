using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortBannerTokenType : UFortAccountItemDefinition
    {
        public EItemProfileType ProfileType;
        public string? BannerIconTemplateName;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ProfileType = GetOrDefault<EItemProfileType>(nameof(ProfileType));
            BannerIconTemplateName = GetOrDefault<string>(nameof(BannerIconTemplateName));
        }
    }
}
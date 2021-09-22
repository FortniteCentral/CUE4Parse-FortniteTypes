using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortCodeTokenItemDefinition : UFortAccountItemDefinition
    {
        public string? RedemptionCodeRule;
        public string? RedemptionCodeGroup;
        public ECodeTokenPlatform[]? AllowedPlatforms;
        public EItemProfileType ProfileType;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            RedemptionCodeRule = GetOrDefault<string>(nameof(RedemptionCodeRule));
            RedemptionCodeGroup = GetOrDefault<string>(nameof(RedemptionCodeGroup));
            AllowedPlatforms = GetOrDefault<ECodeTokenPlatform[]>(nameof(AllowedPlatforms));
            ProfileType = GetOrDefault<EItemProfileType>(nameof(ProfileType));
        }
    }
}
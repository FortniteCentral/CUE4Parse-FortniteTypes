using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortItemAccessTokenType : UFortAccountItemDefinition
    {
        public EItemProfileType ProfileType;
        public UFortItemDefinition? access_item;
        public FText? UnlockDescription;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ProfileType = GetOrDefault<EItemProfileType>(nameof(ProfileType));
            access_item = GetOrDefault<UFortItemDefinition>(nameof(access_item));
            UnlockDescription = GetOrDefault<FText>(nameof(UnlockDescription));
        }
    }
}
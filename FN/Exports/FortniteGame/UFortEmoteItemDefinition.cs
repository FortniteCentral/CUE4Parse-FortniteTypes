using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortEmoteItemDefinition : UFortMontageItemDefinitionBase
    {
        public FText? CommandName;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            CommandName = GetOrDefault<FText>(nameof(CommandName));
        }
    }
}
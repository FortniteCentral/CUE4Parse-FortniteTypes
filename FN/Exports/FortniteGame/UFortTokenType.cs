using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Structs.SlateCore;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortTokenType : UFortAccountItemDefinition
    {
        public FSoftObjectPath ScriptedAction; // UClass
        public FSlateColor? NodeTintColour;
        public bool bPercentageRepresentation;
        public EItemProfileType ProfileType;
        public FSoftObjectPath ItemPreviewActorClass; // UClass

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ScriptedAction = GetOrDefault<FSoftObjectPath>(nameof(ScriptedAction));
            NodeTintColour = GetOrDefault<FSlateColor>(nameof(NodeTintColour));
            bPercentageRepresentation = GetOrDefault<bool>(nameof(bPercentageRepresentation));
            ProfileType = GetOrDefault<EItemProfileType>(nameof(ProfileType));
            ItemPreviewActorClass = GetOrDefault<FSoftObjectPath>(nameof(ItemPreviewActorClass));
        }
    }
}
using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaCharacterPartItemDefinition : UAthenaCosmeticItemDefinition
    {
        public UCustomCharacterPart[]? CharacterParts;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            CharacterParts = GetOrDefault<UCustomCharacterPart[]>(nameof(CharacterParts));
        }
    }
}
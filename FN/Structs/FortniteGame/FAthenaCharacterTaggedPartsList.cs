using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FAthenaCharacterTaggedPartsList 
    {
        public FSoftObjectPath[]? Parts; // UCustomCharacterPart[]
        
        public FAthenaCharacterTaggedPartsList(FStructFallback fallback)
        {
            Parts = fallback.GetOrDefault<FSoftObjectPath[]>(nameof(Parts));
        }
    }
}
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCustomPartTextureParameter 
    {
        public int MaterialIndexForTextureParameter;
        public FName TextureParameterNameForMaterial;
        public FSoftObjectPath TextureOverride; // UTexture

        public FCustomPartTextureParameter(FStructFallback fallback)
        {
            MaterialIndexForTextureParameter = fallback.GetOrDefault<int>(nameof(MaterialIndexForTextureParameter));
            TextureParameterNameForMaterial = fallback.GetOrDefault<FName>(nameof(TextureParameterNameForMaterial));
            TextureOverride = fallback.GetOrDefault<FSoftObjectPath>(nameof(TextureOverride));
        }
    }
}
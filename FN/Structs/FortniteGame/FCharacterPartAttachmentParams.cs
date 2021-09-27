using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.FortniteGame
{
    [StructFallback]
    public class FCharacterPartAttachmentParams 
    {
        public FName SocketName;
        public ECharacterPartAttachmentTargetType AttachmentTarget;
        public FAttachToComponentParams AttachmentRules;

        public FCharacterPartAttachmentParams(FStructFallback fallback)
        {
            SocketName = fallback.GetOrDefault<FName>(nameof(SocketName));
            AttachmentTarget = fallback.GetOrDefault<ECharacterPartAttachmentTargetType>(nameof(AttachmentTarget));
            AttachmentRules = fallback.GetOrDefault<FAttachToComponentParams>(nameof(AttachmentRules));
        }
    }
}
using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaVehicleCosmeticItemDefinition : UAthenaCosmeticItemDefinition
    {
        public EFortVehicleDecoType DecoType;
        public FTransform DecoSocketTransform;
        public FSoftObjectPath TestDecoMesh; // UStaticMesh
        public FName DecoSocketName;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            DecoType = GetOrDefault<EFortVehicleDecoType>(nameof(DecoType));
            DecoSocketTransform = GetOrDefault<FTransform>(nameof(DecoSocketTransform));
            TestDecoMesh = GetOrDefault<FSoftObjectPath>(nameof(TestDecoMesh));
            DecoSocketName = GetOrDefault<FName>(nameof(DecoSocketName));
        }
    }
}
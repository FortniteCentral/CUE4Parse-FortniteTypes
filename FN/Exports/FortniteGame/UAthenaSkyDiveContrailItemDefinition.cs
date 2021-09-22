using CUE4Parse.FN.Structs.FortniteGame;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UAthenaSkyDiveContrailItemDefinition : UAthenaCosmeticItemDefinition
    {
        public FSoftObjectPath ContrailEffect; // UParticleSystem
        public FSoftObjectPath FrontEndContrailEffect; // UParticleSystem
        public FSoftObjectPath NiagaraContrailEffect; // UNiagaraSystem
        public FVector DefaultVelocityVector;
        public FName VelocityVectorParameterName;
        public FName ParaGlideLeanParameterName;
        public FVectorParticleParameter[]? VectorParameters;
        public FFloatParticleParameter[]? FloatParameters;
        public bool bWaitForFrontendSceneTransition;
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            ContrailEffect = GetOrDefault<FSoftObjectPath>(nameof(ContrailEffect));
            FrontEndContrailEffect = GetOrDefault<FSoftObjectPath>(nameof(FrontEndContrailEffect));
            NiagaraContrailEffect = GetOrDefault<FSoftObjectPath>(nameof(NiagaraContrailEffect));
            DefaultVelocityVector = GetOrDefault<FVector>(nameof(DefaultVelocityVector));
            VelocityVectorParameterName = GetOrDefault<FName>(nameof(VelocityVectorParameterName));
            ParaGlideLeanParameterName = GetOrDefault<FName>(nameof(ParaGlideLeanParameterName));
            VectorParameters = GetOrDefault<FVectorParticleParameter[]>(nameof(VectorParameters));
            FloatParameters = GetOrDefault<FFloatParticleParameter[]>(nameof(FloatParameters));
            bWaitForFrontendSceneTransition = GetOrDefault<bool>(nameof(bWaitForFrontendSceneTransition));
        }
    }
}
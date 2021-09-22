using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortWorkerType : UFortCharacterType
    {
        public EFortCustomGender Gender;
        public FSoftObjectPath FixedPortrait; // UFortItemIconDefinition
        public bool bIsManager;
        public FGameplayTagContainer ManagerSynergyTag;
        public FGameplayTagContainer FixedPersonalityTag;
        public FGameplayTagContainer FixedSetBonusTag;
        public int MatchingPersonalityBonus;
        public int MismatchingPersonalityPenalty;

        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);

            Gender = GetOrDefault<EFortCustomGender>(nameof(Gender));
            FixedPortrait = GetOrDefault<FSoftObjectPath>(nameof(FixedPortrait));
            bIsManager = GetOrDefault<bool>(nameof(bIsManager));
            ManagerSynergyTag = GetOrDefault<FGameplayTagContainer>(nameof(ManagerSynergyTag));
            FixedPersonalityTag = GetOrDefault<FGameplayTagContainer>(nameof(FixedPersonalityTag));
            FixedSetBonusTag = GetOrDefault<FGameplayTagContainer>(nameof(FixedSetBonusTag));
            MatchingPersonalityBonus = GetOrDefault<int>(nameof(MatchingPersonalityBonus));
            MismatchingPersonalityPenalty = GetOrDefault<int>(nameof(MismatchingPersonalityPenalty));
        }
    }
}
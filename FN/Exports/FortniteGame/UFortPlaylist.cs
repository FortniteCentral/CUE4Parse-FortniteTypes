using CUE4Parse.FN.Enums.FortniteGame;
using CUE4Parse.FN.Exports.FortniteGame.NoProperties;
using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Exports.FortniteGame
{
    public class UFortPlaylist : UFortDataAssetDirectoryPatchableAsset
    {
        public int PlaylistId;
        public FName PlaylistName;
        public EFortGameType GameType;
        public int MinPlayers;
        public int MaxPlayers;
        public bool bUnderfillMatchmaking;
        public int UnderfilledMaxPlayers;
        public bool bOverrideMaxPlayers;
        public int MaxHumanAndBotParticipants;
        public int MaxTeamCount;
        public int MaxTeamSize;
        public int MaxSocialPartySize;
        public int MaxSquadSize;
        public int MaxSquads;
        public bool EnforceSquadFill;
        public bool bAllowSquadFillOption;
        public bool bShouldFillWhenNoSquadFillOption;
        public bool bAllowJoinInProgress;
        public FText? JoinInProgressMatchType;
        public int EndOfMatchXpFirstElim;
        public int EndOfMatchXpMultiplier;
        public UPlaylistUserOptions? UserOptions;
        public bool bEnableBackfillDuringWarmupPhase;
        public float TimeAfterWarmupToDisableBackfill;
        public FName RichPresenceAssetName;
        public bool bAllowKeepPlayingTogether;
        public bool bAllowSquadSizeTracking;
        public FSoftObjectPath PreloadPersistentLevel; // UWorld
        public FSoftObjectPath[]? AdditionalLevels; // UWorld[]
        public FSoftObjectPath[]? AdditionalLevelsServerOnly; // UWorld[]
        // TODO: Finish
        
        public override void Deserialize(FAssetArchive Ar, long validPos)
        {
            base.Deserialize(Ar, validPos);
        }
    }
}
using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Shared.Administration
{
    [Serializable, NetSerializable]
    public record PlayerInfo(
        string Username,
        string CharacterName,
        string IdentityName,
        string StartingJob,
        bool Antag,
        bool Sponsor,
        EntityUid? EntityUid,
        NetUserId SessionId,
        bool Connected,
        bool ActiveThisRound);
}

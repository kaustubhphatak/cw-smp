using System;

namespace PhossSmp
{
    /// <summary>
    /// Direction of a participant migration.
    /// </summary>
    public enum EParticipantMigrationDirection
    {
        Outbound,
        Inbound
    }

    public static class EParticipantMigrationDirectionExtensions
    {
        public static string GetId(this EParticipantMigrationDirection dir) => dir switch
        {
            EParticipantMigrationDirection.Outbound => "outbound",
            EParticipantMigrationDirection.Inbound => "inbound",
            _ => string.Empty
        };

        public static bool IsOutbound(this EParticipantMigrationDirection dir) => dir == EParticipantMigrationDirection.Outbound;

        public static bool IsInbound(this EParticipantMigrationDirection dir) => dir == EParticipantMigrationDirection.Inbound;

        public static EParticipantMigrationDirection? FromIdOrNull(string? id)
        {
            if (id == null)
                return null;
            return id.Equals("outbound", StringComparison.OrdinalIgnoreCase) ? EParticipantMigrationDirection.Outbound :
                   id.Equals("inbound", StringComparison.OrdinalIgnoreCase) ? EParticipantMigrationDirection.Inbound : (EParticipantMigrationDirection?)null;
        }
    }
}

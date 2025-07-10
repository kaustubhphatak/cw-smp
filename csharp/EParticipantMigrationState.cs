using System;

namespace PhossSmp
{
    /// <summary>
    /// State of a participant migration.
    /// </summary>
    public enum EParticipantMigrationState
    {
        InProgress,
        Cancelled,
        Migrated
    }

    public static class EParticipantMigrationStateExtensions
    {
        public static string GetId(this EParticipantMigrationState state) => state switch
        {
            EParticipantMigrationState.InProgress => "inprogress",
            EParticipantMigrationState.Cancelled => "cancelled",
            EParticipantMigrationState.Migrated => "migrated",
            _ => string.Empty
        };

        public static string GetDisplayName(this EParticipantMigrationState state) => state switch
        {
            EParticipantMigrationState.InProgress => "In progress",
            EParticipantMigrationState.Cancelled => "Cancelled",
            EParticipantMigrationState.Migrated => "Migrated",
            _ => string.Empty
        };

        public static bool IsInProgress(this EParticipantMigrationState state) => state == EParticipantMigrationState.InProgress;

        public static bool PreventsNewMigration(this EParticipantMigrationState state) => state == EParticipantMigrationState.InProgress;

        public static bool IsOutboundState(this EParticipantMigrationState state) => true;

        public static bool IsInboundState(this EParticipantMigrationState state) => state == EParticipantMigrationState.Migrated;

        public static EParticipantMigrationState? FromIdOrNull(string? id)
        {
            if (id == null)
                return null;
            return id.Equals("inprogress", StringComparison.OrdinalIgnoreCase) ? EParticipantMigrationState.InProgress :
                   id.Equals("cancelled", StringComparison.OrdinalIgnoreCase) ? EParticipantMigrationState.Cancelled :
                   id.Equals("migrated", StringComparison.OrdinalIgnoreCase) ? EParticipantMigrationState.Migrated : (EParticipantMigrationState?)null;
        }
    }
}

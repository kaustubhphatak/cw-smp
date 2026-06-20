using System;

namespace PhossSmp
{
    /// <summary>
    /// Supported database types.
    /// Ported from the Java EDatabaseType enum.
    /// </summary>
    public enum EDatabaseType
    {
        Mysql,
        PostgreSql,
        Oracle,
        Db2
    }

    /// <summary>
    /// Extension methods for <see cref="EDatabaseType"/>.
    /// </summary>
    public static class EDatabaseTypeExtensions
    {
        public static string GetId(this EDatabaseType type) => type switch
        {
            EDatabaseType.Mysql => "mysql",
            EDatabaseType.PostgreSql => "postgresql",
            EDatabaseType.Oracle => "oracle",
            EDatabaseType.Db2 => "db2",
            _ => string.Empty
        };

        public static string GetDisplayName(this EDatabaseType type) => type switch
        {
            EDatabaseType.Mysql => "MySQL",
            EDatabaseType.PostgreSql => "PostgreSQL",
            EDatabaseType.Oracle => "Oracle",
            EDatabaseType.Db2 => "IBM DB2",
            _ => string.Empty
        };

        public static EDatabaseType? FromIdOrNull(string? id)
        {
            if (id == null)
                return null;
            return id.Equals("mysql", StringComparison.OrdinalIgnoreCase) ? EDatabaseType.Mysql :
                   id.Equals("postgresql", StringComparison.OrdinalIgnoreCase) ? EDatabaseType.PostgreSql :
                   id.Equals("oracle", StringComparison.OrdinalIgnoreCase) ? EDatabaseType.Oracle :
                   id.Equals("db2", StringComparison.OrdinalIgnoreCase) ? EDatabaseType.Db2 : (EDatabaseType?)null;
        }
    }
}

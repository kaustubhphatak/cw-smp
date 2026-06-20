using System.Globalization;

namespace PhossSmp
{
    /// <summary>
    /// Contains global SMP server constants.
    /// Ported from the Java CSMPServer class.
    /// </summary>
    public static class CSmpServer
    {
        public static readonly CultureInfo DefaultLocale = new CultureInfo("en-US");

        /// <summary>
        /// Regular expression pattern to validate the SMP ID.
        /// </summary>
        public const string PatternSmpId = "[a-zA-Z0-9\\-\\.]+";

        /// <summary>
        /// The default time zone used by the server.
        /// </summary>
        public const string DefaultTimezone = "UTC";

        public const string LogSuffixNoSmlInteraction = " (no SML interaction)";

        public const string SmpServerVersionFilename = "smp-server-version.properties";

        private static readonly string VersionNumber;
        private static readonly string Timestamp;

        static CSmpServer()
        {
            // TODO: Load version and timestamp from resources.
            VersionNumber = "0.0";
            Timestamp = string.Empty;
        }

        public static string GetVersionNumber() => VersionNumber;

        public static string GetBuildTimestamp() => Timestamp;
    }
}

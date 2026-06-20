using System;

namespace PhossSmp
{
    /// <summary>
    /// Defines the type of REST responses to be returned.
    /// Ported from the Java ESMPRESTType enum.
    /// </summary>
    public enum ESmpRestType
    {
        Peppol,
        OasisBdxrV1,
        OasisBdxrV2
    }

    /// <summary>
    /// Extension methods for <see cref="ESmpRestType"/> to provide behavior
    /// similar to the original Java enum.
    /// </summary>
    public static class ESmpRestTypeExtensions
    {
        public static string GetId(this ESmpRestType type) => type switch
        {
            ESmpRestType.Peppol => "peppol",
            ESmpRestType.OasisBdxrV1 => "bdxr",
            ESmpRestType.OasisBdxrV2 => "bdxr2",
            _ => string.Empty
        };

        public static string GetDisplayName(this ESmpRestType type) => type switch
        {
            ESmpRestType.Peppol => "Peppol",
            ESmpRestType.OasisBdxrV1 => "OASIS BDXR SMP v1",
            ESmpRestType.OasisBdxrV2 => "OASIS BDXR SMP v2",
            _ => string.Empty
        };

        public static ESmpApiType GetApiType(this ESmpRestType type) => type switch
        {
            ESmpRestType.Peppol => ESmpApiType.Peppol,
            ESmpRestType.OasisBdxrV1 => ESmpApiType.OasisBdxrV1,
            ESmpRestType.OasisBdxrV2 => ESmpApiType.OasisBdxrV2,
            _ => ESmpApiType.Peppol
        };

        public static bool IsPeppol(this ESmpRestType type) => type == ESmpRestType.Peppol;

        public static bool IsBdxr(this ESmpRestType type) => type == ESmpRestType.OasisBdxrV1 || type == ESmpRestType.OasisBdxrV2;

        public static bool IsCompleteServiceGroupSupported(this ESmpRestType type) => type == ESmpRestType.Peppol || type == ESmpRestType.OasisBdxrV1;

        public static bool IsHttpAlsoAllowed(this ESmpRestType type) => type == ESmpRestType.Peppol;

        public static string GetQueryPathPrefix(this ESmpRestType type) => type == ESmpRestType.OasisBdxrV2 ? "bdxr-smp-2/" : string.Empty;

        public static ESmpRestType? GetFromIdOrNull(string? id) => id switch
        {
            "peppol" => ESmpRestType.Peppol,
            "bdxr" => ESmpRestType.OasisBdxrV1,
            "bdxr2" => ESmpRestType.OasisBdxrV2,
            _ => null
        };

        public static ESmpRestType GetFromIdOrDefault(string? id, ESmpRestType defaultValue) => GetFromIdOrNull(id) ?? defaultValue;
    }
}

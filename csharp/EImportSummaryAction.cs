namespace PhossSmp
{
    /// <summary>
    /// Possible actions in an import summary.
    /// Ported from the Java EImportSummaryAction enum.
    /// </summary>
    public enum EImportSummaryAction
    {
        DeleteServiceGroup,
        CreateServiceGroup,
        CreateServiceInfo,
        CreateRedirect,
        CreateBusinessCard,
        DeleteBusinessCard
    }

    public static class EImportSummaryActionExtensions
    {
        public static string GetId(this EImportSummaryAction action) => action switch
        {
            EImportSummaryAction.DeleteServiceGroup => "delete-servicegroup",
            EImportSummaryAction.CreateServiceGroup => "create-servicegroup",
            EImportSummaryAction.CreateServiceInfo => "create-serviceinfo",
            EImportSummaryAction.CreateRedirect => "create-redirect",
            EImportSummaryAction.CreateBusinessCard => "create-business-card",
            EImportSummaryAction.DeleteBusinessCard => "delete-business-card",
            _ => string.Empty
        };
    }
}

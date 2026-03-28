namespace SunamoWikipedia._sunamo.SunamoValues.Values;

/// <summary>
/// Contains constants for ASPX and HTML comment delimiters.
/// </summary>
internal class ConstsAspx
{
    /// <summary>Start delimiter for ASPX comments.</summary>
    internal static string StartAspxComment { get; } = "<%--";

    /// <summary>End delimiter for ASPX comments.</summary>
    internal static string EndAspxComment { get; } = "--%>";

    /// <summary>Start delimiter for HTML comments.</summary>
    internal static string StartHtmlComment { get; } = "<!--";

    /// <summary>End delimiter for HTML comments.</summary>
    internal static string EndHtmlComment { get; } = "-->";

    /// <summary>Collection of all comment delimiters and angle brackets.</summary>
    internal static List<string> All { get; } = new List<string>([StartAspxComment, EndAspxComment, StartHtmlComment, EndHtmlComment, ">", "<"]);
}

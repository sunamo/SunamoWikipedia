namespace SunamoWikipedia._sunamo.SunamoValues.Values;

internal class ConstsAspx
{
    internal static string StartAspxComment { get; } = "<%--";

    internal static string EndAspxComment { get; } = "--%>";

    internal static string StartHtmlComment { get; } = "<!--";

    internal static string EndHtmlComment { get; } = "-->";

    internal static List<string> All { get; } = new List<string>([StartAspxComment, EndAspxComment, StartHtmlComment, EndHtmlComment, ">", "<"]);
}

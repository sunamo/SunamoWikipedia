namespace SunamoWikipedia._sunamo.SunamoHtml;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
/// <summary>
/// Protože klasický HtmlAgilityHelper chce HtmlHelper který má miliardu deps
/// </summary>
internal class HtmlAgilityHelper
{
#pragma warning disable IDE0060

    internal static HtmlDocument CreateHtmlDocument()
    {
        ThrowEx.NotImplementedMethod();
        return null;
    }

    internal static List<HtmlNode> Nodes(object item, bool v1, string v2)
    {
        ThrowEx.NotImplementedMethod();
        return null;
    }

    internal static IEnumerable<object> NodesWhichContainsInAttr(object documentNode, bool v1, string v2, string v3, string v4)
    {
        ThrowEx.NotImplementedMethod();
        return null;
    }

    internal static List<HtmlNode> NodesWithAtstr(HtmlNode mwParserOutputNode, bool v1, string v2, string v3, string v4)
    {
        ThrowEx.NotImplementedMethod();
        return null;
    }


    internal static HtmlNode NodeWithAttr(object documentNode, bool v1, string v2, string v3, string v4)
    {
        ThrowEx.NotImplementedMethod();
        return null;
    }
#pragma warning restore IDE0060
}
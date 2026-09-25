namespace SunamoWikipedia._sunamo.SunamoHtml;

// Lightweight HTML Agility Pack helper to avoid heavy dependencies from the full HtmlHelper.
internal class HtmlAgilityHelper
{
#pragma warning disable IDE0060

    internal static HtmlDocument CreateHtmlDocument()
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    internal static List<HtmlNode> Nodes(object parentNode, bool isRecursive, string tagName)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    internal static IEnumerable<object> NodesWhichContainsInAttr(object documentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    internal static List<HtmlNode> NodesWithAtstr(HtmlNode parentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    internal static HtmlNode NodeWithAttr(object documentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

#pragma warning restore IDE0060
}

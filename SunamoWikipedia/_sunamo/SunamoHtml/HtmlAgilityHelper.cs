namespace SunamoWikipedia._sunamo.SunamoHtml;

/// <summary>
/// Lightweight HTML Agility Pack helper to avoid heavy dependencies from the full HtmlHelper.
/// </summary>
internal class HtmlAgilityHelper
{
#pragma warning disable IDE0060

    /// <summary>
    /// Creates a new HTML document instance.
    /// </summary>
    /// <returns>A new <see cref="HtmlDocument"/> instance.</returns>
    internal static HtmlDocument CreateHtmlDocument()
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    /// <summary>
    /// Finds child nodes matching the specified tag name.
    /// </summary>
    /// <param name="parentNode">The parent node to search within.</param>
    /// <param name="isRecursive">Whether to search recursively.</param>
    /// <param name="tagName">The HTML tag name to match.</param>
    /// <returns>A list of matching HTML nodes.</returns>
    internal static List<HtmlNode> Nodes(object parentNode, bool isRecursive, string tagName)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    /// <summary>
    /// Finds nodes whose attribute value contains the specified text.
    /// </summary>
    /// <param name="documentNode">The root document node to search within.</param>
    /// <param name="isRecursive">Whether to search recursively.</param>
    /// <param name="tagName">The HTML tag name to match.</param>
    /// <param name="attributeName">The attribute name to inspect.</param>
    /// <param name="attributeValue">The attribute value to search for.</param>
    /// <returns>An enumerable of matching objects.</returns>
    internal static IEnumerable<object> NodesWhichContainsInAttr(object documentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    /// <summary>
    /// Finds nodes with an attribute matching the specified value exactly.
    /// </summary>
    /// <param name="parentNode">The parent node to search within.</param>
    /// <param name="isRecursive">Whether to search recursively.</param>
    /// <param name="tagName">The HTML tag name to match.</param>
    /// <param name="attributeName">The attribute name to inspect.</param>
    /// <param name="attributeValue">The attribute value to match.</param>
    /// <returns>A list of matching HTML nodes.</returns>
    internal static List<HtmlNode> NodesWithAtstr(HtmlNode parentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

    /// <summary>
    /// Finds a single node with an attribute matching the specified value.
    /// </summary>
    /// <param name="documentNode">The root document node to search within.</param>
    /// <param name="isRecursive">Whether to search recursively.</param>
    /// <param name="tagName">The HTML tag name to match.</param>
    /// <param name="attributeName">The attribute name to inspect.</param>
    /// <param name="attributeValue">The attribute value to match.</param>
    /// <returns>The first matching HTML node.</returns>
    internal static HtmlNode NodeWithAttr(object documentNode, bool isRecursive, string tagName, string attributeName, string attributeValue)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

#pragma warning restore IDE0060
}

namespace SunamoWikipedia._public.SunamoHtml.Html;

/// <summary>
/// Parses HTML tables from Wikipedia pages into structured data.
/// </summary>
public class HtmlTableParserWiki
{
#pragma warning disable IDE0060

    /// <summary>
    /// Initializes a new instance of the <see cref="HtmlTableParserWiki"/> class.
    /// </summary>
    /// <param name="tableNode">The HTML table node to parse.</param>
    /// <param name="isIncludingHeaders">Whether to include header rows in the parsed output.</param>
    public HtmlTableParserWiki(object tableNode, bool isIncludingHeaders)
    {
    }

    /// <summary>
    /// Gets the values of a specific column from the parsed table.
    /// </summary>
    /// <param name="columnName">The name of the column to retrieve values from.</param>
    /// <param name="isTrimming">Whether to trim whitespace from the values.</param>
    /// <param name="isDecodingHtml">Whether to HTML-decode the values.</param>
    /// <returns>A list of column values as strings.</returns>
    public List<string> ColumnValues(string columnName, bool isTrimming, bool isDecodingHtml)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

#pragma warning restore IDE0060
}

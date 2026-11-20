namespace SunamoWikipedia._public.SunamoHtml.Html;

/// <summary>
/// Represents the html table parser wiki type.
/// </summary>
public class HtmlTableParserWiki
{
#pragma warning disable IDE0060

    /// <summary>
    /// Initializes a new instance of the html table parser wiki class.
    /// </summary>
    /// <param name="tableNode">The table node.</param>
    /// <param name="isIncludingHeaders">The is including headers.</param>
    public HtmlTableParserWiki(object tableNode, bool isIncludingHeaders)
    {
    }

    /// <summary>
    /// Column values.
    /// </summary>
    /// <param name="columnName">The column name.</param>
    /// <param name="isTrimming">The is trimming.</param>
    /// <param name="isDecodingHtml">The is decoding html.</param>
    /// <returns>The column values result.</returns>
    public List<string> ColumnValues(string columnName, bool isTrimming, bool isDecodingHtml)
    {
        ThrowEx.NotImplementedMethod();
        return null!;
    }

#pragma warning restore IDE0060
}

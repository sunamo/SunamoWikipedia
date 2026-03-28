namespace SunamoWikipedia;

/// <summary>
/// Provides methods for parsing Wikipedia HTML content including tables and lists.
/// </summary>
public class WikipediaHelper
{
    private const string Character = "Character";
    private const string Names = "Names";

    /// <summary>
    /// Parses an HTML entities list from Wikipedia and returns formatted dictionary values.
    /// </summary>
    /// <param name="dictionaryValuesFormatter">A function that takes names and characters lists and returns a formatted string.</param>
    /// <returns>A formatted string of HTML entity dictionary values.</returns>
    public static string HtmlEntitiesList(
        Func<List<string>, List<string>, string> dictionaryValuesFormatter)
    {
        var html = string.Empty;

        var tables = ParseTable(html, Character, Names);

        var table = tables.First();

        var characters = table.ColumnValues(Character, true, false);
        var names = table.ColumnValues(Names, true, true);

        return dictionaryValuesFormatter(names, characters);
    }

    /// <summary>
    /// Parses HTML content and extracts Wikipedia tables that contain the specified columns.
    /// </summary>
    /// <param name="html">The HTML content to parse.</param>
    /// <param name="columnNames">The column names that the table must contain.</param>
    /// <returns>A list of parsed Wikipedia table objects.</returns>
    public static List<HtmlTableParserWiki> ParseTable(string html, params string[] columnNames)
    {
        var parsedTables = new List<HtmlTableParserWiki>();
        var htmlDocument = HtmlAgilityHelper.CreateHtmlDocument();
        htmlDocument.LoadHtml(html);

        var subNodes = HtmlAgilityHelper.NodesWhichContainsInAttr(htmlDocument.DocumentNode, true, "*", "class", "wikitable");

        foreach (var item in subNodes)
        {
            var headerNodes = HtmlAgilityHelper.Nodes(item, true, "th");

            var headers = new List<string>(headerNodes.Count);
            foreach (var headerNode in headerNodes)
            {
                headers.Add(headerNode.InnerText.Trim());
            }

            var isRightTable = true;

            foreach (var columnName in columnNames)
            {
                if (!headers.Contains(columnName))
                {
                    isRightTable = false;
                }
            }

            if (isRightTable)
            {
                var tableParser = new HtmlTableParserWiki(item, false);
                parsedTables.Add(tableParser);
            }
        }

        return parsedTables;
    }

    /// <summary>
    /// Parses a Wikipedia page containing a list structure and extracts all anchor text values.
    /// </summary>
    /// <param name="html">The HTML content to parse.</param>
    /// <returns>A list of extracted text values from anchors.</returns>
    public static List<string> ParseList(string html)
    {
        var htmlDocument = HtmlAgilityHelper.CreateHtmlDocument();

        htmlDocument.LoadHtml(html);

        var parserOutputNode =
            HtmlAgilityHelper.NodeWithAttr(htmlDocument.DocumentNode, true, "*", "class", "mw-parser-output");

        var subNodes =
            HtmlAgilityHelper.NodesWithAtstr(parserOutputNode, false, "*", "class", "div-col columns column-width");

        var result = new List<string>();

        foreach (var item in subNodes)
        {
            var anchors = HtmlAgilityHelper.Nodes(item, true, "a");

            foreach (var anchor in anchors)
            {
                result.Add(anchor.InnerText.Trim());
            }
        }

        return result;
    }
}

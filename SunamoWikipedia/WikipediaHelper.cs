namespace SunamoWikipedia;

public class WikipediaHelper
{
    private const string Character = "Character";
    private const string Names = "Names";

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

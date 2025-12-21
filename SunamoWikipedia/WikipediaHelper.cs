namespace SunamoWikipedia;

public class WikipediaHelper
{
    private const string Character = "Character";
    private const string Names = "Names";

    public static string HtmlEntitiesList(
        Func<List<string>, List<string>, string> CSharpHelperGetDictionaryValuesFromTwoList)
    {
        var count = string.Empty;
        //c = File.ReadAllTextAsync(@"D:\_Test\sunamo\shared\WikipediaHelper\ParseTable.html");

        var tables = ParseTable(count, Character, Names);

        var table = tables.First();

        var chars = table.ColumnValues(Character, true, false);
        var names = table.ColumnValues(Names, true, true);

        return CSharpHelperGetDictionaryValuesFromTwoList(names, chars);
    }

    /// <param name="html"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    public static List<HtmlTableParserWiki> ParseTable(string html, params string[] columns)
    {
        var htmls = new List<HtmlTableParserWiki>();
        var hd = HtmlAgilityHelper.CreateHtmlDocument();
        hd.LoadHtml(html);

        //var mwParserOutputNode = HtmlAgilityHelper.NodeWithAttr(hd.DocumentNode, true, "*", "class", "mw-parser-output");

        var subNodes = HtmlAgilityHelper.NodesWhichContainsInAttr(hd.DocumentNode, true, "*", "class", "wikitable");

        var result = new List<string>();

        foreach (var item in subNodes)
        {
            var theads = HtmlAgilityHelper.Nodes(item, true, "th");

            var headers = new List<string>(theads.Count);
            foreach (var th in theads) headers.Add(th.InnerText.Trim());

            var rightTable = true;

            foreach (var item2 in columns)
                if (!headers.Contains(item2))
                    rightTable = false;

            if (rightTable)
            {
                var tp = new HtmlTableParserWiki(item, false);

                htmls.Add(tp);
            }
        }

        return htmls;
    }

    /// <summary>
    ///     Dont know for what page it was used
    ///     I try to find with several page
    /// </summary>
    /// <param name="html"></param>
    /// <returns></returns>
    public static List<string> ParseList(string html)
    {
        var hd = HtmlAgilityHelper.CreateHtmlDocument();

        hd.LoadHtml(html);

        var mwParserOutputNode =
            HtmlAgilityHelper.NodeWithAttr(hd.DocumentNode, true, "*", "class", "mw-parser-output");

        var subNodes =
            HtmlAgilityHelper.NodesWithAtstr(mwParserOutputNode, false, "*", "class", "div-col columns column-width");

        var result = new List<string>();

        foreach (var item in subNodes)
        {
            var anchors = HtmlAgilityHelper.Nodes(item, true, "a");

            foreach (var anchor in anchors) result.Add(anchor.InnerText.Trim());
        }

        return result;
    }
}
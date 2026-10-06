namespace SunamoWikipedia._sunamo.SunamoRegex;

internal static class RegexHelper
{
    internal static Regex HtmlScript { get; } = new Regex(@"<script[^>]*>[\s\S]*?</script>", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    internal static Regex HtmlComment { get; } = new Regex(@"<!--[^>]*>[\s\S]*?-->", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    internal static Regex YtVideoLink { get; } = new Regex("youtu(?:\\.be|be\\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.Compiled);

    internal static Regex BrTagCaseInsensitive { get; } = new Regex(@"<br\s*/?>");

    internal static Regex Uri { get; } = new Regex(@"(https?://[^\s]+)");

    internal static Regex HtmlTag { get; } = new Regex("<\\s*([A-Za-z])*?[^>]*/?>");

    internal static Regex Color6 { get; } = new Regex(@"^(?:[0-9a-fA-F]{3}){1,2}$");

    internal static Regex Color8 { get; } = new Regex(@"^(?:[0-9a-fA-F]{3}){1,2}(?:[0-9a-fA-F]){2}$");

    internal static Regex PreTagWithContent { get; } = new Regex(@"<\s*pre[^>]*>(.*?)<\s*/\s*pre>", RegexOptions.Multiline);

    internal static Regex IsGuid { get; } = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);

    internal static Regex ImgTag { get; } = new Regex(@"<img\s+([^>]*)(.*?)[^>]*>");

    internal static Regex WpImgThumbnail { get; } = new Regex(@"(https?:\/\/([^\s]+)-([0-9]*)x([0-9]*).jpg)");

    internal static Regex NonPairXmlTagsUnvalid { get; } = new Regex("<(?:\"[^\"]*\"['\"]*|'[^']*'['\"]*|[^'\">])+>");

    internal static Regex Whitespace { get; } = new Regex(@"\s+");
}

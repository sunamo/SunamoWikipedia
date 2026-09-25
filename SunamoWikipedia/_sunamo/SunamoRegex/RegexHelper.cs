namespace SunamoWikipedia._sunamo.SunamoRegex;

/// <summary>
/// Provides precompiled regular expressions for common HTML and URI pattern matching.
/// </summary>
internal static class RegexHelper
{
    /// <summary>
    /// Matches HTML script tags and their content.
    /// </summary>
    internal static Regex HtmlScript { get; } = new Regex(@"<script[^>]*>[\s\S]*?</script>", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    /// <summary>
    /// Matches HTML comments.
    /// </summary>
    internal static Regex HtmlComment { get; } = new Regex(@"<!--[^>]*>[\s\S]*?-->", RegexOptions.IgnoreCase | RegexOptions.Compiled);

    /// <summary>
    /// Matches YouTube video links and captures the video ID.
    /// </summary>
    internal static Regex YtVideoLink { get; } = new Regex("youtu(?:\\.be|be\\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.Compiled);

    /// <summary>
    /// Matches BR tags in any casing.
    /// </summary>
    internal static Regex BrTagCaseInsensitive { get; } = new Regex(@"<br\s*/?>");

    /// <summary>
    /// Matches URIs starting with http or https.
    /// </summary>
    internal static Regex Uri { get; } = new Regex(@"(https?://[^\s]+)");

    /// <summary>
    /// Matches HTML tags.
    /// </summary>
    internal static Regex HtmlTag { get; } = new Regex("<\\s*([A-Za-z])*?[^>]*/?>");

    /// <summary>
    /// Matches 6-character hex color codes.
    /// </summary>
    internal static Regex Color6 { get; } = new Regex(@"^(?:[0-9a-fA-F]{3}){1,2}$");

    /// <summary>
    /// Matches 8-character hex color codes (with alpha).
    /// </summary>
    internal static Regex Color8 { get; } = new Regex(@"^(?:[0-9a-fA-F]{3}){1,2}(?:[0-9a-fA-F]){2}$");

    /// <summary>
    /// Matches pre tags and their content.
    /// </summary>
    internal static Regex PreTagWithContent { get; } = new Regex(@"<\s*pre[^>]*>(.*?)<\s*/\s*pre>", RegexOptions.Multiline);

    /// <summary>
    /// Matches GUID format strings.
    /// </summary>
    internal static Regex IsGuid { get; } = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);

    /// <summary>
    /// Matches img tags and their attributes.
    /// </summary>
    internal static Regex ImgTag { get; } = new Regex(@"<img\s+([^>]*)(.*?)[^>]*>");

    /// <summary>
    /// Matches WordPress image thumbnail URLs.
    /// </summary>
    internal static Regex WpImgThumbnail { get; } = new Regex(@"(https?:\/\/([^\s]+)-([0-9]*)x([0-9]*).jpg)");

    /// <summary>
    /// Matches non-pair XML tags that may be invalid.
    /// </summary>
    internal static Regex NonPairXmlTagsUnvalid { get; } = new Regex("<(?:\"[^\"]*\"['\"]*|'[^']*'['\"]*|[^'\">])+>");

    /// <summary>
    /// Matches one or more whitespace characters.
    /// </summary>
    internal static Regex Whitespace { get; } = new Regex(@"\s+");
}

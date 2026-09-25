namespace SunamoWikipedia._sunamo.SunamoInterfaces.Interfaces;

/// <summary>
/// Defines methods for generating XML content programmatically.
/// </summary>
internal interface IXmlGenerator
{
    /// <summary>
    /// Appends a new line to the output.
    /// </summary>
    void AppendLine();

    /// <summary>
    /// Ends a comment block in the output.
    /// </summary>
    void EndComment();

    /// <summary>
    /// Inserts text at the specified index position.
    /// </summary>
    /// <param name="index">The zero-based position to insert at.</param>
    /// <param name="text">The text to insert.</param>
    void Insert(int index, string text);

    /// <summary>
    /// Gets the current length of the generated output.
    /// </summary>
    /// <returns>The length of the output.</returns>
    int Length();

    /// <summary>
    /// Starts a comment block in the output.
    /// </summary>
    void StartComment();

    /// <summary>
    /// Writes a closing tag for the specified tag name.
    /// </summary>
    /// <param name="tagName">The name of the tag to close.</param>
    void TerminateTag(string tagName);

    /// <summary>
    /// Returns the generated XML content as a string.
    /// </summary>
    /// <returns>The XML content string.</returns>
    string ToString();

    /// <summary>
    /// Writes a CDATA section with the specified content.
    /// </summary>
    /// <param name="innerCData">The content to wrap in CDATA.</param>
    void WriteCData(string innerCData);

    /// <summary>
    /// Writes an element with the specified name and inner content.
    /// </summary>
    /// <param name="elementName">The name of the element.</param>
    /// <param name="innerContent">The inner content of the element.</param>
    void WriteElement(string elementName, string innerContent);

    /// <summary>
    /// Writes a self-closing tag without attributes.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    void WriteNonPairTag(string tagName);

    /// <summary>
    /// Writes a self-closing tag with two attributes.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="firstAttributeName">The name of the first attribute.</param>
    /// <param name="firstAttributeValue">The value of the first attribute.</param>
    /// <param name="secondAttributeName">The name of the second attribute.</param>
    /// <param name="secondAttributeValue">The value of the second attribute.</param>
    void WriteNonPairTagWith2Attrs(string tagName, string firstAttributeName, string firstAttributeValue, string secondAttributeName, string secondAttributeValue);

    /// <summary>
    /// Writes a self-closing tag with a single attribute.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributeName">The attribute name.</param>
    /// <param name="attributeValue">The attribute value.</param>
    void WriteNonPairTagWithAttr(string tagName, string attributeName, string attributeValue);

    /// <summary>
    /// Writes a self-closing tag with attributes, optionally appending null values.
    /// </summary>
    /// <param name="isAppendingNull">Whether to append null attribute values.</param>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The attribute name-value pairs.</param>
    void WriteNonPairTagWithAttrs(bool isAppendingNull, string tagName, params string[] attributes);

    /// <summary>
    /// Writes a self-closing tag with attributes from a list.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The list of attribute name-value pairs.</param>
    void WriteNonPairTagWithAttrs(string tagName, List<string> attributes);

    /// <summary>
    /// Writes a self-closing tag with attributes from a params array.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The attribute name-value pairs.</param>
    void WriteNonPairTagWithAttrs(string tagName, params string[] attributes);

    /// <summary>
    /// Writes raw content without encoding.
    /// </summary>
    /// <param name="rawContent">The raw content to write.</param>
    void WriteRaw(string rawContent);

    /// <summary>
    /// Writes an opening tag.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    void WriteTag(string tagName);

    /// <summary>
    /// Writes a tag with namespace manager support using an element object.
    /// </summary>
    /// <param name="element">The element to write.</param>
    /// <param name="namespaceManager">The XML namespace manager.</param>
    /// <param name="namespaceUri">The namespace URI.</param>
    /// <param name="prefix">The namespace prefix.</param>
    void WriteTagNamespaceManager(object element, XmlNamespaceManager namespaceManager, string namespaceUri, string prefix);

    /// <summary>
    /// Writes a tag with namespace manager support and attributes.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="namespaceManager">The XML namespace manager.</param>
    /// <param name="attributes">The attribute name-value pairs.</param>
    void WriteTagNamespaceManager(string tagName, XmlNamespaceManager namespaceManager, params string[] attributes);

    /// <summary>
    /// Writes a tag with two attributes.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="firstAttributeName">The name of the first attribute.</param>
    /// <param name="firstAttributeValue">The value of the first attribute.</param>
    /// <param name="secondAttributeName">The name of the second attribute.</param>
    /// <param name="secondAttributeValue">The value of the second attribute.</param>
    void WriteTagWith2Attrs(string tagName, string firstAttributeName, string firstAttributeValue, string secondAttributeName, string secondAttributeValue);

    /// <summary>
    /// Writes a tag with a single attribute.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributeName">The attribute name.</param>
    /// <param name="attributeValue">The attribute value.</param>
    /// <param name="isSkippingEmptyOrNull">Whether to skip the tag if the attribute value is empty or null.</param>
    void WriteTagWithAttr(string tagName, string attributeName, string attributeValue, bool isSkippingEmptyOrNull = false);

    /// <summary>
    /// Writes a tag with attributes from a list.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The list of attribute name-value pairs.</param>
    void WriteTagWithAttrs(string tagName, List<string> attributes);

    /// <summary>
    /// Writes a tag with attributes from a params array.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The attribute name-value pairs.</param>
    void WriteTagWithAttrs(string tagName, params string[] attributes);

    /// <summary>
    /// Writes a tag with attributes, checking for null values before writing.
    /// </summary>
    /// <param name="tagName">The name of the tag.</param>
    /// <param name="attributes">The attribute name-value pairs.</param>
    void WriteTagWithAttrsCheckNull(string tagName, params string[] attributes);

    /// <summary>
    /// Writes an XML declaration header.
    /// </summary>
    void WriteXmlDeclaration();
}

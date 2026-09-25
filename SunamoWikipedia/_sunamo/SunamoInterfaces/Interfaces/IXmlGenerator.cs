namespace SunamoWikipedia._sunamo.SunamoInterfaces.Interfaces;

internal interface IXmlGenerator
{
    void AppendLine();

    void EndComment();

    void Insert(int index, string text);

    int Length();

    void StartComment();

    void TerminateTag(string tagName);

    string ToString();

    void WriteCData(string innerCData);

    void WriteElement(string elementName, string innerContent);

    void WriteNonPairTag(string tagName);

    void WriteNonPairTagWith2Attrs(string tagName, string firstAttributeName, string firstAttributeValue, string secondAttributeName, string secondAttributeValue);

    void WriteNonPairTagWithAttr(string tagName, string attributeName, string attributeValue);

    void WriteNonPairTagWithAttrs(bool isAppendingNull, string tagName, params string[] attributes);

    void WriteNonPairTagWithAttrs(string tagName, List<string> attributes);

    void WriteNonPairTagWithAttrs(string tagName, params string[] attributes);

    void WriteRaw(string rawContent);

    void WriteTag(string tagName);

    void WriteTagNamespaceManager(object element, XmlNamespaceManager namespaceManager, string namespaceUri, string prefix);

    void WriteTagNamespaceManager(string tagName, XmlNamespaceManager namespaceManager, params string[] attributes);

    void WriteTagWith2Attrs(string tagName, string firstAttributeName, string firstAttributeValue, string secondAttributeName, string secondAttributeValue);

    void WriteTagWithAttr(string tagName, string attributeName, string attributeValue, bool isSkippingEmptyOrNull = false);

    void WriteTagWithAttrs(string tagName, List<string> attributes);

    void WriteTagWithAttrs(string tagName, params string[] attributes);

    void WriteTagWithAttrsCheckNull(string tagName, params string[] attributes);

    void WriteXmlDeclaration();
}

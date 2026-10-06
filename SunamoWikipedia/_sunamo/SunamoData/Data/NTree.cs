namespace SunamoWikipedia._sunamo.SunamoData.Data;

// Another popular tree implementation is at https://www.codeproject.com/Articles/12592/Generic-Tree-T-in-C
internal class NTree<T>
{
    internal T Data { get; set; }
    internal LinkedList<NTree<T>> Children { get; set; }

    internal NTree(T data)
    {
        Data = data;
        Children = new LinkedList<NTree<T>>();
    }

    internal void Traverse(NTree<T> node, Action<T> visitor)
    {
        visitor(node.Data);
        foreach (NTree<T> child in node.Children)
        {
            Traverse(child, visitor);
        }
    }
}

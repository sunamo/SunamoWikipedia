namespace SunamoWikipedia._sunamo.SunamoData.Data;

/// <summary>
/// Generic N-ary tree data structure.
/// Another popular tree implementation is at https://www.codeproject.com/Articles/12592/Generic-Tree-T-in-C
/// </summary>
/// <typeparam name="T">The type of data stored in each tree node.</typeparam>
internal class NTree<T>
{
    /// <summary>
    /// Gets or sets the data stored in this node.
    /// </summary>
    internal T Data { get; set; }

    /// <summary>
    /// Gets or sets the children of this node.
    /// </summary>
    internal LinkedList<NTree<T>> Children { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NTree{T}"/> class with the specified data.
    /// </summary>
    /// <param name="data">The data to store in the node.</param>
    internal NTree(T data)
    {
        Data = data;
        Children = new LinkedList<NTree<T>>();
    }

    /// <summary>
    /// Traverses the tree starting from the specified node, invoking the visitor on each node's data.
    /// </summary>
    /// <param name="node">The starting node for traversal.</param>
    /// <param name="visitor">The action to invoke on each node's data.</param>
    internal void Traverse(NTree<T> node, Action<T> visitor)
    {
        visitor(node.Data);
        foreach (NTree<T> child in node.Children)
        {
            Traverse(child, visitor);
        }
    }
}

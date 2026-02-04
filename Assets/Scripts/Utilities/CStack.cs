public class CStack<T>
{
    private CNode<T> _head;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public void AddElement(T element)
    {
        CNode<T> node = new CNode<T>(element);
        node.Next = _head;
        _head = node;
        _count += 1;
    }

    public T TakeElement()
    {
        CNode<T> tempNode = _head;
        _head = tempNode.Next;
        _count -= 1;
        return tempNode.Data;
    }

    public T GetHeadElement()
    {
        return _head.Data;
    }
}
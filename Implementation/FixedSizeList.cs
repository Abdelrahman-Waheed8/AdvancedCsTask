public class FixedSizeList<T>
{
    public T[] list;
    public int _capacity {get; private set;}
    public int _count {get; private set;}

    public FixedSizeList(int capacity)
    {
        if(capacity <=0) throw new Exception("Capacity must be greater than zero");
        _capacity = capacity;
        _count = 0;
        list = new T[capacity];
    }

    public void Add(T item)
    {
        if(_count >= _capacity) throw new Exception("List is already full.");
        list[_count] = item;
        _count++;
    }

    public T GetAt(int index)
    {
        if(index >= _count) throw new Exception("Index out of range.");
        return list[index];
    }

    public T this[int index]
    {
        get
        {
            if(index >= _count) throw new Exception("Index out of range.");
            return list[index];
        }
        set
        {
            if(index >= _capacity) throw new Exception("Index out of range.");
            list[index] = value;
        }
    }
}
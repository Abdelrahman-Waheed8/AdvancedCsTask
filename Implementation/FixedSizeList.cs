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

    public static void Run()
    {
        Console.Write("Enter Fixed Size List capacity: ");
        int cap;

        while(!int.TryParse(Console.ReadLine(), out cap))
        {
            Console.Write("Invalid input Enter Fixed Size List capacity: ");
        }

        FixedSizeList<int> list = new FixedSizeList<int>(cap);
        Console.WriteLine("Created fixed size list with capacity of: " + cap);

        Console.WriteLine("Enter Fixed size list elements: ");
        for(int i = 0; i < cap; i++)
        {
            Console.Write($"Enter item {i+1}: ");
            int item;
            while(!int.TryParse(Console.ReadLine(), out item))
            {
                Console.Write("Enter valid item: ");
            }
            list.Add(item);
        }

        Console.WriteLine("Inputted elements: ");
        for(int i = 0; i < cap; i++)
        {
            Console.WriteLine(list[i]);
        }

        try
        {
            list.Add(15);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
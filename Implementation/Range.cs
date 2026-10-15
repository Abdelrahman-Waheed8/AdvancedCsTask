public class Range<T> where T : IComparable<T>
{
    public T _min;
    public T _max;
    public Range(T min, T max)
    {
        _min = min;
        _max = max;
    }

    public bool IsInRange(T value)
    {
        if(value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0) return true;
        return false;
    }

    public T Length()
    {
        return (dynamic)_max - (dynamic)_min;
    }
}
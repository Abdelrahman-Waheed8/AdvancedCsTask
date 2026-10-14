public class Question2
{
    public static List<int> EvenInList(List<int> input)
    {
        List<int> evenOnly = new List<int>();
        foreach(int item in input)
        {
            if(item % 2 == 0) evenOnly.Add(item);
        }
        return evenOnly;
    }
}
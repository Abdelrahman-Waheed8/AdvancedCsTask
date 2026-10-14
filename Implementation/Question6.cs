using System.Collections;

public class Question6
{
    public static void RemoveOdd(ArrayList arr)
    {
        if(arr == null) return;

        foreach(int item in arr)
        {
            if(item % 2 != 0) arr.Remove(item);
        }
        foreach(int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
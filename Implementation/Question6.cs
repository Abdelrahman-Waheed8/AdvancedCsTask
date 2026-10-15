using System.Collections;

public class Question6
{
    public static void RemoveOdd(ArrayList arr)
    {
        if(arr == null) return;

        for(int i = arr.Count - 1; i >= 0; i--)
        {
            int odd = (int)arr[i];
            if(odd % 2 != 0) arr.Remove(odd);
        }
        foreach(int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
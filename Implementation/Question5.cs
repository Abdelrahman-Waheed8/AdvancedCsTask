
public class Question5
{
    public static void Run()
    {
        int size; 
        Console.Write("Enter Array size: ");
        while(!int.TryParse(Console.ReadLine(), out size))
        {
            Console.Write("Invalid input! Enter array size: ");
        }

        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i+1}: ");
            while(!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write($"Invalid input! Enter element {i+1}: ");
            }
        }

        HashSet<int> seen = new HashSet<int>();
        List<int> removedDup = new List<int>();
        for(int i = 0; i < size; i++)
        {
            if(!seen.Contains(arr[i]))
            {
                seen.Add(arr[i]);
                removedDup.Add(arr[i]);
            }
        }
        arr = removedDup.ToArray();

        Console.Write("After removing duplicates: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
public class Question9
{
    public static void RunBubbleSort()
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

        bool swapped = false;
        for(int i = 0; i < size - 1 ; i++)
        {
            swapped = false;
            for(int j = 0; j < size - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if(!swapped) break;
        }

        Console.WriteLine(string.Join(", ", arr));
    }
}

public class Question3
{
    public static void Run()
    {
        int size, numberOfQueries;
        Console.Write("Enter array size: ");
        while(!int.TryParse(Console.ReadLine(), out size))
        {
            Console.Write("Invalid format! Enter array size: ");
        }
        int[] numbers = new int[size];


        Console.Write("Enter number of queries: ");
        while(!int.TryParse(Console.ReadLine(), out numberOfQueries))
        {
            Console.Write("Invalid format! Enter number of queries: ");
        }

        Console.WriteLine("Enter array elements: ");
        for(int i = 0; i < numbers.Length ; i++)
        {
            Console.Write($"Enter element [{i+1}]: ");
            while(!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid format! enter a proper integer:");
            }
        }

        int[] result = new int[numberOfQueries];
        int num;
        Console.WriteLine("Enter Query values: ");
        for(int i = 0; i < result.Length ; i++)
        {
            Console.Write($"Enter Query [{i+1}]: ");
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid format! enter a proper query value:");
            }

            result[i] = CountBiggerThanX(numbers, num);
        }
        Console.WriteLine();

        Console.Write("Result of queries: ");
        for(int i = 0 ; i < result.Length; i++)
        {
            Console.Write($"{result[i]} ");
        }

    }

    private static int CountBiggerThanX(int[] numbers, int num)
    {
        int counter = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > num) counter++;
        }
        return counter;
    }
}
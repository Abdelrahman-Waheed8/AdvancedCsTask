using System.ComponentModel;

public class Question4
{
    public static bool isPalindrome()
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

        int left = 0; int right = arr.Length - 1;
        while(left < right)
        {
            if(arr[left] != arr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
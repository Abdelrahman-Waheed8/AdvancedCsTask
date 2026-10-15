using System.Security.Cryptography;

public class Question8
{
    public static void CheckBalance()
    {
        Console.Write("Enter string to check balance: ");
        string? input = Console.ReadLine();

        if(string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input");
            return;
        }

        foreach (char c in input)
        {
            if (c != '(' && c != ')' && c != '{' && c != '}' && c != '[' && c != ']')
            {
                Console.WriteLine("Invalid input! input must be '[,],{,},(,)' only.");
                return;
            }
        }

        Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        Stack<char> stack = new Stack<char>();

        foreach(char item in input)
        {
            if(pairs.ContainsValue(item)) // check 3ala el opening 
            {
                stack.Push(item);
            }
            else if(pairs.ContainsKey(item)) // check 3ala el closing
            {
                if(stack.Count == 0)
                {
                    Console.WriteLine("Not balanced");
                    return;
                }
                char topElement = stack.Pop();
                if(topElement != pairs[item])
                {
                    Console.WriteLine("Not balanced");
                    return;
                }
            }
        }

        if(stack.Count == 0)
        {
            Console.WriteLine("Balanced");

        }else Console.WriteLine("Not balanced");
    }
}
public class Question7
{
    public static void ReverseQueueUsingStack()
    {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();
        int num;
        
        Console.WriteLine("--- Enter Queue elements type 'done' or press enter to finish ---");
        while(true)
        {
            Console.Write("Enter queue element: ");
            string? input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input) || input.Equals("done"))
            {
                break;
            }

            if(int.TryParse(input, out num))
            {
                queue.Enqueue(num);
            }
            else Console.Write("Invalid format enter queue element or type 'done' to finish: ");
        }

        if(queue.Count == 0)
        {
            Console.WriteLine("No elements is enqueued.");
            return;
        }

        Console.WriteLine($"Queue Elements before reversing: {string.Join(", ", queue)}\n");

        while(queue.Count > 0)
        {
            int x = queue.Dequeue();
            stack.Push(x);
        }
        while(stack.Count > 0)
        {
            int y = stack.Pop();
            queue.Enqueue(y);
        }

        Console.WriteLine($"Queue Elements after reversing: {string.Join(", ", queue)}");
    }
}
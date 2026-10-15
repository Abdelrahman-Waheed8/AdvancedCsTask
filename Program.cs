using System.Collections;
public class Program
{
    public static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("============================================================");
        Console.WriteLine("                       Advanced C# Tasks                    ");
        Console.WriteLine("============================================================");
        Console.WriteLine("1] Reverse Array List");
        Console.WriteLine("2] Even in a new list");
        Console.WriteLine("3] Items greater than number in array");
        Console.WriteLine("4] Check array is Palindrome");
        Console.WriteLine("5] Remove duplicates from array");
        Console.WriteLine("6] Remove odd from list");
        Console.WriteLine("7] Reverse Queue using stack");
        Console.WriteLine("8] Check balance of a string of parantheses using stack");
        Console.WriteLine("9] Bubble sort optimization");
        Console.WriteLine("10] FixedSizedList<T>");
        Console.WriteLine("11] Range<T>");
        Console.WriteLine("12] Delegates");
        Console.Write("Enter your choice: ");

        while(!int.TryParse(Console.ReadLine(), out choice) || choice > 12 || choice < 1)
        {
            Console.Write("Invalid input choice must be betweeb 1 and 12: ");
        }

        switch(choice)
        {
            case 1: 
                ArrayList arrayList = new ArrayList() {5,25,10,30};
                foreach(var item in Question1.ReverseArrayList(arrayList))
                {
                    Console.WriteLine(item);
                }
                break;
            case 2:
                List<int> numbers = new List<int> {4,3,1,9,8,6};
                Console.WriteLine($"List after finding even: {string.Join(", ", Question2.EvenInList(numbers))}");
                break;
            case 3:
                Question3.Run();
                break;
            case 4:
                if(Question4.isPalindrome()) Console.WriteLine("Palindrome");
                else Console.WriteLine("Not Palindrome");
                break;
            case 5: 
                Question5.Run();
                break;
            case 6:
                ArrayList arr = new ArrayList() {5,25,12,22,6};
                Question6.RemoveOdd(arr);
                break;
            case 7:
                Question7.ReverseQueueUsingStack();
                break;
            case 8:
                Question8.CheckBalance();
                break;
            case 9:
                Question9.RunBubbleSort();
                break;
            case 10:
                FixedSizeList<int> list = new FixedSizeList<int>(4);
                Console.WriteLine("Capacity of fixed list: "+ list._capacity);
                list.Add(10);
                list.Add(20);
                list.Add(30);
                list.Add(40);

                Console.WriteLine($"Element at index 0: {list.GetAt(0)}");
                Console.WriteLine($"Element at index 1: {list[1]}");
                Console.WriteLine("Trying to access index 4 ");
                try
                {
                    Console.WriteLine($"Element at index 4: {list[4]}");
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Trying to add another element");
                try
                {
                    list.Add(50);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            case 11:
                Range<int> range = new Range<int>(20, 50); 
                Console.WriteLine($"Is 30 in range: {range.IsInRange(30)}");
                Console.WriteLine($"Is 60 in range: {range.IsInRange(60)}");
                Console.WriteLine($"Length: {range.Length()}");

                try
                {
                    Range<int> range1 = new Range<int>(30,10);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            case 12:
                RunDelegate();
                break;
        }

        // Question 10 - 12
        // FixedSizeList<int> list = new FixedSizeList<int>(3);
        // FixedSizeList<int>.Run();

        // Question 13 - 15
    }

    public static void RunDelegate()
    {
        List<Book> books = new List<Book>
        {
            new Book("ISBN-1", "Book title 1", new string[] {"Ahmed", "Abdullah"}, new DateTime(2026,2,3), 100.0m),
            new Book("ISBN-2", "Book title 2", new string[] {"Abdelrahman", "Mohammed"}, new DateTime(2020,5,25), 175.0m)
        };

        Console.WriteLine("Checking delegate with same signature to get authors -----------------");
        LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

        Console.WriteLine("Checking built in delegate to get Prices -----------------");
        LibraryEngine.ProcessBooksUsingBuiltIn(books, BookFunctions.GetPrices);

        Console.WriteLine("Using Anonymous method to get ISBN -----------------");
        LibraryEngine.ProcessBooks(books, delegate(Book b)
        {
            return b.ISBN;
        });

        Console.WriteLine("Using Lambda Expression to get publication date -----------------");
        LibraryEngine.ProcessBooks(books, (Book b) => b.PublicationDate.ToString());
    }
}
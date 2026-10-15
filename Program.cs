using System.Collections;
public class Program
{
    public static void Main(string[] args)
    {
        // QUESTION 1
        // ArrayList arrayList = new ArrayList();
        // arrayList = Question1.ReverseArrayList(new ArrayList{1,2,3,4});
        // foreach(var item in arrayList)
        // {
        //     Console.WriteLine(item);
        // }

        // QUESTION 2
        // List<int> numbers = new List<int> {1,2,3,4,5,6};
        // List<int> even = new List<int>();
        // even = Question2.EvenInList(numbers);
        // foreach(var item in even)
        // {
        //     Console.WriteLine(item);
        // }

        //Question 3
        // Question3.Run();

        //Question 4
        // if(Question4.isPalindrome())
        // {
        //     Console.WriteLine("Palindrome");
        // }
        // else
        // {
        //     Console.WriteLine("Not Palindrome");
        // }

        // Question 5
        // Question5.Run();

        // Question 6 NOT FINISHED
        // Question6.RemoveOdd(new ArrayList{1,1,5,3,2});

        // Question 7
        // Question7.ReverseQueueUsingStack();

        // Question 8
        // Question8.CheckBalance();

        // Question 9
        // Question9.RunBubbleSort();

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
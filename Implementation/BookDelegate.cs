public class Book
{
    public string ISBN {get; set;}
    public string Title {get; set;}
    public string[] Authors {get; set;}
    public DateTime PublicationDate {get; set;}
    public decimal Price {get; set;}

    public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
    {
        ISBN = _ISBN;
        Title = _Title;
        Authors = _Authors;
        PublicationDate = _PublicationDate;
        Price = _Price;
    }
    public override string ToString()
    {
        return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {string.Join(", ", Authors)}\nPublished: {PublicationDate}\nPrice: {Price}\n";
    }
}

public class BookFunctions
{
    public static string GetTitle(Book b)
    {
        return b.Title;
    }
    public static string GetAuthors(Book b)
    {
        string authors = "";
        foreach(var author in b.Authors)
        {
            authors += author + " ";
        }
        return authors;
    }
    public static string GetPrices(Book b)
    {
        string price = b.Price.ToString();
        return price;
    }
}

public delegate string BFuncDel(Book B);
public class LibraryEngine
{
    public static void ProcessBooks(List<Book> bList, BFuncDel fPtr)
    {
        foreach(Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }

    public static void ProcessBooksUsingBuiltIn(List<Book> bList, Func<Book, string> fptr)
    {
        foreach(Book B in bList)
        {
            Console.WriteLine(fptr(B));
        }
    }
}
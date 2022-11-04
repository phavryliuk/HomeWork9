
public class LibraryDomain
{
   
    public static void Main()

    {
        Library.BookName = Book.BookName;
        Library.BookAuthor = Book.BookAuthor;
        Library.BookId = Book.ISBN;
        var customer = (Customer.Name + Customer.Surname);
        var dateOfTaking = Customer.DateOfTaking;

    }
}

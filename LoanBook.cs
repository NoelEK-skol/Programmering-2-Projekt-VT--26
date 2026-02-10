partial class Program
{
    static void LoanBook()
    {
        int bookIndex;
       var allBooks = library.GetAllBooks();
        if (allBooks.Count == 0)
        {
            Console.WriteLine("Inga böcker finns tillgängliga!");
            return;
        }

        Console.WriteLine("Tillgängliga böcker att låna:");
        for (int i = 0; i < allBooks.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {allBooks[i].Titel} av {allBooks[i].Författare}");
        }

        Console.Write("Välj en bok att låna (ange nummer): ");
        if (int.TryParse(Console.ReadLine(), out bookIndex) || bookIndex < 1 || bookIndex > allBooks.Count)
        {
            Console.WriteLine("Ogiltigt val! Försök igen!");
            return;
        }

        var selectedBook = allBooks[bookIndex - 1];
        library.GetAllBooks().Remove(selectedBook);
        if (library.LoanBook(selectedBook, loggedinUser))
        {
            Console.WriteLine($"Du har lånat: {selectedBook.Titel}.");
        }
        else
        {
            Console.WriteLine($"Tyvärr: {selectedBook.Titel} är inte tillgänglig!");
        }
    }
}
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

        Console.Write("Välj en bok att låna: ");
        if (!int.TryParse(Console.ReadLine(), out bookIndex) || bookIndex < 1 || bookIndex > allBooks.Count)
        {
            Console.WriteLine("Ogiltigt val! Försök igen!");
            return;
        }

        Bok selectedBook = allBooks[bookIndex - 1];
        loans.Add(new Loan(loggedinUser.Användarnamn, selectedBook));
        library.GetAllBooks().Remove(selectedBook);
        SaveBook();
        Console.WriteLine($"Du har lånat: {selectedBook.Titel}.");
    }
}
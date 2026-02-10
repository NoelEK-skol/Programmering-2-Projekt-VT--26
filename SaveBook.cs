partial class Program
{
    static void SaveBook()
    {
        List<Bok> allBooks = library.GetAllBooks();

        using (StreamWriter writer = new StreamWriter("Textfil.txt", false))
        {
            foreach (var book in allBooks)
            {
                writer.WriteLine($"{book.Titel}, {book.Författare}, {book.Genre}");
            }
        }
    }
}    
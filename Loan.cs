public class Loan
{
    public string UserName { get; set; }
    public Bok Book { get; set; }

    public Loan(string userName, Bok book)
    {
        UserName = userName;
        Book = book;
    }
}
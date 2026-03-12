public class Loan
{
    public enum LoanStatus
    {
        Borrowed,
        Returned
    }
    public string UserName { get; set; }
    public Bok Book { get; set; }
    public LoanStatus Status { get; set; }

    public Loan(string userName, Bok book)
    {
        UserName = userName;
        Book = book;
        Status = LoanStatus.Borrowed;
    }

    public void ReturnBook()
    {
        Status = LoanStatus.Returned;
    }
}
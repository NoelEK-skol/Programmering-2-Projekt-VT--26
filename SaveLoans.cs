using Microsoft.Win32.SafeHandles;

partial class Program
{
    static void SaveLoans()
    {
        StreamWriter sr = new StreamWriter("loans.txt");
        foreach (var loan in loans)
        {
            sr.WriteLine($"{loan.UserName}, {loan.Book.Titel}, {loan.Book.Författare}");
        }
        sr.Close();
    }
}
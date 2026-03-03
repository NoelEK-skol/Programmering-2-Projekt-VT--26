partial class Program
{
    static void ShowMyLoan()
    {
        if(loans.Count == 0)
        {
            Console.WriteLine("Inga lån hittades");
            return;
        }
        var myLoans = loans.Where(l => l.UserName == loggedinUser.Användarnamn).ToList();
        
        if(myLoans.Count == 0)
        {
            Console.WriteLine("Du har inga lånade böcker");
            return;
        }

        Console.WriteLine("Dina lånade böcker:");
        for(int i = 0; i < myLoans.Count; i++)
        {
            Console.WriteLine($"* {myLoans[i].Book.Titel} av {myLoans[i].Book.Författare}");
        }
        
    }
}
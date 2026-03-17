partial class Program
{
    static void ReturnBook()
    {
        int svar;
        var myLoans = loans.Where(l => l.UserName == loggedinUser.Användarnamn).ToList();
        
        if(myLoans.Count == 0){
            Console.WriteLine("Du har inga böcker att lämna tillbaka");
            return;
        }

        Console.WriteLine("Välj en bok att lämna tillbaka: ");
        for (int i = 0; i < myLoans.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {myLoans[i].Book.Titel} av {myLoans[i].Book.Författare}");
        }
        
        bool nummer = int.TryParse(Console.ReadLine(), out svar);
        if (!nummer)
        {
            Console.WriteLine("Ange en siffra");
            return;
        }
        if (svar < 1 || svar > myLoans.Count)
        {
            Console.WriteLine("Ogiltigt val");
            return;
        }

        Loan loan = myLoans[svar - 1];
        loan.ReturnBook();
        library.GetAllBooks().Add(loan.Book);
        loans.Remove(loan);
        SaveBook();
        SaveLoans();
        
        Console.WriteLine($"Du har lämnat tillbaka {loan.Book.Titel} av {loan.Book.Författare}!");
    }

}
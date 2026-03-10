partial class Program
{
    static void LoadLoans()
    {
        StreamReader sr = new StreamReader("loans.txt");
        var parts = new string[3];
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine()!;
            parts = line.Split(", ");
            if(parts.Length == 3)
            {
                string användarnamn = parts[0];
                string titel = parts[1];
                string författare = parts[2];

                Bok book = new Bok(titel, författare, "");
                loans.Add(new Loan(användarnamn, book));
            }
        }
        sr.Close();
    }
}
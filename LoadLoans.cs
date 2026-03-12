using System;
using System.IO;
using System.Collections.Generic;
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
            if(parts.Length == 4)
            {
                string användarnamn = parts[0];
                string titel = parts[1];
                string författare = parts[2];
                Loan.LoanStatus status = Enum.Parse<Loan.LoanStatus>(parts[3]);

                Bok book = new Bok(titel, författare, "");
                Loan loan = new Loan(användarnamn, book);

                loan.Status = status;
                loans.Add(loan);
            }
        }
        sr.Close();
    }
}
partial class Program
{
    static void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("______________________");
            Console.WriteLine("[1] Låna bok");
            Console.WriteLine("[2] Lämna tillbaka bok");
            Console.WriteLine("[3] Lägg till en bok");
            Console.WriteLine("[4] Visa alla böcker");
            Console.WriteLine("[5] Sök bok");
            Console.WriteLine(" ");
            Console.WriteLine("[7] Logga ut");
            Console.WriteLine("[8] Visa alla användare");
            Console.WriteLine("[0] Avsluta");
            Console.WriteLine("______________________");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Låna bok");
            }
            if (input == 2)
            {
                Console.WriteLine("Lämna tillbaka bok");

            }
            if (input == 3)
            {
                Console.WriteLine("Lägg till en bok");
                Console.Write("Titel: ");
                string titel = Console.ReadLine()!;

                Console.Write("Författare: ");
                string författare = Console.ReadLine()!;

                Console.Write("Genre: ");
                string genre = Console.ReadLine()!;

                try
                {
                    if (string.IsNullOrWhiteSpace(titel) || string.IsNullOrWhiteSpace(författare) || string.IsNullOrWhiteSpace(genre))
                    {
                        throw new ArgumentException("Alla fält måste fyllas i!");
                    }
                }
                catch (ArgumentException a)
                {
                    Console.WriteLine(a.Message);
                    continue;
                }
                library.AddBook(new Bok(titel, författare, genre));
                StreamWriter sw = new StreamWriter("Textfil.txt", true);
                sw.WriteLine($"{dt1} {titel}, {författare}, {genre}");
                sw.Close();
                Console.WriteLine("Din bok har lagts till!");

            }
            if (input == 4)
            {
                Console.WriteLine("Visar alla böcker:");
                StreamReader sr = new StreamReader("Textfil.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                static void VisaBöcker()     //Ska läsa in böcker från txt och lägga till de i bok listan -> fixa nästa lektion
                {
                    string[] lines = File.ReadAllLines("Textfil.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(", ");
                        if(parts.Length == 3)
                        {
                        string titel = parts[0];
                        string författare = parts[1];
                        string genre = parts[2];
                        books.Add(new Bok(titel, författare, genre));
                        }
                    }
                }
                Console.WriteLine("Antal böcker i biblioteket: " + library.GetAllBooks().Count); //Antal böcker i biblioteket under en körning
                Console.WriteLine("[4] Tillbaka till menyn");
                int VisaBöckerInput = Convert.ToInt32(Console.ReadLine());
                if (VisaBöckerInput == 4)
                {
                    continue;
                }
            }
            if (input == 5)
            {
                Console.WriteLine("Sök bok");
            }
            if (input == 0)
            {
                running = false;
                break;
            }
            if (input < 1 || input > 9)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }
            if (input == 7)
            {
                loggedinUser = null!;
                return;
            }
            if (input == 8)
            {
                Console.WriteLine($"Antal användare: {users.Count}");
                Console.WriteLine("Alla användare:");
                foreach (var user in users)
                {
                    Console.WriteLine($"Användarnamn: {user.Användarnamn}");
                }
            }
            
        }
    }
}
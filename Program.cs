using System.Runtime.InteropServices;

partial class Program
{
    static List<User> users = new List<User>
    {
        new User("user1", "lösenord")
    };
    static User loggedinUser = null!;

    static void Main()
    {
        Library library = new Library();
        bool running = true;
        DateTime dt1 = DateTime.Now;

        while (running)
        {
            if (loggedinUser == null)
            {
                ShowStartMenu();
            }
            else
            {

                Console.WriteLine("[1] Låna bok");
                Console.WriteLine("[2] Lämna tillbaka bok");
                Console.WriteLine("[3] Lägg till en bok");
                Console.WriteLine("[4] Visa alla böcker");
                Console.WriteLine("[5] Sök bok");
                Console.WriteLine("[6] Avsluta");

                Console.WriteLine("[8] Logga ut");
                Console.WriteLine("[9] Visa alla användare");

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
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
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
                if (input == 6)
                {
                    running = false;
                    break;
                }
                if (input < 1 || input > 6 || input == 8 || input == 9)
                {
                    Console.WriteLine("Ogiltigt val, försök igen.");
                }
                if (input == 8)
                {
                    loggedinUser = null!;
                }
                if (input == 9)
                {
                    Console.WriteLine("Alla användare:");
                    foreach (var user in users)
                    {
                        Console.WriteLine($"Användarnamn: {user.Användarnamn}");
                    }
                }
            }
        }
    }
}

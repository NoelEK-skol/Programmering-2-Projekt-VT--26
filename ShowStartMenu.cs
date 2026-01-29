partial class Program
{
    static void ShowStartMenu()
    {
        Console.WriteLine("[1] Skapa användare");
        Console.WriteLine("[2] Logga in");
        Console.WriteLine("[3] Avsluta");

        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 1)
        {
            Console.WriteLine("Användarnamn: ");
            string användarnamn = Console.ReadLine()!;
            if (users.Any(a => a.Användarnamn == användarnamn))
            {
                Console.WriteLine("Användarnamnet är redan taget, försök igen!");
                return;
            }

            Console.WriteLine("Lösenord: ");
            string lösenord = Console.ReadLine()!;
            users.Add(new User(användarnamn, lösenord));
            Console.WriteLine("Användaren skapades!");

            StreamWriter sw = new StreamWriter("Users.txt", true);
            sw.WriteLine($"{användarnamn}, {lösenord}");
            sw.Close();
        }

        if (input == 2)
        {
            Console.WriteLine("Användarnamn: ");
            string användarnamn = Console.ReadLine()!;

            Console.WriteLine("Lösenord: ");
            string lösenord = Console.ReadLine()!;

            loggedinUser = users.Find(a => a.Användarnamn == användarnamn && a.Lösenord == lösenord)!;

            if (loggedinUser != null)
            {
                Console.WriteLine("Inloggning lyckades!");
            }
            else
            {
                Console.WriteLine("Felaktigt användarnamn eller lösenord.");
            }
        }

        if (input == 3)
        {
            Environment.Exit(0);
        }
    }
    
}
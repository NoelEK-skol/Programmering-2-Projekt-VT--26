using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Library library = new Library();
        bool running = true;
        while (running)
        {
        
            Console.WriteLine("[1] Låna bok");
            Console.WriteLine("[2] Lämna tillbaka bok");
            Console.WriteLine("[3] Lägg till en bok");
            Console.WriteLine("[5] Sök bok");
            Console.WriteLine("[4] Visa alla böcker");
            Console.WriteLine("[6] Avsluta");

            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Låna bok");
            }
            if(input == 2)
            {
                Console.WriteLine("Lämna tillbaka bok");

            }
            if(input == 3)
            {
                Console.WriteLine("Lägg till en bok");
                Console.Write("Titel: ");
                string titel = Console.ReadLine();

                Console.Write("Författare: ");
                string författare = Console.ReadLine();

                Console.Write("Genre: ");
                string genre = Console.ReadLine();

                library.AddBook(new Bok(titel, författare, genre));

            }
            if(input == 4)
            {
                Console.WriteLine("Visa alla böcker");
            }
            if(input == 5)
            {
                Console.WriteLine("Sök bok");
            }
            if(input == 6)
            {
                running = false;
                break;
            }
            if(input < 1 || input > 6)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
            }
        }
        
    }
}

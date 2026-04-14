partial class Program
{
    static void SearchBook()
    {
        try
        {
            string fil = "Textfil.txt";
            bool hittad = false;
            Console.WriteLine("Sök efter bok:");
            string sökning = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sökning))
            {
                Console.WriteLine("Sökningen kan inte vara tom");
                return;
            }

            Console.WriteLine("Böcker som hittades:"); //ifall filen innehåller
            foreach (string a in File.ReadLines(fil))
            {
                if (a.Contains(sökning, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(a);
                    hittad = true;
                }
            }
            if(!hittad) //ifall filen inte innehåller
            {
                Console.WriteLine("Ingen bok hittades");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Filen hittades inte");
            return;
        }

    }
}